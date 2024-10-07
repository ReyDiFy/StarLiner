using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemNamespace
{
    abstract class item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public double price()
        {
            return item_price;
        }

        public item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }
        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);

    }

    class DiscountedItem : item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;
        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
        {
            item_discount = discount * 0.01;
        }
        public override double getTotalPrice()
        {
            discounted_price = ((item_price * item_quantity) - (item_price * item_quantity) * item_discount);
            return discounted_price;
        }
        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }
        public double getChange()
        {
            return payment_amount - discounted_price;
        }
    }
}
