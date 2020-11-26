﻿using System;
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
    public partial class Authorization : RentOfMall.BasicForm
    {

        public static int count = 0;

        Model1 db = new Model1();
        public static Authorization au { get; set; }
        public static Employee em { get; set; }
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (Authorization.count >= 3)
            {
                Captcha captcha = new Captcha();
                DialogResult dr = captcha.ShowDialog();
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (Authorization.count >= 3)
            {
                Captcha captcha = new Captcha();
                DialogResult dr = captcha.ShowDialog();
            }
            if (logintb.Text == "" || passwordtb.Text == "")
            {
                MessageBox.Show("Внимание! Необходимо заполнить все поля!", "Ошибка входа в систему!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Authorization.count++;
                return;
            }
            //var help = from passOut in db.Employee
            //           where passOut.Login == logintb.Text
            //           where passOut.Password == passwordtb.Text
            //           select passOut;
            //if( help != null)
            //{
            //    help.Where(x => x.Role == "Администратор");

            //}
            Employee employee = db.Employee.FirstOrDefault(x => x.Login==logintb.Text);
            if ((employee != null) && employee.Password == passwordtb.Text)
            {
                em = employee;
                au = this;
                if(employee.Role == "Администратор"){ }
                else if (employee.Role == "Менеджер А") { }
                else if (employee.Role == "Менеджер С")
                {
                    ManagerC mc = new ManagerC();
                    mc.Show();
                    Hide();
                }
                else if (employee.Role == "Удален") { }
            }
            else
            {
                MessageBox.Show($"Сотрудника с логином {logintb} не существует! Проверьте правильность введенных логина и пароля!",
                    "Ошибка входа в систему!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Authorization.count++;
                return;
            }
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
