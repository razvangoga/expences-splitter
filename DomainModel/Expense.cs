using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Expense
    {
        private decimal _amount = 0;
        private List<Person> _persons = new List<Person>();

        public List<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public Expense()
        {

        }
    }
}
