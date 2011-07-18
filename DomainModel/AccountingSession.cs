using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class AccountingSession
    {
        public const string STR_FILE_EXTENSION = "acs";

        private DateTime _sessionDate = DateTime.Now;
        private List<Receipt> _receipts = new List<Receipt>();
        private Guid _id = Guid.NewGuid();

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime SessionDate
        {
            get { return _sessionDate; }
            set { _sessionDate = value; }
        }
        public List<Receipt> Receipts
        {
            get { return _receipts; }
            set { _receipts = value; }
        }

        public AccountingSession()
        {

        }

        public void SaveToFile()
        {
            this.SaveToFile(string.Format("Accounting Session {0} {1}.{2}",
                this.SessionDate.ToString("yyyyMMdd"),
                this._id.ToString().Replace("-", string.Empty),
                STR_FILE_EXTENSION));
        }
        public void SaveToFile(string fileName)
        {
            XmlSerializator.Serialize<AccountingSession>(this, fileName);
        }
        public static AccountingSession LoadFromFile(string fileName)
        {
            return XmlSerializator.Deserialize<AccountingSession>(fileName);
        }
    }
}
