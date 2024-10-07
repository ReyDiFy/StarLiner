using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ItemNamespace;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double paymenter = 0;
        public int quantity = 0;
        double IPrice = 0;
        double discounter = 0;
        public void Computer()
        {
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (Payment.Text != "")
            {
                paymenter = Convert.ToDouble(Payment.Text);
            }
            string IName = ItemBoxName.Text;
            if (PriceBox.Text != "")
            {
                IPrice = Convert.ToDouble(PriceBox.Text);
            }
            if (QuantityBox.Text != "")
            {
                quantity = Convert.ToInt32(QuantityBox.Text);
            }
            DiscountedItem DItemPaid = new DiscountedItem(IName, IPrice, quantity, discounter);
            DItemPaid.getTotalPrice();
            DItemPaid.setPayment(paymenter);
            ChangeBox.Text = "Change: P" + DItemPaid.getChange().ToString("F1");
        }

        private void Payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiscountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            
            string IName = ItemBoxName.Text;
            if (PriceBox.Text != "")
            {
                IPrice = Convert.ToDouble(PriceBox.Text);
            }
            if (QuantityBox.Text != "")
            {
                quantity = Convert.ToInt32(QuantityBox.Text);
            }
            if (DiscountBox.Text != "") 
            {
                discounter = Convert.ToDouble(DiscountBox.Text);
            }
            DiscountedItem DItem = new DiscountedItem(IName, IPrice, quantity, discounter);
            TotalAmount.Text = "Total Amount: P" + DItem.getTotalPrice().ToString("F1");
                    }
                }
            }

