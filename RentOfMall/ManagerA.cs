﻿using System;
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
    public partial class ManagerA : RentOfMall.BasicForm
    {
        public static bool addchange = false;
        Model1 db = new Model1();
        public ManagerA()
        {
            InitializeComponent();
        }

        private void ManagerA_Load(object sender, EventArgs e)
        {
            renterBindingSource.DataSource = db.Renter.ToList();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Renter r = (Renter)renterBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действтиельно хотите удалить арендатора - " +
                r.Name.ToString(), "Удаление арендатора",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Renter.Remove(r);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            renterBindingSource.DataSource = db.Renter.ToList();
        }

        private void addRentButton_Click(object sender, EventArgs e)
        {
            ManagerA.addchange = true;
            InterfaceOfRenter ir = new InterfaceOfRenter();
            ir.db = db;
            DialogResult dr = ir.ShowDialog();
            if(dr == DialogResult.OK)
            {
                renterBindingSource.DataSource = db.Renter.ToList();
            }
        }

        private void changeRentButton_Click(object sender, EventArgs e)
        {
            ManagerA.addchange = false;
            InterfaceOfRenter ir = new InterfaceOfRenter();
            Renter r = (Renter)renterBindingSource.Current;
            ir.db = db;
            ir.r = r;
            DialogResult dr = ir.ShowDialog();
            if(dr == DialogResult.OK)
            {
                renterBindingSource.DataSource = db.Renter.ToList();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorization.au.Show();
            this.Close();
        }
    }
}
