using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DomainModel;

namespace WinForms.UI
{
    public partial class ReportForm : Form
    {
        private AccountingSession _accountingSession = null;

        public ReportForm(AccountingSession accountingSession)
        {
            InitializeComponent();

            this._accountingSession = accountingSession;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ReportGenerator reportGenerator = new ReportGenerator(this._accountingSession);
            Report report = reportGenerator.GenerateReport();

            this.personReportBindingSource.DataSource = report;
        }
    }
}
