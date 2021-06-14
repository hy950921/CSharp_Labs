using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Transaction
    {
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Transaction(string date, string description, string category, decimal amount)
        {
            this.date = date;
            this.description = description;
            this.category = category;
            this.amount = amount;
        }

        public void Add(Transaction transaction)
        {

        }
    }
}
