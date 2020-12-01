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
    public partial class Administrator : RentOfMall.BasicForm
    {
        Model1 db = new Model1();
        public Administrator()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorization.au.Show();
            this.Close();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = db.Employee.ToList();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Employee em = (Employee)employeeBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действтиельно хотите удалить сотрудника - " +
                em.Surname.ToString(), "Удаление сотрудника",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Employee.Remove(em);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            employeeBindingSource.DataSource = db.Employee.ToList();
        }
    }
}
