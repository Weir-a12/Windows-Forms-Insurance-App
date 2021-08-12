namespace WeCareInsurance
{
    partial class frmQuote
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
            this.grpQuote = new System.Windows.Forms.GroupBox();
            this.btnAnotherQuote = new System.Windows.Forms.Button();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDriver = new System.Windows.Forms.GroupBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnAddClaim = new System.Windows.Forms.Button();
            this.lblDateOfClaim = new System.Windows.Forms.Label();
            this.dateClaim = new System.Windows.Forms.DateTimePicker();
            this.lblClaims = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.txtDriverSurname = new System.Windows.Forms.TextBox();
            this.lblDriverFn = new System.Windows.Forms.Label();
            this.txtDriverForename = new System.Windows.Forms.TextBox();
            this.lblDriverSn = new System.Windows.Forms.Label();
            this.grpPolicy = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.comboOccupation = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.comboUsage = new System.Windows.Forms.ComboBox();
            this.comboVehicleKept = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.comboVehicle = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblVehicleKept = new System.Windows.Forms.Label();
            this.lblPolicyFn = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblPolicySn = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpQuote.SuspendLayout();
            this.grpDriver.SuspendLayout();
            this.grpPolicy.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQuote
            // 
            this.grpQuote.Controls.Add(this.btnAnotherQuote);
            this.grpQuote.Controls.Add(this.txtQuote);
            this.grpQuote.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuote.Location = new System.Drawing.Point(1065, 103);
            this.grpQuote.Margin = new System.Windows.Forms.Padding(4);
            this.grpQuote.Name = "grpQuote";
            this.grpQuote.Padding = new System.Windows.Forms.Padding(4);
            this.grpQuote.Size = new System.Drawing.Size(385, 212);
            this.grpQuote.TabIndex = 43;
            this.grpQuote.TabStop = false;
            this.grpQuote.Text = "Your Quote";
            // 
            // btnAnotherQuote
            // 
            this.btnAnotherQuote.BackColor = System.Drawing.Color.White;
            this.btnAnotherQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotherQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnotherQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnotherQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotherQuote.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotherQuote.Location = new System.Drawing.Point(74, 123);
            this.btnAnotherQuote.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnotherQuote.Name = "btnAnotherQuote";
            this.btnAnotherQuote.Size = new System.Drawing.Size(248, 70);
            this.btnAnotherQuote.TabIndex = 40;
            this.btnAnotherQuote.Text = "Get Another Quote";
            this.btnAnotherQuote.UseVisualStyleBackColor = false;
            this.btnAnotherQuote.Click += new System.EventHandler(this.btnAnotherQuote_Click);
            // 
            // txtQuote
            // 
            this.txtQuote.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuote.Location = new System.Drawing.Point(8, 57);
            this.txtQuote.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuote.Multiline = true;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.ReadOnly = true;
            this.txtQuote.Size = new System.Drawing.Size(368, 47);
            this.txtQuote.TabIndex = 40;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(23, 13);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 65);
            this.btnReturn.TabIndex = 47;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(277, 774);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(260, 70);
            this.btnConfirm.TabIndex = 44;
            this.btnConfirm.Text = "Confirm Details";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(671, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 63);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDriver
            // 
            this.grpDriver.Controls.Add(this.btnAddDriver);
            this.grpDriver.Controls.Add(this.btnAddClaim);
            this.grpDriver.Controls.Add(this.lblDateOfClaim);
            this.grpDriver.Controls.Add(this.dateClaim);
            this.grpDriver.Controls.Add(this.lblClaims);
            this.grpDriver.Controls.Add(this.lblDOB);
            this.grpDriver.Controls.Add(this.dateDOB);
            this.grpDriver.Controls.Add(this.txtDriverSurname);
            this.grpDriver.Controls.Add(this.lblDriverFn);
            this.grpDriver.Controls.Add(this.txtDriverForename);
            this.grpDriver.Controls.Add(this.lblDriverSn);
            this.grpDriver.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDriver.Location = new System.Drawing.Point(23, 481);
            this.grpDriver.Margin = new System.Windows.Forms.Padding(4);
            this.grpDriver.Name = "grpDriver";
            this.grpDriver.Padding = new System.Windows.Forms.Padding(4);
            this.grpDriver.Size = new System.Drawing.Size(760, 286);
            this.grpDriver.TabIndex = 42;
            this.grpDriver.TabStop = false;
            this.grpDriver.Text = "Driver Details";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.BackColor = System.Drawing.Color.White;
            this.btnAddDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDriver.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.Location = new System.Drawing.Point(264, 225);
            this.btnAddDriver.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(240, 49);
            this.btnAddDriver.TabIndex = 36;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.BackColor = System.Drawing.Color.White;
            this.btnAddClaim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClaim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddClaim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClaim.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClaim.Location = new System.Drawing.Point(476, 178);
            this.btnAddClaim.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(207, 36);
            this.btnAddClaim.TabIndex = 35;
            this.btnAddClaim.Text = "Add Claim";
            this.btnAddClaim.UseVisualStyleBackColor = false;
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // lblDateOfClaim
            // 
            this.lblDateOfClaim.AutoSize = true;
            this.lblDateOfClaim.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfClaim.Location = new System.Drawing.Point(17, 178);
            this.lblDateOfClaim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfClaim.Name = "lblDateOfClaim";
            this.lblDateOfClaim.Size = new System.Drawing.Size(157, 29);
            this.lblDateOfClaim.TabIndex = 34;
            this.lblDateOfClaim.Text = "Date of Claim:";
            // 
            // dateClaim
            // 
            this.dateClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateClaim.Location = new System.Drawing.Point(191, 180);
            this.dateClaim.Margin = new System.Windows.Forms.Padding(4);
            this.dateClaim.MaxDate = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.dateClaim.MinDate = new System.DateTime(2015, 3, 10, 0, 0, 0, 0);
            this.dateClaim.Name = "dateClaim";
            this.dateClaim.Size = new System.Drawing.Size(277, 30);
            this.dateClaim.TabIndex = 29;
            this.dateClaim.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // lblClaims
            // 
            this.lblClaims.AutoSize = true;
            this.lblClaims.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaims.Location = new System.Drawing.Point(16, 142);
            this.lblClaims.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaims.Name = "lblClaims";
            this.lblClaims.Size = new System.Drawing.Size(292, 29);
            this.lblClaims.TabIndex = 33;
            this.lblClaims.Text = "Claims within last 5 years";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(20, 91);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(151, 29);
            this.lblDOB.TabIndex = 29;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dateDOB
            // 
            this.dateDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDOB.Location = new System.Drawing.Point(188, 94);
            this.dateDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dateDOB.MaxDate = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.dateDOB.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(277, 30);
            this.dateDOB.TabIndex = 29;
            this.dateDOB.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // txtDriverSurname
            // 
            this.txtDriverSurname.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverSurname.Location = new System.Drawing.Point(517, 47);
            this.txtDriverSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverSurname.Name = "txtDriverSurname";
            this.txtDriverSurname.Size = new System.Drawing.Size(240, 32);
            this.txtDriverSurname.TabIndex = 32;
            // 
            // lblDriverFn
            // 
            this.lblDriverFn.AutoSize = true;
            this.lblDriverFn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverFn.Location = new System.Drawing.Point(20, 46);
            this.lblDriverFn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverFn.Name = "lblDriverFn";
            this.lblDriverFn.Size = new System.Drawing.Size(120, 29);
            this.lblDriverFn.TabIndex = 29;
            this.lblDriverFn.Text = "Forename:";
            // 
            // txtDriverForename
            // 
            this.txtDriverForename.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverForename.Location = new System.Drawing.Point(145, 47);
            this.txtDriverForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverForename.Name = "txtDriverForename";
            this.txtDriverForename.Size = new System.Drawing.Size(240, 32);
            this.txtDriverForename.TabIndex = 31;
            // 
            // lblDriverSn
            // 
            this.lblDriverSn.AutoSize = true;
            this.lblDriverSn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverSn.Location = new System.Drawing.Point(403, 46);
            this.lblDriverSn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverSn.Name = "lblDriverSn";
            this.lblDriverSn.Size = new System.Drawing.Size(111, 29);
            this.lblDriverSn.TabIndex = 30;
            this.lblDriverSn.Text = "Surname:";
            // 
            // grpPolicy
            // 
            this.grpPolicy.Controls.Add(this.txtOther);
            this.grpPolicy.Controls.Add(this.lblOther);
            this.grpPolicy.Controls.Add(this.comboOccupation);
            this.grpPolicy.Controls.Add(this.txtSurname);
            this.grpPolicy.Controls.Add(this.txtForename);
            this.grpPolicy.Controls.Add(this.comboUsage);
            this.grpPolicy.Controls.Add(this.comboVehicleKept);
            this.grpPolicy.Controls.Add(this.lblStartDate);
            this.grpPolicy.Controls.Add(this.comboVehicle);
            this.grpPolicy.Controls.Add(this.dateStart);
            this.grpPolicy.Controls.Add(this.lblVehicleKept);
            this.grpPolicy.Controls.Add(this.lblPolicyFn);
            this.grpPolicy.Controls.Add(this.lblUsage);
            this.grpPolicy.Controls.Add(this.lblPolicySn);
            this.grpPolicy.Controls.Add(this.lblOccupation);
            this.grpPolicy.Controls.Add(this.lblVehicle);
            this.grpPolicy.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPolicy.Location = new System.Drawing.Point(23, 91);
            this.grpPolicy.Margin = new System.Windows.Forms.Padding(4);
            this.grpPolicy.Name = "grpPolicy";
            this.grpPolicy.Padding = new System.Windows.Forms.Padding(4);
            this.grpPolicy.Size = new System.Drawing.Size(760, 383);
            this.grpPolicy.TabIndex = 41;
            this.grpPolicy.TabStop = false;
            this.grpPolicy.Text = "Policy Details";
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(263, 229);
            this.txtOther.Margin = new System.Windows.Forms.Padding(4);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(488, 30);
            this.txtOther.TabIndex = 30;
            this.txtOther.TextChanged += new System.EventHandler(this.txtOther_TextChanged);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(19, 226);
            this.lblOther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(236, 29);
            this.lblOther.TabIndex = 29;
            this.lblOther.Text = "Other? Please Specify:";
            // 
            // comboOccupation
            // 
            this.comboOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOccupation.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOccupation.FormattingEnabled = true;
            this.comboOccupation.Location = new System.Drawing.Point(152, 134);
            this.comboOccupation.Margin = new System.Windows.Forms.Padding(4);
            this.comboOccupation.Name = "comboOccupation";
            this.comboOccupation.Size = new System.Drawing.Size(600, 37);
            this.comboOccupation.TabIndex = 28;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(509, 90);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(240, 30);
            this.txtSurname.TabIndex = 27;
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(137, 90);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(240, 30);
            this.txtForename.TabIndex = 26;
            // 
            // comboUsage
            // 
            this.comboUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsage.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUsage.FormattingEnabled = true;
            this.comboUsage.Location = new System.Drawing.Point(101, 274);
            this.comboUsage.Margin = new System.Windows.Forms.Padding(4);
            this.comboUsage.Name = "comboUsage";
            this.comboUsage.Size = new System.Drawing.Size(649, 37);
            this.comboUsage.TabIndex = 25;
            // 
            // comboVehicleKept
            // 
            this.comboVehicleKept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicleKept.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVehicleKept.FormattingEnabled = true;
            this.comboVehicleKept.Location = new System.Drawing.Point(160, 326);
            this.comboVehicleKept.Margin = new System.Windows.Forms.Padding(4);
            this.comboVehicleKept.Name = "comboVehicleKept";
            this.comboVehicleKept.Size = new System.Drawing.Size(589, 37);
            this.comboVehicleKept.TabIndex = 24;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(17, 46);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(123, 29);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date:";
            // 
            // comboVehicle
            // 
            this.comboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVehicle.FormattingEnabled = true;
            this.comboVehicle.Location = new System.Drawing.Point(111, 186);
            this.comboVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.comboVehicle.Name = "comboVehicle";
            this.comboVehicle.Size = new System.Drawing.Size(639, 33);
            this.comboVehicle.TabIndex = 23;
            this.comboVehicle.SelectedIndexChanged += new System.EventHandler(this.comboVehicle_SelectedIndexChanged);
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(149, 48);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateStart.MinDate = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(251, 30);
            this.dateStart.TabIndex = 19;
            this.dateStart.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // lblVehicleKept
            // 
            this.lblVehicleKept.AutoSize = true;
            this.lblVehicleKept.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleKept.Location = new System.Drawing.Point(17, 329);
            this.lblVehicleKept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleKept.Name = "lblVehicleKept";
            this.lblVehicleKept.Size = new System.Drawing.Size(145, 29);
            this.lblVehicleKept.TabIndex = 18;
            this.lblVehicleKept.Text = "Vehicle Kept:";
            // 
            // lblPolicyFn
            // 
            this.lblPolicyFn.AutoSize = true;
            this.lblPolicyFn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyFn.Location = new System.Drawing.Point(17, 88);
            this.lblPolicyFn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolicyFn.Name = "lblPolicyFn";
            this.lblPolicyFn.Size = new System.Drawing.Size(120, 29);
            this.lblPolicyFn.TabIndex = 13;
            this.lblPolicyFn.Text = "Forename:";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(17, 277);
            this.lblUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(82, 29);
            this.lblUsage.TabIndex = 17;
            this.lblUsage.Text = "Usage:";
            // 
            // lblPolicySn
            // 
            this.lblPolicySn.AutoSize = true;
            this.lblPolicySn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicySn.Location = new System.Drawing.Point(400, 89);
            this.lblPolicySn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolicySn.Name = "lblPolicySn";
            this.lblPolicySn.Size = new System.Drawing.Size(111, 29);
            this.lblPolicySn.TabIndex = 14;
            this.lblPolicySn.Text = "Surname:";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(16, 135);
            this.lblOccupation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(134, 29);
            this.lblOccupation.TabIndex = 15;
            this.lblOccupation.Text = "Occupation:";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(17, 185);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(93, 29);
            this.lblVehicle.TabIndex = 16;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Sitka Heading", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(187, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(428, 72);
            this.lblHeading.TabIndex = 40;
            this.lblHeading.Text = "WeCare Insurance";
            // 
            // frmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(796, 861);
            this.Controls.Add(this.grpQuote);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDriver);
            this.Controls.Add(this.grpPolicy);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuote";
            this.Text = "Quote";
            this.Load += new System.EventHandler(this.frmQuote_Load);
            this.grpQuote.ResumeLayout(false);
            this.grpQuote.PerformLayout();
            this.grpDriver.ResumeLayout(false);
            this.grpDriver.PerformLayout();
            this.grpPolicy.ResumeLayout(false);
            this.grpPolicy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQuote;
        private System.Windows.Forms.Button btnAnotherQuote;
        private System.Windows.Forms.TextBox txtQuote;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnAddClaim;
        private System.Windows.Forms.Label lblDateOfClaim;
        private System.Windows.Forms.DateTimePicker dateClaim;
        private System.Windows.Forms.Label lblClaims;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.TextBox txtDriverSurname;
        private System.Windows.Forms.Label lblDriverFn;
        private System.Windows.Forms.TextBox txtDriverForename;
        private System.Windows.Forms.Label lblDriverSn;
        private System.Windows.Forms.GroupBox grpPolicy;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.ComboBox comboOccupation;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.ComboBox comboUsage;
        private System.Windows.Forms.ComboBox comboVehicleKept;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox comboVehicle;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblVehicleKept;
        private System.Windows.Forms.Label lblPolicyFn;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblPolicySn;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblHeading;
    }
}