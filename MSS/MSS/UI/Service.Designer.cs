namespace MSS.UI
{
    partial class Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelService = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtServiceTotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelServiceForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbPreAmount = new System.Windows.Forms.RadioButton();
            this.rdbNotClear = new System.Windows.Forms.RadioButton();
            this.rdbClear = new System.Windows.Forms.RadioButton();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.lbRecPay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCasher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSaleLayoutTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelService.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelServiceForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSaleLayoutTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.panel5);
            this.panelService.Controls.Add(this.dgvService);
            this.panelService.Controls.Add(this.panel4);
            this.panelService.Controls.Add(this.panelServiceForm);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelService.Location = new System.Drawing.Point(0, 0);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(1082, 603);
            this.panelService.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtServiceTotal);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(337, 563);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(745, 40);
            this.panel5.TabIndex = 4;
            // 
            // txtServiceTotal
            // 
            this.txtServiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceTotal.Location = new System.Drawing.Point(347, 3);
            this.txtServiceTotal.Name = "txtServiceTotal";
            this.txtServiceTotal.Size = new System.Drawing.Size(200, 26);
            this.txtServiceTotal.TabIndex = 32;
            this.txtServiceTotal.Text = "0";
            this.txtServiceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(183, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(158, 23);
            this.label21.TabIndex = 31;
            this.label21.Text = "စုစုပေါင်း ဝန်ဆောင်မှုမှရငွေ :";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.id,
            this.return_date,
            this.customer,
            this.item,
            this.imei,
            this.remark,
            this.total,
            this.status,
            this.actions});
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(337, 44);
            this.dgvService.Name = "dgvService";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.Size = new System.Drawing.Size(745, 559);
            this.dgvService.TabIndex = 3;
            this.dgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellContentClick);
            this.dgvService.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellMouseEnter);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 40;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // return_date
            // 
            this.return_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.return_date.HeaderText = "Return Date";
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            this.return_date.Width = 104;
            // 
            // customer
            // 
            this.customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Visible = false;
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // imei
            // 
            this.imei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imei.HeaderText = "IMEI";
            this.imei.Name = "imei";
            this.imei.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remark.HeaderText = "Remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // actions
            // 
            this.actions.HeaderText = "Actions";
            this.actions.Name = "actions";
            this.actions.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(337, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 44);
            this.panel4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(478, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "ရှာမည်";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(327, 11);
            this.dateTimePicker2.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 24);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 11);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 24);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(307, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 21);
            this.label20.TabIndex = 1;
            this.label20.Text = "မှ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "ရက်စွဲ အလိုက် စစ်ဆေးကြည့်ရန်  :";
            // 
            // panelServiceForm
            // 
            this.panelServiceForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelServiceForm.Controls.Add(this.panel2);
            this.panelServiceForm.Controls.Add(this.panel1);
            this.panelServiceForm.Controls.Add(this.panelSaleLayoutTop);
            this.panelServiceForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelServiceForm.Location = new System.Drawing.Point(0, 0);
            this.panelServiceForm.Name = "panelServiceForm";
            this.panelServiceForm.Size = new System.Drawing.Size(337, 603);
            this.panelServiceForm.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.dtpReturn);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtRemark);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtIMEI);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPhoneModel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnNewCategory);
            this.panel2.Controls.Add(this.btnNewCustomer);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.cmbCustomer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 501);
            this.panel2.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(105, 259);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 16);
            this.label23.TabIndex = 32;
            this.label23.Text = "*";
            // 
            // dtpReturn
            // 
            this.dtpReturn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturn.CustomFormat = "dd-mm-yyyy";
            this.dtpReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(121, 253);
            this.dtpReturn.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpReturn.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 24);
            this.dtpReturn.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 23);
            this.label18.TabIndex = 27;
            this.label18.Text = "ပေးရယူမည့်ရက်";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(105, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "*";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(122, 198);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 49);
            this.txtDescription.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Description :";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(122, 143);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(202, 49);
            this.txtRemark.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(50, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 23);
            this.label22.TabIndex = 22;
            this.label22.Text = "Remark :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(120, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 37);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(228, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rdbPreAmount);
            this.panel3.Controls.Add(this.rdbNotClear);
            this.panel3.Controls.Add(this.rdbClear);
            this.panel3.Controls.Add(this.txtRemain);
            this.panel3.Controls.Add(this.lbRecPay);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtPayment);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(2, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 161);
            this.panel3.TabIndex = 20;
            // 
            // rdbPreAmount
            // 
            this.rdbPreAmount.AutoSize = true;
            this.rdbPreAmount.Checked = true;
            this.rdbPreAmount.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPreAmount.Location = new System.Drawing.Point(40, 126);
            this.rdbPreAmount.Name = "rdbPreAmount";
            this.rdbPreAmount.Size = new System.Drawing.Size(67, 27);
            this.rdbPreAmount.TabIndex = 31;
            this.rdbPreAmount.TabStop = true;
            this.rdbPreAmount.Text = "စရန်ငွေ";
            this.rdbPreAmount.UseVisualStyleBackColor = true;
            this.rdbPreAmount.CheckedChanged += new System.EventHandler(this.rdbPreAmount_CheckedChanged);
            // 
            // rdbNotClear
            // 
            this.rdbNotClear.AutoSize = true;
            this.rdbNotClear.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotClear.Location = new System.Drawing.Point(203, 126);
            this.rdbNotClear.Name = "rdbNotClear";
            this.rdbNotClear.Size = new System.Drawing.Size(115, 27);
            this.rdbNotClear.TabIndex = 30;
            this.rdbNotClear.Text = "မရှင်းလင်းရသေး";
            this.rdbNotClear.UseVisualStyleBackColor = true;
            this.rdbNotClear.CheckedChanged += new System.EventHandler(this.rdbNotClear_CheckedChanged);
            // 
            // rdbClear
            // 
            this.rdbClear.AutoSize = true;
            this.rdbClear.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClear.Location = new System.Drawing.Point(115, 126);
            this.rdbClear.Name = "rdbClear";
            this.rdbClear.Size = new System.Drawing.Size(89, 27);
            this.rdbClear.TabIndex = 28;
            this.rdbClear.Text = "ရှင်းလင်းပြီး";
            this.rdbClear.UseVisualStyleBackColor = true;
            this.rdbClear.CheckedChanged += new System.EventHandler(this.rdbClear_CheckedChanged);
            // 
            // txtRemain
            // 
            this.txtRemain.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemain.Location = new System.Drawing.Point(119, 88);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.ReadOnly = true;
            this.txtRemain.Size = new System.Drawing.Size(200, 32);
            this.txtRemain.TabIndex = 27;
            this.txtRemain.Text = "0";
            this.txtRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRecPay
            // 
            this.lbRecPay.AutoSize = true;
            this.lbRecPay.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecPay.Location = new System.Drawing.Point(-4, 91);
            this.lbRecPay.Name = "lbRecPay";
            this.lbRecPay.Size = new System.Drawing.Size(123, 23);
            this.lbRecPay.TabIndex = 26;
            this.lbRecPay.Text = "ရရန်/ပေးရန် ကျန်ငွေ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(102, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "*";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(119, 50);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(200, 32);
            this.txtPayment.TabIndex = 25;
            this.txtPayment.Text = "0";
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 23);
            this.label16.TabIndex = 24;
            this.label16.Text = "ယခုပေး ချေငွေ :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(102, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "*";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(119, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 32);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "စုစုပေါင်းကျငွေ :";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMEI.Location = new System.Drawing.Point(122, 115);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(202, 24);
            this.txtIMEI.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "IMEI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(110, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(110, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // txtPhoneModel
            // 
            this.txtPhoneModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneModel.Location = new System.Drawing.Point(123, 84);
            this.txtPhoneModel.Name = "txtPhoneModel";
            this.txtPhoneModel.Size = new System.Drawing.Size(202, 24);
            this.txtPhoneModel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Model :";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCategory.Location = new System.Drawing.Point(267, 47);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(60, 28);
            this.btnNewCategory.TabIndex = 8;
            this.btnNewCategory.Text = "New";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(267, 9);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(60, 28);
            this.btnNewCustomer.TabIndex = 5;
            this.btnNewCustomer.Text = "New";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(125, 46);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(136, 29);
            this.cmbCategory.TabIndex = 7;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(125, 9);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(136, 29);
            this.cmbCustomer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCasher);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 59);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(111, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(18, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "အနီရောင်(*)များသည် မဖြစ်မနေထည့်သွင်းရမည့်အချက်အလက်များဖြစ်သည်။";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCasher
            // 
            this.cmbCasher.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCasher.FormattingEnabled = true;
            this.cmbCasher.Location = new System.Drawing.Point(129, 23);
            this.cmbCasher.Name = "cmbCasher";
            this.cmbCasher.Size = new System.Drawing.Size(196, 29);
            this.cmbCasher.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Casher :";
            // 
            // panelSaleLayoutTop
            // 
            this.panelSaleLayoutTop.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSaleLayoutTop.Controls.Add(this.label1);
            this.panelSaleLayoutTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaleLayoutTop.Location = new System.Drawing.Point(0, 0);
            this.panelSaleLayoutTop.Name = "panelSaleLayoutTop";
            this.panelSaleLayoutTop.Size = new System.Drawing.Size(333, 39);
            this.panelSaleLayoutTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ဝန်ဆောင်မှုအတွက် ဖြည့်စွက်ပုံစံ";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.panelService);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panelService.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelServiceForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSaleLayoutTop.ResumeLayout(false);
            this.panelSaleLayoutTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Panel panelServiceForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbNotClear;
        private System.Windows.Forms.RadioButton rdbClear;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Label lbRecPay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCasher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSaleLayoutTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtServiceTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbPreAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn actions;
    }
}