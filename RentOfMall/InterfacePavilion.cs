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
    public partial class InterfacePavilion : RentOfMall.BasicForm
    {
        public Model1 db { get; set; }
        public Pavilion pv { get; set; }
        public InterfacePavilion()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ManagerC.addchange == true)
            {
                if(floorTb.Text == "" || pavilionTb.Text == "" || areaTb.Text == ""
                    || statusCmb.Text == "" || CoeficentTb.Text == "" || CostMeterTb.Text == "")
                {
                    MessageBox.Show("Внимание! Необходимо заполнить все поля!",
                        "Ошибка сохранения: пустые поля!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if(Convert.ToSingle(CoeficentTb.Text) < 0.1)
                    {
                        MessageBox.Show("Внимание! Коэффицент не может быть меньше 0,1!",
                            "Ошибка сохранения: невозможный коэффицент!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        Pavilion p = new Pavilion();
                        p.IDMall = ListOfPavilion.IDMall;
                        p.Floor = Convert.ToInt32(floorTb.Text);
                        p.NumberPavilion = pavilionTb.Text;
                        p.Area = Convert.ToDouble(areaTb.Text);
                        p.Status = statusCmb.Text;
                        p.Сoefficient = Convert.ToDouble(CoeficentTb.Text);
                        p.CostSquareMeter = Convert.ToDouble(CostMeterTb.Text);
                        db.Pavilion.Add(p);
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
            else if(ManagerC.addchange == false)
            {
                pv.IDMall = ListOfPavilion.IDMall;
                pv.Floor = Convert.ToInt32(floorTb.Text);
                pv.NumberPavilion = pavilionTb.Text;
                pv.Area = Convert.ToDouble(areaTb.Text);
                pv.Status = statusCmb.Text;
                pv.Сoefficient = Convert.ToDouble(CoeficentTb.Text);
                pv.CostSquareMeter = Convert.ToDouble(CostMeterTb.Text);
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
        public void FillComboBox()
        {
            var fillstatus = (from p in db.Pavilion
                              select p.Status).Distinct();
            statusCmb.DataSource = fillstatus.ToList();
        }
        private void InterfacePavilion_Load(object sender, EventArgs e)
        {
            if(ListOfPavilion.addchange == false)
            {
                FillComboBox();
                addChangeLb.Text = "Редактирование павильона";
                floorTb.Text = pv.Floor.ToString();
                pavilionTb.Text = pv.NumberPavilion;
                areaTb.Text = pv.Area.ToString();
                statusCmb.Text = pv.Status;
                CoeficentTb.Text = pv.Сoefficient.ToString();
                CostMeterTb.Text = pv.CostSquareMeter.ToString();
            }
            else if (ListOfPavilion.addchange == true)
            {
                addChangeLb.Text = "Добавление павильона";
                FillComboBox();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
