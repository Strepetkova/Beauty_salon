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
    public partial class ListOfPavilion : RentOfMall.BasicForm
    {
        public static string pavilion;
        public static bool addchange;
        public static int IDMall;
        Model1 db = new Model1();
        public ListOfPavilion()
        {
            InitializeComponent();
        }

        private void ListOfPavilion_Load(object sender, EventArgs e)
        {
            ZeroLb.Visible = false;
            filterZero.Visible = false;
            /*присвоение полям Название и Статус
             значения с формы Интерфейс ТЦ*/
            NameMallTb.Text = InterfaceMall.name;
            statusMallTb.Text = InterfaceMall.status;

            FillTable();

            var floorCmb = (from p in db.Pavilion
                            select p.Floor).Distinct();
            FilterFoorCmb.DataSource = floorCmb.ToList();

            var statusCmb = (from p in db.Pavilion
                             select p.Status).Distinct();
            filterStatusCmb.DataSource = statusCmb.ToList();
        }
        public void FillTable()
        {
            ZeroLb.Visible = false;
            filterZero.Visible = false;
            //вычисление ID ТЦ по его названию с помощью linq
            var ID = (from p in db.Mall
                      where p.NameMall == InterfaceMall.name
                      select p.ID).First();
            ListOfPavilion.IDMall = ID;
            var pavilion = from p in db.Pavilion
                           where p.IDMall == ListOfPavilion.IDMall
                           select p;
            pavilionBindingSource.DataSource = pavilion.ToList();
            int countRows = pavilion.Count();
            if (countRows == 0)
                ZeroLb.Visible = true;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void filterStatusCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterZero.Visible = false;
            var ID = (from p in db.Mall
                      where p.NameMall == NameMallTb.Text
                      select p.ID).First();
            ListOfPavilion.IDMall = ID;
            var pavilion = from p in db.Pavilion
                           where p.IDMall == ListOfPavilion.IDMall
                           select p;
            int countRows = pavilion.Count();
            if (countRows == 0)
                ZeroLb.Visible = true;
            if (filterStatusCmb.SelectedValue == null) return;
            var filterStatus = from p in pavilion
                               where p.Status == (string)filterStatusCmb.SelectedValue
                               select p;
            pavilionBindingSource.DataSource = filterStatus.ToList();
            int Zero = filterStatus.Count();
            if (Zero == 0)
                filterZero.Visible = true;
        }

        private void FilterFoorCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterZero.Visible = false;
            var ID = (from p in db.Mall
                      where p.NameMall == NameMallTb.Text
                      select p.ID).First();
            ListOfPavilion.IDMall = ID;
            var pavilion = from p in db.Pavilion
                           where p.IDMall == ListOfPavilion.IDMall
                           select p;
            int countRows = pavilion.Count();
            if (countRows == 0)
                ZeroLb.Visible = true;
            if (FilterFoorCmb.SelectedValue == null) return;
            var filterFoor = from p in pavilion
                             where p.Floor == (int)FilterFoorCmb.SelectedValue
                             select p;
            pavilionBindingSource.DataSource = filterFoor.ToList();
            int Zero = filterFoor.Count();
            if (Zero == 0)
                filterZero.Visible = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Pavilion pav = (Pavilion)pavilionBindingSource.Current;
            if (pav.Status == "Забронирован" || pav.Status == "Арендован")
            {
                MessageBox.Show("Внимание! Нельзя удалить данный павильон! Так как он арендован или забронирован",
                    "Ошибка удаления: арендован или забронирован",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Вы действтиельно хотите удалить павильон - " +
                    pav.NumberPavilion.ToString(), "Удаление павильона",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.Pavilion.Remove(pav);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                FillTable();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListOfPavilion.addchange = true;
            InterfacePavilion ip = new InterfacePavilion();
            ip.db = db;
            DialogResult dr = ip.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FillTable();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ListOfPavilion.addchange = false;
            InterfacePavilion ip = new InterfacePavilion();
            Pavilion pv = (Pavilion)pavilionBindingSource.Current;
            if (pv.Status == "Забронирован" || pv.Status == "Арендован")
            {
                MessageBox.Show("Внимание! Нельзя редактировать данный павильон! Так как он арендован или забронирован",
                    "Ошибка редактирования: арендован или забронирован",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ip.db = db;
                ip.pv = pv;
                DialogResult dr = ip.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    FillTable();
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            pavilionBindingSource.DataSource = null;
            FillTable();
        }
    }
}
