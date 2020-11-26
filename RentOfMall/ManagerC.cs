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
    public partial class ManagerC : RentOfMall.BasicForm
    {
        Model1 db = new Model1();
        public ManagerC()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Authorization.au.Show();
            this.Close();
        }

        private void ManagerC_Load(object sender, EventArgs e)
        {
            mallBindingSource.DataSource = db.Mall.ToList();
        }

        private void sortSityButton_Click(object sender, EventArgs e)
        {
            List<Mall> mall = (List<Mall>)mallBindingSource.List;
            mall.Sort(MallSitySort);
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = mall;
        }
        int MallSitySort(Mall m1, Mall m2)
        {
            int MallSort = m1.Sity.CompareTo(m2.Sity);
            return MallSort;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            mallBindingSource.DataSource = null;
            mallBindingSource.DataSource = db.Mall.ToList<Mall>();
        }

        private void sortStatusButton_Click(object sender, EventArgs e)
        {
            //List<Mall> mall1 = (List<Mall>)mallBindingSource.List;
            //mall1.Sort(MallStatusSort);
            List<Mall> malls = new List<Mall>();
            

        }
        //int MallStatusSort(Mall m1)
        //{
        //    if (m1.Status == "План")
        //        return -1;
        //    else if (m1.Status == "Строительсто")
        //        return 0;
        //    else if (m1.Status == "Реализация")
        //        return 1;
        //    else
        //        return 2;
        //}
    }
}
