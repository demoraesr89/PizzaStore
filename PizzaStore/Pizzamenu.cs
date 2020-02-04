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
    public partial class Pizzamenu : Form
    {
        public Pizzamenu()
        {
            InitializeComponent();
            
        }

        private double sm=5.99, med=7.99, l=12.99, price=0; //declared the privates so we can get a mulitplies of each item
        private double meat = 2.99, greens = 2.99;
        private double extrac = 2.00, peppi = 1.50, bananap = 2.00, jalepeno = 2.00;


        private void PizzaAdd_Click(object sender, EventArgs e)
        {
            if(!Small.Checked && !Medium.Checked && !Large.Checked)
            {
                MessageBox.Show("Please Choose Size");
            }

            if (Small.Checked)
            {

                ListViewItem fm = new ListViewItem("***Small Pizza");
                fm.SubItems.Add("5.99");
                this.listView1.Items.Add(fm);
                
                price += sm;                    //this will sum it up
                
                label3.Text = price.ToString();

                if (Small.Checked == Meat.Checked)
                {

                    ListViewItem fm1 = new ListViewItem("MeatLovers");
                    fm1.SubItems.Add("2.99");
                    this.listView1.Items.Add(fm1);
                 
                    price += meat;
                    label3.Text = price.ToString();
                }

                if (Small.Checked == veggie.Checked)
                {
                    ListViewItem fm2 = new ListViewItem("Garden Fresh");
                    fm2.SubItems.Add("2.99");
                    this.listView1.Items.Add(fm2);
                   
                    price += greens;
                    label3.Text = price.ToString();
                }
                if (Small.Checked == Cheese.Checked)
                {
                    ListViewItem fm3 = new ListViewItem("Cheese Only");
                    fm3.SubItems.Add("0.00");
                    this.listView1.Items.Add(fm3);
                  
                    price += 0;

                    label3.Text = price.ToString();
                }
            }

            if (Medium.Checked)
            {
                ListViewItem fm = new ListViewItem("***Medium Pizza");
                fm.SubItems.Add("7.99");
                this.listView1.Items.Add(fm);

                price += med;
                label3.Text = price.ToString();

                if (Medium.Checked == Meat.Checked)
                {
                    ListViewItem fm1 = new ListViewItem("Meat Lovers");
                    fm1.SubItems.Add("2.99");
                    this.listView1.Items.Add(fm1);

                    price += meat;
                    label3.Text = price.ToString();
                }

                if (Medium.Checked == veggie.Checked)
                {
                    ListViewItem fm2 = new ListViewItem("Garden Fresh");
                    fm2.SubItems.Add("2.99");
                    this.listView1.Items.Add(fm2);

                    price += greens;
                    label3.Text = price.ToString();

                }
                if (Medium.Checked == Cheese.Checked)
                {
                    ListViewItem fm3 = new ListViewItem("Cheese Only");
                    fm3.SubItems.Add("0.00");
                    this.listView1.Items.Add(fm3);

                    price += 0;
                    label3.Text = price.ToString();
                }
            }
            if (Large.Checked)
            { 
                ListViewItem fm = new ListViewItem("***Large Pizza");
                fm.SubItems.Add("12.99");
                this.listView1.Items.Add(fm);

                price += l ;
                label3.Text = price.ToString();

                if (Large.Checked == Meat.Checked)
                {
                    ListViewItem fm1 = new ListViewItem("Meat Lovers");
                    fm1.SubItems.Add("2.99");
                    this.listView1.Items.Add(fm1);

                    price += meat;
                    label3.Text = price.ToString();
                }

                if (Large.Checked == veggie.Checked)
                {
                    ListViewItem fm2 = new ListViewItem("Garden Fresh");
                    fm2.SubItems.Add("2.99");
                    this.listView1.Items.Add(fm2);

                    price += greens;
                    label3.Text = price.ToString();
                }
                if (Large.Checked == Cheese.Checked)
                {
                    ListViewItem fm3 = new ListViewItem("Cheese Only");
                    fm3.SubItems.Add("0.00");
                    this.listView1.Items.Add(fm3);

                    price += 0;
                    label3.Text = price.ToString();
                }
            }


            if (XC.Checked)
            {
                ListViewItem fm1 = new ListViewItem("+Extra Cheese"); //only if the option is choosen
                fm1.SubItems.Add("2.00");
                this.listView1.Items.Add(fm1);

                price += extrac;
                label3.Text = price.ToString();
            }
            if (pepperoni.Checked)
            {
                ListViewItem fm1 = new ListViewItem("+Pepperoni");
                fm1.SubItems.Add("1.50");
                this.listView1.Items.Add(fm1);

                price += peppi;
                label3.Text = price.ToString();
            }
            if (BananaP.Checked)
            {
                ListViewItem fm1 = new ListViewItem("+Banana Peppers");
                fm1.SubItems.Add("2.00");
                this.listView1.Items.Add(fm1);

                price += bananap;
                label3.Text = price.ToString();
            }
            if (jalapeno.Checked)
            {
                ListViewItem fm1 = new ListViewItem("+ Jalapeno");
                fm1.SubItems.Add("2.00");
                this.listView1.Items.Add(fm1);

                price += jalepeno;
                label3.Text = price.ToString();
            }

        }
            


        private void Pizzamenu_Load(object sender, EventArgs e)
        {
            label1.Text = PizzaStart.sendname;
            label2.Text = PizzaStart.sendphone;
        }

        private double cookies = 5.99, brownies = 5.99, cinnaminroll = 5.99;

        private void DessertAdd_Click(object sender, EventArgs e)
        {
            if (cookie.Checked)
            {
                ListViewItem fm = new ListViewItem("Cookie Pie");
                fm.SubItems.Add("5.99");
                this.listView1.Items.Add(fm);

                price += cookies;
                label3.Text = price.ToString();
            }
            if (brownie.Checked)
            {
                ListViewItem fm = new ListViewItem("Brownie Cake");
                fm.SubItems.Add("5.99");
                this.listView1.Items.Add(fm);

                price += brownies;
                label3.Text = price.ToString();
            }
            if (cinnamin.Checked)
            {
                ListViewItem fm = new ListViewItem("Cinnamin Pull Apart Knots");
                fm.SubItems.Add("5.99");
                this.listView1.Items.Add(fm);

                price += cinnaminroll;
                label3.Text = price.ToString();
            }
        }

        private double soda = 1.99;
        private void DrinkAdd_Click(object sender, EventArgs e)
        {
            if (coke.Checked)
            {
                ListViewItem fm = new ListViewItem("Coke");
                fm.SubItems.Add("1.99");
                this.listView1.Items.Add(fm);

                price += soda;
                label3.Text = price.ToString();
            }
            if (sprite.Checked)
            {
                ListViewItem fm = new ListViewItem("Sprite");
                fm.SubItems.Add("1.99");
                this.listView1.Items.Add(fm);

                price += soda;
                label3.Text = price.ToString();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem EachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(EachItem);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Pizzamenu pm = new Pizzamenu();
            pm.Show();
            this.Dispose(false);
        }

        public static string TransferPrice = "";
        private void Pay_Click(object sender, EventArgs e)
        {

            if (label3.Text == "")
            {
                MessageBox.Show("Please Order to Continue");
            } //if Label is blank, it will not proceed

            else
            {
                TransferPrice = label3.Text;

                FinishedPay fp = new FinishedPay();
                this.Hide();
                fp.ShowDialog();
            }  //once condition are met: it transfer over
        }
    }
}
