using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Receipt
    {
        private decimal _totalAmount = 0;
        private List<Expense> _expenses = new List<Expense>();
        private Person _payedBy = null;

        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        public List<Expense> Expenses
        {
            get { return _expenses; }
            set { _expenses = value; }
        }
        public Person PayedBy
        {
            get { return _payedBy; }
            set { _payedBy = value; }
        }

        public decimal Remainder
        {
            get
            {
                decimal expenseAmount = (from e in this._expenses
                                         select e.Amount).Sum();
                return this._totalAmount - expenseAmount;
            }
        }

        public Receipt()
        {

        }
    }
}
