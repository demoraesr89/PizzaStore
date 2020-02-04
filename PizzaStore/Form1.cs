using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStore
{
    public partial class PizzaStart : Form
    {
        public PizzaStart()
        {
            InitializeComponent();
            
        }

        public static string sendname = "";  //this is the public statics that will transfer over
        public static string sendphone = "";

        private void Order_Click(object sender, EventArgs e)
        {

            if (Nametext.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Please Enter a Customer");
            }

            else
            {
                sendname = Nametext.Text;
                sendphone = Phone.Text;
                Pizzamenu pm = new Pizzamenu();
                this.Hide();
                pm.ShowDialog();
            }
        }
    }
}
