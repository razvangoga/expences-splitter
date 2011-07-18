using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ReportGenerator
    {
        private AccountingSession _accountingSession = null;
        private Report _report = new Report();

        public ReportGenerator(AccountingSession accountingSession)
        {
            this._accountingSession = accountingSession;
        }

        public Report GenerateReport()
        {
            this.BuildReport();

            return this._report;
        }

        private void BuildReport()
        {
            foreach (Receipt receipt in this._accountingSession.Receipts)
            {
                PersonReport personReportForSpending = this._report.FindByPerson(receipt.PayedBy);

                if (personReportForSpending == null)
                    this._report.Add(new PersonReport()
                    {
                        Person = receipt.PayedBy,
                        HasSpent = receipt.TotalAmount,
                        HasConsumed = 0
                    });
                else
                    personReportForSpending.HasSpent += receipt.TotalAmount;

                foreach (Expense expense in receipt.Expenses)
                {
                    decimal valuePerPerson = Decimal.Round(expense.Amount / expense.Persons.Count, 2);

                    foreach (Person person in expense.Persons)
                    {
                        PersonReport personReportForConsuming = this._report.FindByPerson(person);

                        if (personReportForConsuming == null)
                            this._report.Add(new PersonReport()
                            {
                                Person = person,
                                HasConsumed = valuePerPerson,
                                HasSpent = 0
                            });
                        else
                            personReportForConsuming.HasConsumed += valuePerPerson;
                    }
                }
            }
        }
    }
}
