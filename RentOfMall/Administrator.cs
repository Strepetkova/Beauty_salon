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
        public static bool addchange = false;
        Model1 db = new Model1();
        List<Employee> employee = new List<Employee>();
        List<Employee> employee1 = new List<Employee>();
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
            employee1 = db.Employee.ToList();
            employeeBindingSource.DataSource = db.Employee.ToList();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            ZeroSearchLB.Visible = false;
            employee = employee1;
            int nSearch = SearchTb.Text.Length;
            employee = employee.Where(p => (p.Surname.Length >= nSearch) && p.Surname.Contains(SearchTb.Text)).ToList();
            employeeBindingSource.DataSource = employee;
            if (employee.Count == 0)
            {
                ZeroSearchLB.Visible = true;
            }
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

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            Administrator.addchange = true;
            InterfaceEmployee ie = new InterfaceEmployee();
            ie.db = db;
            DialogResult dr = ie.ShowDialog();
            if (dr == DialogResult.OK)
            {
                employeeBindingSource.DataSource = db.Employee.ToList();
            }
        }

        private void changeEmployeeBtn_Click(object sender, EventArgs e)
        {
            Administrator.addchange = false;
            InterfaceEmployee ie = new InterfaceEmployee();
            Employee em = (Employee)employeeBindingSource.Current;
            ie.db = db;
            ie.em = em;
            DialogResult dr = ie.ShowDialog();
            if (dr == DialogResult.OK)
            {
                employeeBindingSource.DataSource = db.Employee.ToList();
            }
        }
    }
}
