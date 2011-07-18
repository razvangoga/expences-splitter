namespace WinForms.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.overviewTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.showReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addExpensePanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expensesForCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.expenseValueTextBox = new System.Windows.Forms.TextBox();
            this.addReceiptPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.payedByBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addReceiptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptValueTextBox = new System.Windows.Forms.TextBox();
            this.loadFromFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.addReceiptWithSplitToAllButton = new System.Windows.Forms.Button();
            this.addRemainderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addExpensePanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.addReceiptPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payedByBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(768, 482);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.overviewTreeView);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 482);
            this.panel2.TabIndex = 0;
            // 
            // overviewTreeView
            // 
            this.overviewTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewTreeView.Location = new System.Drawing.Point(0, 25);
            this.overviewTreeView.Name = "overviewTreeView";
            this.overviewTreeView.Size = new System.Drawing.Size(256, 457);
            this.overviewTreeView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReportToolStripButton,
            this.toolStripSeparator1,
            this.loadFromFileToolStripButton,
            this.saveToFileToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(256, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // showReportToolStripButton
            // 
            this.showReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("showReportToolStripButton.Image")));
            this.showReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showReportToolStripButton.Name = "showReportToolStripButton";
            this.showReportToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.showReportToolStripButton.Text = "Report";
            this.showReportToolStripButton.Click += new System.EventHandler(this.showReportToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // loadFromFileToolStripButton
            // 
            this.loadFromFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("loadFromFileToolStripButton.Image")));
            this.loadFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFromFileToolStripButton.Name = "loadFromFileToolStripButton";
            this.loadFromFileToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.loadFromFileToolStripButton.Text = "Load";
            this.loadFromFileToolStripButton.Click += new System.EventHandler(this.loadFromFileToolStripButton_Click);
            // 
            // saveToFileToolStripButton
            // 
            this.saveToFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToFileToolStripButton.Image")));
            this.saveToFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToFileToolStripButton.Name = "saveToFileToolStripButton";
            this.saveToFileToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToFileToolStripButton.Text = "Save";
            this.saveToFileToolStripButton.Click += new System.EventHandler(this.saveToFileToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addExpensePanel);
            this.panel1.Controls.Add(this.addReceiptPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 482);
            this.panel1.TabIndex = 0;
            // 
            // addExpensePanel
            // 
            this.addExpensePanel.Controls.Add(this.groupBox2);
            this.addExpensePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpensePanel.Location = new System.Drawing.Point(0, 100);
            this.addExpensePanel.Name = "addExpensePanel";
            this.addExpensePanel.Size = new System.Drawing.Size(508, 382);
            this.addExpensePanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addRemainderButton);
            this.groupBox2.Controls.Add(this.expensesForCheckedListBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addExpenseButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.expenseValueTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expenses";
            // 
            // expensesForCheckedListBox
            // 
            this.expensesForCheckedListBox.FormattingEnabled = true;
            this.expensesForCheckedListBox.Location = new System.Drawing.Point(106, 62);
            this.expensesForCheckedListBox.Name = "expensesForCheckedListBox";
            this.expensesForCheckedListBox.Size = new System.Drawing.Size(100, 94);
            this.expensesForCheckedListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "For";
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(222, 34);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(89, 23);
            this.addExpenseButton.TabIndex = 5;
            this.addExpenseButton.Text = "Add";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value";
            // 
            // expenseValueTextBox
            // 
            this.expenseValueTextBox.Location = new System.Drawing.Point(106, 36);
            this.expenseValueTextBox.Name = "expenseValueTextBox";
            this.expenseValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.expenseValueTextBox.TabIndex = 3;
            // 
            // addReceiptPanel
            // 
            this.addReceiptPanel.Controls.Add(this.groupBox1);
            this.addReceiptPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addReceiptPanel.Location = new System.Drawing.Point(0, 0);
            this.addReceiptPanel.Name = "addReceiptPanel";
            this.addReceiptPanel.Size = new System.Drawing.Size(508, 100);
            this.addReceiptPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addReceiptWithSplitToAllButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.addReceiptButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.receiptValueTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payed by";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.payedByBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Name";
            // 
            // payedByBindingSource
            // 
            this.payedByBindingSource.DataSource = typeof(DomainModel.Person);
            // 
            // addReceiptButton
            // 
            this.addReceiptButton.Location = new System.Drawing.Point(222, 20);
            this.addReceiptButton.Name = "addReceiptButton";
            this.addReceiptButton.Size = new System.Drawing.Size(89, 23);
            this.addReceiptButton.TabIndex = 0;
            this.addReceiptButton.Text = "Add";
            this.addReceiptButton.UseVisualStyleBackColor = true;
            this.addReceiptButton.Click += new System.EventHandler(this.addReceiptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // receiptValueTextBox
            // 
            this.receiptValueTextBox.Location = new System.Drawing.Point(106, 22);
            this.receiptValueTextBox.Name = "receiptValueTextBox";
            this.receiptValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiptValueTextBox.TabIndex = 1;
            // 
            // loadFromFileOpenFileDialog
            // 
            this.loadFromFileOpenFileDialog.Title = "Select the acounting session you wish to load";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save the accounting session";
            // 
            // addReceiptWithSplitToAllButton
            // 
            this.addReceiptWithSplitToAllButton.Location = new System.Drawing.Point(222, 46);
            this.addReceiptWithSplitToAllButton.Name = "addReceiptWithSplitToAllButton";
            this.addReceiptWithSplitToAllButton.Size = new System.Drawing.Size(89, 23);
            this.addReceiptWithSplitToAllButton.TabIndex = 4;
            this.addReceiptWithSplitToAllButton.Text = "Add to All";
            this.addReceiptWithSplitToAllButton.UseVisualStyleBackColor = true;
            this.addReceiptWithSplitToAllButton.Click += new System.EventHandler(this.addReceiptWithSplitToAllButton_Click);
            // 
            // addRemainderButton
            // 
            this.addRemainderButton.Location = new System.Drawing.Point(222, 61);
            this.addRemainderButton.Name = "addRemainderButton";
            this.addRemainderButton.Size = new System.Drawing.Size(89, 23);
            this.addRemainderButton.TabIndex = 8;
            this.addRemainderButton.Text = "Add remainder";
            this.addRemainderButton.UseVisualStyleBackColor = true;
            this.addRemainderButton.Click += new System.EventHandler(this.addRemainderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses Splitter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.addExpensePanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.addReceiptPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payedByBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView overviewTreeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton showReportToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel addExpensePanel;
        private System.Windows.Forms.TextBox receiptValueTextBox;
        private System.Windows.Forms.Panel addReceiptPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addReceiptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expenseValueTextBox;
        private System.Windows.Forms.CheckedListBox expensesForCheckedListBox;
        private System.Windows.Forms.BindingSource payedByBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loadFromFileToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToFileToolStripButton;
        private System.Windows.Forms.OpenFileDialog loadFromFileOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button addReceiptWithSplitToAllButton;
        private System.Windows.Forms.Button addRemainderButton;
    }
}

