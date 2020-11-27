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
    public partial class ManagerC : RentOfMall.BasicForm
    {
        public static bool addchange = false;

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
            NotRemoveStatus();

            var fillfiltersity = (from p in db.Mall
                                  select p.Sity)
                     .Distinct();
            filtersitycmb.DataSource = fillfiltersity.ToList();

            var fillfilterstatus = (from p in db.Mall
                                    where p.Status!="Удален"
                                    select p.Status)
                                    .Distinct();
            filterstatuscmb.DataSource = fillfilterstatus.ToList();

        }
        public void NotRemoveStatus()
        {
            var remove = from p in db.Mall
                       where p.Status != "Удален"
                       select p;
            mallBindingSource.DataSource = remove.ToList();
        }

        private void sortSityButton_Click(object sender, EventArgs e)
        {
            NotRemoveStatus();
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
            NotRemoveStatus();
        }

        private void sortStatusButton_Click(object sender, EventArgs e)
        {
            var sortOrder = new Dictionary<string, int>
            {
                {"План", 1 },
                {"Строительство", 2 },
                {"Реализация", 3 }
            };

            var defaultOrder = sortOrder.Max(x => x.Value) + 1;

            var remove = from p in db.Mall
                         where p.Status != "Удален"
                         select p;

            var sortedStatus = remove
                                .AsEnumerable()
                                .OrderBy(p => (p.Status == "План") ? 0 : 1)
                                .ThenBy(p => sortOrder.TryGetValue(p.Status, out var order) ? order : defaultOrder);
            mallBindingSource.DataSource = sortedStatus.ToList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Mall mall = (Mall)mallBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действтиельно хотите удалить ТЦ - " +
                mall.NameMall.ToString(), "Удаление ТЦ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Mall.Remove(mall);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            NotRemoveStatus();
        }

        private void addMallButton_Click(object sender, EventArgs e)
        {
            ManagerC.addchange = true;
            InterfaceMall im = new InterfaceMall();
            im.db = db;
            DialogResult dr = im.ShowDialog();
            if(dr == DialogResult.OK)
            {
                mallBindingSource.DataSource = db.Mall.ToList();
            }
        }

        private void changeMallButton_Click(object sender, EventArgs e)
        {
            ManagerC.addchange = false;
            InterfaceMall im = new InterfaceMall();
            Mall mall = (Mall)mallBindingSource.Current;
            im.db = db;
            im.mall = mall;
            DialogResult dr = im.ShowDialog();
            if (dr == DialogResult.OK)
            {
                mallBindingSource.DataSource = db.Mall.ToList();
            }
        }

        private void filtersitycmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (filtersitycmb.SelectedValue == null) return;
            var filltersity = from p in db.Mall
                              where p.Sity == (string)filtersitycmb.SelectedValue && p.Status != "Удален"
                              select p;
            mallBindingSource.DataSource = filltersity.ToList();
        }

        private void filterstatuscmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (filtersitycmb.SelectedValue == null) return;
            var fillstatus = from p in db.Mall
                             where p.Status == (string)filterstatuscmb.SelectedValue && p.Status != "Удален"
                             select p;
            mallBindingSource.DataSource = fillstatus.ToList();
        }
    }
}
