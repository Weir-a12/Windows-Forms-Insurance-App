namespace WeCareInsurance
{
    partial class frmAdmin
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtPolicyDetails = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilterPolicyID = new System.Windows.Forms.Button();
            this.btnFilterSurname = new System.Windows.Forms.Button();
            this.btnFilterUsage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPolicyID = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnFilterStatus = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPolicyDate = new System.Windows.Forms.Button();
            this.datePolicies = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Sitka Heading", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(132, -3);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(428, 72);
            this.lblHeading.TabIndex = 26;
            this.lblHeading.Text = "WeCare Insurance";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.White;
            this.btnDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(11, 145);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(155, 54);
            this.btnDisplay.TabIndex = 25;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtPolicyDetails
            // 
            this.txtPolicyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolicyDetails.Location = new System.Drawing.Point(175, 73);
            this.txtPolicyDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolicyDetails.Multiline = true;
            this.txtPolicyDetails.Name = "txtPolicyDetails";
            this.txtPolicyDetails.ReadOnly = true;
            this.txtPolicyDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolicyDetails.Size = new System.Drawing.Size(320, 376);
            this.txtPolicyDetails.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(587, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 52);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilterPolicyID
            // 
            this.btnFilterPolicyID.BackColor = System.Drawing.Color.White;
            this.btnFilterPolicyID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterPolicyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPolicyID.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterPolicyID.Location = new System.Drawing.Point(506, 111);
            this.btnFilterPolicyID.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterPolicyID.Name = "btnFilterPolicyID";
            this.btnFilterPolicyID.Size = new System.Drawing.Size(181, 49);
            this.btnFilterPolicyID.TabIndex = 48;
            this.btnFilterPolicyID.Text = "Filter by PolicyID";
            this.btnFilterPolicyID.UseVisualStyleBackColor = false;
            this.btnFilterPolicyID.Click += new System.EventHandler(this.btnFilterPolicyID_Click);
            // 
            // btnFilterSurname
            // 
            this.btnFilterSurname.BackColor = System.Drawing.Color.White;
            this.btnFilterSurname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSurname.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSurname.Location = new System.Drawing.Point(506, 203);
            this.btnFilterSurname.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterSurname.Name = "btnFilterSurname";
            this.btnFilterSurname.Size = new System.Drawing.Size(181, 49);
            this.btnFilterSurname.TabIndex = 49;
            this.btnFilterSurname.Text = "Filter by Surname";
            this.btnFilterSurname.UseVisualStyleBackColor = false;
            this.btnFilterSurname.Click += new System.EventHandler(this.btnFilterSurname_Click);
            // 
            // btnFilterUsage
            // 
            this.btnFilterUsage.BackColor = System.Drawing.Color.White;
            this.btnFilterUsage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterUsage.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterUsage.Location = new System.Drawing.Point(504, 303);
            this.btnFilterUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterUsage.Name = "btnFilterUsage";
            this.btnFilterUsage.Size = new System.Drawing.Size(181, 42);
            this.btnFilterUsage.TabIndex = 50;
            this.btnFilterUsage.Text = "Filter by Usage";
            this.btnFilterUsage.UseVisualStyleBackColor = false;
            this.btnFilterUsage.Click += new System.EventHandler(this.btnFilterUsage_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(11, 85);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 52);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save Policies";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPolicyID
            // 
            this.txtPolicyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolicyID.Location = new System.Drawing.Point(506, 85);
            this.txtPolicyID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolicyID.Name = "txtPolicyID";
            this.txtPolicyID.Size = new System.Drawing.Size(180, 23);
            this.txtPolicyID.TabIndex = 52;
            this.txtPolicyID.TextChanged += new System.EventHandler(this.txtPolicyID_TextChanged);
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(504, 276);
            this.txtUsage.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(180, 23);
            this.txtUsage.TabIndex = 53;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(506, 177);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(180, 23);
            this.txtSurname.TabIndex = 54;
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.BackColor = System.Drawing.Color.White;
            this.btnFilterStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterStatus.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterStatus.Location = new System.Drawing.Point(506, 394);
            this.btnFilterStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(181, 46);
            this.btnFilterStatus.TabIndex = 55;
            this.btnFilterStatus.Text = "Filter by Status";
            this.btnFilterStatus.UseVisualStyleBackColor = false;
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(506, 367);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(180, 23);
            this.txtStatus.TabIndex = 56;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 16);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 53);
            this.btnReturn.TabIndex = 57;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPolicyDate
            // 
            this.btnPolicyDate.BackColor = System.Drawing.Color.White;
            this.btnPolicyDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPolicyDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolicyDate.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyDate.Location = new System.Drawing.Point(12, 291);
            this.btnPolicyDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPolicyDate.Name = "btnPolicyDate";
            this.btnPolicyDate.Size = new System.Drawing.Size(154, 79);
            this.btnPolicyDate.TabIndex = 59;
            this.btnPolicyDate.Text = "Show Policies for Selected Date";
            this.btnPolicyDate.UseVisualStyleBackColor = false;
            this.btnPolicyDate.Click += new System.EventHandler(this.btnPolicyDate_Click);
            // 
            // datePolicies
            // 
            this.datePolicies.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePolicies.Location = new System.Drawing.Point(12, 263);
            this.datePolicies.Margin = new System.Windows.Forms.Padding(4);
            this.datePolicies.MaxDate = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.datePolicies.Name = "datePolicies";
            this.datePolicies.Size = new System.Drawing.Size(154, 22);
            this.datePolicies.TabIndex = 58;
            this.datePolicies.Value = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 390);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 50);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(702, 464);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPolicyDate);
            this.Controls.Add(this.datePolicies);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnFilterStatus);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.txtPolicyID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFilterUsage);
            this.Controls.Add(this.btnFilterSurname);
            this.Controls.Add(this.btnFilterPolicyID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtPolicyDetails);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtPolicyDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFilterPolicyID;
        private System.Windows.Forms.Button btnFilterSurname;
        private System.Windows.Forms.Button btnFilterUsage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPolicyID;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnFilterStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPolicyDate;
        private System.Windows.Forms.DateTimePicker datePolicies;
        private System.Windows.Forms.Button btnClear;
    }
}