using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Report : List<PersonReport>
    {
        public new void Add(PersonReport personReport)
        {
            if (this.CanAddPersonReport(personReport))
                base.Add(personReport);
            else throw new ArgumentException(string.Format("Report for {0} is already in list", personReport.Person.Name));
        }

        public new void AddRange(IEnumerable<PersonReport> personReports)
        {
            foreach (PersonReport personReport in personReports)
            {
                if (!this.CanAddPersonReport(personReport))
                    throw new ArgumentException(string.Format("Report for {0} is already in list", personReport.Person.Name));
            }

            base.AddRange(personReports);
        }

        private bool CanAddPersonReport(PersonReport personReport)
        {
            PersonReport existingPersonReport = (from pr in this
                                                 where pr.Person.Equals(personReport.Person)
                                                 select pr).FirstOrDefault();

            return existingPersonReport == null;
        }

        public PersonReport FindByPerson(Person person)
        {
            return (from pr in this
                    where pr.Person.Equals(person)
                    select pr).FirstOrDefault();
        }
    }
}
