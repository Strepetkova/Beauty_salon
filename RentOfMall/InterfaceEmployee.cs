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
    public partial class InterfaceEmployee : RentOfMall.BasicForm
    {
        public Model1 db { get; set; }
        public Employee em { get; set; }
        public InterfaceEmployee()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фото сотрудника";
            ofd.Filter = "Файл jpg, gif, png| *.jpg;*.gif;*.png|Все файлы (*.*)|*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                photoPcb.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(Administrator.addchange == true)
            {
                if(surnameTb.Text ==""||nameTb.Text ==""|| middleNameTb.Text ==""||
                    loginTb.Text==""||passwordTb.Text==""||genderTb.Text==""||
                    roleCmb.Text == "" || phoneTb.Text == "" || photoPcb.Image == null)
                {
                    MessageBox.Show("Внимание! Необходимо заполнить все поля!",
                        "Ошибка сохранения: пустые поля!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Employee em = new Employee();
                    em.Surname = surnameTb.Text;
                    em.Name = nameTb.Text;
                    em.MiddleName = middleNameTb.Text;
                    em.Login = loginTb.Text;
                    em.Password = passwordTb.Text;
                    em.Gender = genderTb.Text;
                    em.Role = roleCmb.Text;
                    em.Phone = phoneTb.Text;
                    if (photoPcb.Image == null)
                    {
                        em.Photo = null;
                    }
                    else
                    {
                        ImageConverter ic = new ImageConverter();
                        byte[] b = (byte[])ic.ConvertTo(photoPcb.Image, typeof(byte[]));
                        em.Photo = b;
                    }
                    db.Employee.Add(em);
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
            else if(Administrator.addchange == false)
            {
                em.Surname = surnameTb.Text;
                em.Name = nameTb.Text;
                em.MiddleName = middleNameTb.Text;
                em.Login = loginTb.Text;
                em.Password = passwordTb.Text;
                em.Gender = genderTb.Text;
                em.Role = roleCmb.Text;
                em.Phone = phoneTb.Text;
                if (photoPcb.Image == null)
                {
                    em.Photo = null;
                }
                else
                {
                    ImageConverter ic = new ImageConverter();
                    byte[] b = (byte[])ic.ConvertTo(photoPcb.Image, typeof(byte[]));
                    em.Photo = b;
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

        private void InterfaceEmployee_Load(object sender, EventArgs e)
        {
            if(Administrator.addchange == false)
            {
                FillComboBox();
                ChangeNamelb.Text = "Редактирование сотрудника";
                surnameTb.Text = em.Surname;
                nameTb.Text = em.Name;
                middleNameTb.Text = em.MiddleName;
                loginTb.Text = em.Login;
                passwordTb.Text = em.Password;
                genderTb.Text = em.Gender;
                roleCmb.Text = em.Role;
                phoneTb.Text = em.Phone;
                if (em.Photo == null)
                {
                    photoPcb.Image = null;
                }
                else
                {
                    ImageConverter conv = new ImageConverter();
                    photoPcb.Image = (Image)conv.ConvertFrom(em.Photo);
                }
            }
            else if(Administrator.addchange == true)
            {
                ChangeNamelb.Text = "Добавление сотрудника";
                FillComboBox();
            }
        }
        public void FillComboBox()
        {
            var role = (from p in db.Employee
                        select p.Role)
                        .Distinct();
            roleCmb.DataSource = role.ToList();
        }
    }
}
