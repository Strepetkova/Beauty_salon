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
    public partial class ListOfRent : RentOfMall.BasicForm
    {
        public Model1 db { get; set; }
        public Renter rent{ get; set; }
        public ListOfRent()
        {
            InitializeComponent();
        }
    }
}
