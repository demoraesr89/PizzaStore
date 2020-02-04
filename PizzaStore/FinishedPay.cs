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
    public partial class FinishedPay : Form
    {
        public FinishedPay()
        {
            InitializeComponent();
        }

        private void FinishedPay_Load(object sender, EventArgs e)
        {
            totalprice.Text = Pizzamenu.TransferPrice;           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Finished_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(totalprice.Text);
            decimal finalpay = 0;

            if (Cash.Checked)
            {
                if (change.Text == "")
                {
                    MessageBox.Show("What is the Cash? ");
                }

                else
                {
                    decimal handover = Convert.ToDecimal(change.Text);

                    finalpay = handover - price;

                    MessageBox.Show("Thank you: $ " + finalpay);
                }
            }

            if (Card.Checked)
            {
                MessageBox.Show("Your Credit Card has been Charged: $" + price);
            }

            if (Gift.Checked)
            {
                MessageBox.Show("Your Gift Card has been Charged a total of: $" + price);
            }

            if(!Cash.Checked && !Card.Checked && !Gift.Checked)
            {
                MessageBox.Show("Please Choose an Option to Pay");
                return;
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Pizzamenu pm = new Pizzamenu();
            this.Hide();
            pm.ShowDialog();
        }
    }
}
