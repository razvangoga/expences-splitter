using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Person : IEquatable<Person>
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person()
        {

        }

        #region IEquatable<Person> Members

        public bool Equals(Person other)
        {
            if (other != null)
                return this.Name.Equals(other.Name, StringComparison.CurrentCultureIgnoreCase);
            else
                return false;
        }

        #endregion
    }
}
