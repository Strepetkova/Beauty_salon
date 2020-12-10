using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RentOfMall
{
    public partial class InterfaceMall : RentOfMall.BasicForm
    {
        public static bool wrong = false;
        public static string name;
        public static string status;

        List<int> ID = new List<int>();
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
            InterfaceMall.wrong = false;
            if (ManagerC.addchange == true)
            {
                if (nametb.Text == "" || coeficenttb.Text == "" || statuscmb.Text == "" ||
               costtb.Text == "" || sitycmb.Text == "" ||
               floortb.Text == "" || paviliontb.Text == "")
                {
                    MessageBox.Show("Внимание! Необходимо заполнить все поля, за исключением изображения!",
                        "Ошибка сохранения: пустые поля!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt32(costtb.Text) < 0)
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
                        m.City = sitycmb.Text;
                        m.Cost = Convert.ToDouble(costtb.Text);
                        m.Сoefficient = Convert.ToDouble(coeficenttb.Text);
                        m.Floor = Convert.ToInt32(floortb.Text);
                        if (imagepb.Image == null)
                        {
                            mall.Image = null;
                        }
                        else
                        {
                            ImageConverter ic = new ImageConverter();
                            byte[] b = (byte[])ic.ConvertTo(imagepb.Image, typeof(byte[]));
                            mall.Image = b;
                        }
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
            }
            else if (ManagerC.addchange == false)
            {
                var booked = from p in db.Pavilion
                             where p.Status == "Забронирован"
                             select p.IDMall;
                foreach (int ID1 in booked)
                {
                    ID.Add(ID1);
                }
                for (int i = 0; i < ID.Count; i++)
                {
                    if (ID[i] == Convert.ToInt32(IDtb.Text))
                    {
                        if(doublestatuslb.Text == "План")
                        {
                            MessageBox.Show("Внимание! Нельзя поставить статус 'План' данному ТЦ," +
                                    "так как в павильонах содержится статус 'Забронирован'",
                                    "Ошибка сохранения: павильоны", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                            InterfaceMall.wrong = true;
                        }
                    }
                }
                if (InterfaceMall.wrong == false)
                {
                    mall.NameMall = nametb.Text;
                    mall.Status = statuscmb.Text;
                    mall.QuantityPavilion = Convert.ToInt32(paviliontb.Text);
                    mall.City = sitycmb.Text;
                    mall.Cost = Convert.ToDouble(costtb.Text);
                    mall.Сoefficient = Convert.ToDouble(coeficenttb.Text);
                    mall.Floor = Convert.ToInt32(floortb.Text);
                    if(imagepb.Image == null)
                    {
                        mall.Image = null;
                    }
                    else
                    {
                        ImageConverter ic = new ImageConverter();
                        byte[] b = (byte[])ic.ConvertTo(imagepb.Image, typeof(byte[]));
                        mall.Image = b;
                    }
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

        }

        private void InterfaceMall_Load(object sender, EventArgs e)
        {
            if(ManagerC.addchange == false)
            {
                FillComboBox();
                ChangeNamelb.Text = "Редактирование ТЦ";
                nametb.Text = mall.NameMall;
                coeficenttb.Text = mall.Сoefficient.ToString();
                statuscmb.Text = mall.Status;
                costtb.Text = mall.Cost.ToString();
                sitycmb.Text = mall.City;
                InterfaceMall.status = statuscmb.Text;
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
                IDtb.Text = mall.ID.ToString();
            }
            else if(ManagerC.addchange == true)
            {
                ChangeNamelb.Text = "Добавление ТЦ";
                idlb.Visible = false;
                IDtb.Visible = false;
                FillComboBox();
            }
        }
        public void FillComboBox()
        {
            var fillfilterstatus = (from p in db.Mall
                                    where p.Status != "Удален"
                                    select p.Status)
                        .Distinct();
            statuscmb.DataSource = fillfilterstatus.ToList();

            var fillfiltersity = (from p in db.Mall
                                  select p.City)
                                  .Distinct();
            sitycmb.DataSource = fillfiltersity.ToList();
            InterfaceMall.status = statuscmb.Text;
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

        private void statuscmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (statuscmb.Text == "План")
                doublestatuslb.Text = "План";
            else if (statuscmb.Text == "Строительство")
                doublestatuslb.Text = "Строительство";
            else if (statuscmb.Text == "Реализация")
                doublestatuslb.Text = "Реализация";
            InterfaceMall.status = doublestatuslb.Text;

        }
        private void nametb_TextChanged(object sender, EventArgs e)
        {
            InterfaceMall.name = nametb.Text;
        }

        private void listOfPavilionButton_Click(object sender, EventArgs e)
        {
            ListOfPavilion lp = new ListOfPavilion();
            DialogResult dr = lp.ShowDialog();
        }
    }
}
