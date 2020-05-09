namespace MSS.UI
{
    partial class Cashbook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCashbook = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTotalExpense = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCashbookRecord = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.txtCasher = new System.Windows.Forms.TextBox();
            this.panelType = new System.Windows.Forms.Panel();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.rbtnService = new System.Windows.Forms.RadioButton();
            this.rbtnSale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnIncome = new System.Windows.Forms.RadioButton();
            this.rbtnExpense = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCashbook.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashbookRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCashbook
            // 
            this.panelCashbook.Controls.Add(this.panel5);
            this.panelCashbook.Controls.Add(this.dgvCashbookRecord);
            this.panelCashbook.Controls.Add(this.groupBox1);
            this.panelCashbook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCashbook.Location = new System.Drawing.Point(0, 0);
            this.panelCashbook.Name = "panelCashbook";
            this.panelCashbook.Size = new System.Drawing.Size(1245, 537);
            this.panelCashbook.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTotalExpense);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtTotalIncome);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 495);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1245, 42);
            this.panel5.TabIndex = 3;
            // 
            // txtTotalExpense
            // 
            this.txtTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotalExpense.Location = new System.Drawing.Point(791, 10);
            this.txtTotalExpense.Name = "txtTotalExpense";
            this.txtTotalExpense.ReadOnly = true;
            this.txtTotalExpense.Size = new System.Drawing.Size(174, 26);
            this.txtTotalExpense.TabIndex = 32;
            this.txtTotalExpense.Text = "00";
            this.txtTotalExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(668, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 27);
            this.label14.TabIndex = 31;
            this.label14.Text = "ထွက်ငွေစုစုပေါင်း";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIncome.ForeColor = System.Drawing.Color.Green;
            this.txtTotalIncome.Location = new System.Drawing.Point(469, 13);
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ReadOnly = true;
            this.txtTotalIncome.Size = new System.Drawing.Size(174, 26);
            this.txtTotalIncome.TabIndex = 30;
            this.txtTotalIncome.Text = "00";
            this.txtTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(362, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "ဝင်ငွေစုစုပေါင်း";
            // 
            // dgvCashbookRecord
            // 
            this.dgvCashbookRecord.AllowUserToAddRows = false;
            this.dgvCashbookRecord.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashbookRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCashbookRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashbookRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.date,
            this.type,
            this.voucher,
            this.remark,
            this.income,
            this.exp,
            this.actions});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashbookRecord.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCashbookRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCashbookRecord.EnableHeadersVisualStyles = false;
            this.dgvCashbookRecord.Location = new System.Drawing.Point(0, 204);
            this.dgvCashbookRecord.Name = "dgvCashbookRecord";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashbookRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCashbookRecord.RowHeadersVisible = false;
            this.dgvCashbookRecord.RowTemplate.Height = 35;
            this.dgvCashbookRecord.Size = new System.Drawing.Size(1245, 333);
            this.dgvCashbookRecord.TabIndex = 5;
            this.dgvCashbookRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashbookRecord_CellContentClick);
            // 
            // no
            // 
            this.no.FillWeight = 50F;
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "အမျိုးအစား";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // voucher
            // 
            this.voucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.voucher.HeaderText = "ဘောင်ချာ";
            this.voucher.Name = "voucher";
            this.voucher.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remark.HeaderText = "အကြောင်းအရာ";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // income
            // 
            this.income.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.income.HeaderText = "ဝင်ငွေ";
            this.income.Name = "income";
            this.income.ReadOnly = true;
            // 
            // exp
            // 
            this.exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exp.HeaderText = "ထွက်ငွေ";
            this.exp.Name = "exp";
            this.exp.ReadOnly = true;
            // 
            // actions
            // 
            this.actions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.actions.DefaultCellStyle = dataGridViewCellStyle6;
            this.actions.HeaderText = "လုပ်ဆောင်ချက်";
            this.actions.Name = "actions";
            this.actions.ReadOnly = true;
            this.actions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVoucher);
            this.groupBox1.Controls.Add(this.txtCasher);
            this.groupBox1.Controls.Add(this.panelType);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ဝင်ငွေ/ထွက်ငွေ အချက်အလက်များ ထည့်ရန်";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 34);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(609, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "ရှာမည်";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 40, 35, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ငွေဝင်/ငွေထွက်စာရင်း များ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "မှ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 5);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "ရက်စွဲ အလိုက်ရှာခြင်း";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(486, 5);
            this.dateTimePicker2.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 21);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(692, 64);
            this.dtpDueDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(186, 30);
            this.dtpDueDate.TabIndex = 31;
            this.dtpDueDate.Value = new System.DateTime(2020, 5, 4, 19, 38, 46, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "စာရင်းထည့်သည့်နေ့";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Olive;
            this.btnClear.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(692, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 41);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "ရှင်းမည်";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(791, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 41);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "သိမ်းမည်";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "အကြောင်းအရာ";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(367, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 54);
            this.txtDescription.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(692, 28);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(186, 30);
            this.txtTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "စုစုပေါင်း ငွေ";
            // 
            // txtVoucher
            // 
            this.txtVoucher.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(367, 64);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(186, 30);
            this.txtVoucher.TabIndex = 7;
            // 
            // txtCasher
            // 
            this.txtCasher.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCasher.Location = new System.Drawing.Point(367, 28);
            this.txtCasher.Name = "txtCasher";
            this.txtCasher.Size = new System.Drawing.Size(186, 30);
            this.txtCasher.TabIndex = 6;
            // 
            // panelType
            // 
            this.panelType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelType.Controls.Add(this.rbtnOther);
            this.panelType.Controls.Add(this.rbtnService);
            this.panelType.Controls.Add(this.rbtnSale);
            this.panelType.Location = new System.Drawing.Point(5, 23);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(151, 93);
            this.panelType.TabIndex = 5;
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Location = new System.Drawing.Point(3, 61);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(145, 27);
            this.rbtnOther.TabIndex = 8;
            this.rbtnOther.Text = "အခြားကိစ္စများအတွက်";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnService
            // 
            this.rbtnService.AutoSize = true;
            this.rbtnService.Checked = true;
            this.rbtnService.Location = new System.Drawing.Point(3, 33);
            this.rbtnService.Name = "rbtnService";
            this.rbtnService.Size = new System.Drawing.Size(136, 27);
            this.rbtnService.TabIndex = 7;
            this.rbtnService.TabStop = true;
            this.rbtnService.Text = "ပြင်ဆင် ခြင်းအတွက်";
            this.rbtnService.UseVisualStyleBackColor = true;
            // 
            // rbtnSale
            // 
            this.rbtnSale.AutoSize = true;
            this.rbtnSale.Location = new System.Drawing.Point(3, 5);
            this.rbtnSale.Name = "rbtnSale";
            this.rbtnSale.Size = new System.Drawing.Size(140, 27);
            this.rbtnSale.TabIndex = 6;
            this.rbtnSale.Text = "‌ရောင်းချ ခြင်းအတွက်";
            this.rbtnSale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtnIncome);
            this.panel2.Controls.Add(this.rbtnExpense);
            this.panel2.Location = new System.Drawing.Point(158, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 93);
            this.panel2.TabIndex = 4;
            // 
            // rbtnIncome
            // 
            this.rbtnIncome.AutoSize = true;
            this.rbtnIncome.Checked = true;
            this.rbtnIncome.Location = new System.Drawing.Point(3, 4);
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.Size = new System.Drawing.Size(60, 27);
            this.rbtnIncome.TabIndex = 0;
            this.rbtnIncome.TabStop = true;
            this.rbtnIncome.Text = "ငွေဝင်";
            this.rbtnIncome.UseVisualStyleBackColor = true;
            // 
            // rbtnExpense
            // 
            this.rbtnExpense.AutoSize = true;
            this.rbtnExpense.Location = new System.Drawing.Point(3, 33);
            this.rbtnExpense.Name = "rbtnExpense";
            this.rbtnExpense.Size = new System.Drawing.Size(72, 27);
            this.rbtnExpense.TabIndex = 1;
            this.rbtnExpense.Text = "ငွေထွက်";
            this.rbtnExpense.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ဘောင်ချာနံပါတ်";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "စာရင်းကိုင်နာမည်";
            // 
            // Cashbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 537);
            this.Controls.Add(this.panelCashbook);
            this.Name = "Cashbook";
            this.Text = "Cashbook";
            this.Load += new System.EventHandler(this.Cashbook_Load);
            this.panelCashbook.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashbookRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCashbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnIncome;
        private System.Windows.Forms.RadioButton rbtnExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.RadioButton rbtnService;
        private System.Windows.Forms.RadioButton rbtnSale;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.TextBox txtCasher;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTotalExpense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCashbookRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
        private System.Windows.Forms.DataGridViewButtonColumn actions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label4;
    }
}