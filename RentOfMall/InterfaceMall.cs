using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentOfMall
{
    public partial class InterfaceMall : RentOfMall.BasicForm
    {
        public Model1 db { get; set; }
        public Mall mall { get; set; }
        public InterfaceMall()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if (ManagerC.addchange == true)
            //{
                if(nametb.Text == "" || coeficenttb.Text == "" || statuscmb.Text == ""||
                    costtb.Text == "" || sitycmb.Text == "" ||
                    floortb.Text == "" || paviliontb.Text == "")
                {
                    MessageBox.Show("Внимание! Необходимо заполнить все поля, за исключением изображения!",
                        "Ошибка сохранения: пустые поля!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if(Convert.ToInt32(costtb.Text) < 0)
                    {
                        MessageBox.Show("Внимание! Цена не может быть отрицательной!",
                            "Ошибка сохранения: отрицательная цена!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        Mall m = new Mall();
                        m.NameMall = nametb.Text;
                        m.Status = statuscmb.Text;
                        m.QuantityPavilion = Convert.ToInt32(paviliontb.Text);
                        m.Sity = sitycmb.Text;
                        m.Cost = Convert.ToDouble(costtb.Text);
                        m.Сoefficient = Convert.ToDouble(coeficenttb.Text);
                        m.Floor = Convert.ToInt32(floortb.Text);
                        ImageConverter ic = new ImageConverter();
                        byte[] b = (byte[])ic.ConvertTo(imagepb.Image, typeof(byte[]));
                        m.Image = b;
                        db.Mall.Add(m);
                        try
                        {
                            db.SaveChanges();
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.InnerException.InnerException.Message);
                        }
                    }
                }
            //}
            //else if(ManagerC.addchange == false)
            //{

            //}
        }

        private void InterfaceMall_Load(object sender, EventArgs e)
        {
            if(ManagerC.addchange == false)
            {
                ChangeNamelb.Text = "Редактирование ТЦ";
                nametb.Text = mall.NameMall;
                coeficenttb.Text = mall.QuantityPavilion.ToString();
                statuscmb.Text = mall.Status;
                costtb.Text = mall.Cost.ToString();
                sitycmb.Text = mall.Sity;
                if (mall.Image == null)
                {
                    imagepb.Image = null;
                }
                else
                {
                    ImageConverter conv = new ImageConverter();
                    imagepb.Image = (Image)conv.ConvertFrom(mall.Image);
                }
                floortb.Text = mall.Floor.ToString();
                paviliontb.Text = mall.QuantityPavilion.ToString();
            }
            else if(ManagerC.addchange == true)
            {
                ChangeNamelb.Text = "Добавление ТЦ";
                var fillfilterstatus = (from p in db.Mall
                                        where p.Status != "Удален"
                                        select p.Status)
                                        .Distinct();
                statuscmb.DataSource = fillfilterstatus.ToList();

                var fillfiltersity = (from p in db.Mall
                                      select p.Sity)
                                      .Distinct();
                sitycmb.DataSource = fillfiltersity.ToList();
            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фото ТЦ";
            ofd.Filter = "Файл jpg, gif, png| *.jpg;*.gif;*.png|Все файлы (*.*)|*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                imagepb.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
