namespace WeCareInsurance
{
    partial class frmMenu
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
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPolicyFn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Sitka Heading", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(141, 2);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(469, 66);
            this.lblHeading.TabIndex = 15;
            this.lblHeading.Text = "WeCare Insurance";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.BackColor = System.Drawing.Color.White;
            this.btnGetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetQuote.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(215, 79);
            this.btnGetQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(248, 86);
            this.btnGetQuote.TabIndex = 21;
            this.btnGetQuote.Text = "Get a Quote";
            this.btnGetQuote.UseVisualStyleBackColor = false;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(215, 183);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(248, 86);
            this.btnAdmin.TabIndex = 19;
            this.btnAdmin.Text = "View Quotes";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(11, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 54);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(471, 225);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(203, 30);
            this.txtPassword.TabIndex = 47;
            // 
            // lblPolicyFn
            // 
            this.lblPolicyFn.AutoSize = true;
            this.lblPolicyFn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyFn.Location = new System.Drawing.Point(471, 198);
            this.lblPolicyFn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolicyFn.Name = "lblPolicyFn";
            this.lblPolicyFn.Size = new System.Drawing.Size(206, 29);
            this.lblPolicyFn.TabIndex = 48;
            this.lblPolicyFn.Text = "Password: (admin)";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(687, 295);
            this.Controls.Add(this.lblPolicyFn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPolicyFn;
    }
}

