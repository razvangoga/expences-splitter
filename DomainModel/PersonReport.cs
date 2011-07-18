using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class PersonReport
    {
        private Person _person = new Person();
        private decimal _hasSpent = 0;
        private decimal _hasConsumed = 0;

        public string PersonName
        {
            get
            {
                return this._person.Name;
            }
        }
        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }
        public decimal HasSpent
        {
            get { return _hasSpent; }
            set { _hasSpent = value; }
        }
        public decimal HasConsumed
        {
            get { return _hasConsumed; }
            set { _hasConsumed = value; }
        }
        public decimal Balance
        {
            get
            {
                return this._hasSpent - this._hasConsumed;
            }
        }

        public PersonReport()
        {

        }
    }
}
