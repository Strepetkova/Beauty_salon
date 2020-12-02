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
    public partial class InterfaceOfRenter : RentOfMall.BasicForm
    {
        public Model1 db { get; set; }
        public Renter r { get; set; }
        public InterfaceOfRenter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ManagerC.addchange == true)
            {
                if(nameCompanyTb.Text == ""|| addressTb.Text == "" || phoneMaskTb.Text == "")
                {
                    MessageBox.Show("Внимание! Необходимо заполнить все поля!",
                        "Ошибка сохранения: пустые поля!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Renter r = new Renter();
                    r.Name = nameCompanyTb.Text;
                    r.Address = addressTb.Text;
                    r.Phone = phoneMaskTb.Text;
                    db.Renter.Add(r);
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
            else if(ManagerA.addchange == false)
            {
                r.Name = nameCompanyTb.Text;
                r.Address = addressTb.Text;
                r.Phone = phoneMaskTb.Text;
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

        private void InterfaceOfRenter_Load(object sender, EventArgs e)
        {
            if(ManagerA.addchange == false)
            {
                ChangeNamelb.Text = "Редактирование арендатора";
                nameCompanyTb.Text = r.Name;
                addressTb.Text = r.Address;
                phoneMaskTb.Text = r.Phone;
            }
            else if(ManagerA.addchange == true)
            {
                ChangeNamelb.Text = "Добавление арендатора";
            }
        }
    }
}
