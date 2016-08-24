namespace Jie_Huang___Membership_Fee_Calculator
{
    partial class frmMFC
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkPersonalTrainer = new System.Windows.Forms.CheckBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumberOfMonths = new System.Windows.Forms.Label();
            this.gbxTypeMembership = new System.Windows.Forms.GroupBox();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.gbxMembershipLength = new System.Windows.Forms.GroupBox();
            this.gbxMembershipFees = new System.Windows.Forms.GroupBox();
            this.lblTotalBox = new System.Windows.Forms.Label();
            this.lblMFeeBox = new System.Windows.Forms.Label();
            this.gbxTypeMembership.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.gbxMembershipLength.SuspendLayout();
            this.gbxMembershipFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(85, 341);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(445, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(13, 21);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(51, 17);
            this.chkYoga.TabIndex = 3;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            this.chkYoga.CheckedChanged += new System.EventHandler(this.chkYoga_CheckedChanged);
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(13, 55);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(57, 17);
            this.chkKarate.TabIndex = 4;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            this.chkKarate.CheckedChanged += new System.EventHandler(this.chkKarate_CheckedChanged);
            // 
            // chkPersonalTrainer
            // 
            this.chkPersonalTrainer.AutoSize = true;
            this.chkPersonalTrainer.Location = new System.Drawing.Point(13, 90);
            this.chkPersonalTrainer.Name = "chkPersonalTrainer";
            this.chkPersonalTrainer.Size = new System.Drawing.Size(103, 17);
            this.chkPersonalTrainer.TabIndex = 5;
            this.chkPersonalTrainer.Text = "Personal Trainer";
            this.chkPersonalTrainer.UseVisualStyleBackColor = true;
            this.chkPersonalTrainer.CheckedChanged += new System.EventHandler(this.chkPersonalTrainer_CheckedChanged);
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(11, 66);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 20);
            this.txtMonths.TabIndex = 6;
            this.txtMonths.TextChanged += new System.EventHandler(this.txtMonths_TextChanged);
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(11, 21);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(95, 17);
            this.radAdult.TabIndex = 7;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            this.radAdult.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(11, 44);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(119, 17);
            this.radChild.TabIndex = 8;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child(12 and Under)";
            this.radChild.UseVisualStyleBackColor = true;
            this.radChild.CheckedChanged += new System.EventHandler(this.radChild_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(11, 67);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(62, 17);
            this.radStudent.TabIndex = 9;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(11, 90);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(89, 17);
            this.radSenior.TabIndex = 10;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            this.radSenior.CheckedChanged += new System.EventHandler(this.radSenior_CheckedChanged);
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Location = new System.Drawing.Point(8, 31);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(71, 13);
            this.lblMonthlyFee.TabIndex = 13;
            this.lblMonthlyFee.Text = "Monthly Fee: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(37, 69);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // lblNumberOfMonths
            // 
            this.lblNumberOfMonths.AutoSize = true;
            this.lblNumberOfMonths.Location = new System.Drawing.Point(6, 31);
            this.lblNumberOfMonths.Name = "lblNumberOfMonths";
            this.lblNumberOfMonths.Size = new System.Drawing.Size(146, 13);
            this.lblNumberOfMonths.TabIndex = 15;
            this.lblNumberOfMonths.Text = "Enter the Number of Months: ";
            // 
            // gbxTypeMembership
            // 
            this.gbxTypeMembership.Controls.Add(this.radSenior);
            this.gbxTypeMembership.Controls.Add(this.radAdult);
            this.gbxTypeMembership.Controls.Add(this.radChild);
            this.gbxTypeMembership.Controls.Add(this.radStudent);
            this.gbxTypeMembership.Location = new System.Drawing.Point(66, 42);
            this.gbxTypeMembership.Name = "gbxTypeMembership";
            this.gbxTypeMembership.Size = new System.Drawing.Size(184, 116);
            this.gbxTypeMembership.TabIndex = 16;
            this.gbxTypeMembership.TabStop = false;
            this.gbxTypeMembership.Text = "Type of Membership";
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.chkYoga);
            this.gbxOptions.Controls.Add(this.chkPersonalTrainer);
            this.gbxOptions.Controls.Add(this.chkKarate);
            this.gbxOptions.Location = new System.Drawing.Point(348, 42);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(132, 116);
            this.gbxOptions.TabIndex = 17;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Options";
            // 
            // gbxMembershipLength
            // 
            this.gbxMembershipLength.Controls.Add(this.lblNumberOfMonths);
            this.gbxMembershipLength.Controls.Add(this.txtMonths);
            this.gbxMembershipLength.Location = new System.Drawing.Point(66, 194);
            this.gbxMembershipLength.Name = "gbxMembershipLength";
            this.gbxMembershipLength.Size = new System.Drawing.Size(184, 114);
            this.gbxMembershipLength.TabIndex = 18;
            this.gbxMembershipLength.TabStop = false;
            this.gbxMembershipLength.Text = "Membership Length";
            // 
            // gbxMembershipFees
            // 
            this.gbxMembershipFees.Controls.Add(this.lblTotalBox);
            this.gbxMembershipFees.Controls.Add(this.lblMFeeBox);
            this.gbxMembershipFees.Controls.Add(this.lblMonthlyFee);
            this.gbxMembershipFees.Controls.Add(this.lblTotal);
            this.gbxMembershipFees.Location = new System.Drawing.Point(317, 194);
            this.gbxMembershipFees.Name = "gbxMembershipFees";
            this.gbxMembershipFees.Size = new System.Drawing.Size(183, 114);
            this.gbxMembershipFees.TabIndex = 19;
            this.gbxMembershipFees.TabStop = false;
            this.gbxMembershipFees.Text = "Membership Fees";
            this.gbxMembershipFees.Enter += new System.EventHandler(this.gbxMembershipFees_Enter);
            // 
            // lblTotalBox
            // 
            this.lblTotalBox.AutoSize = true;
            this.lblTotalBox.Location = new System.Drawing.Point(111, 73);
            this.lblTotalBox.Name = "lblTotalBox";
            this.lblTotalBox.Size = new System.Drawing.Size(0, 13);
            this.lblTotalBox.TabIndex = 16;
            this.lblTotalBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMFeeBox
            // 
            this.lblMFeeBox.AutoSize = true;
            this.lblMFeeBox.Location = new System.Drawing.Point(111, 32);
            this.lblMFeeBox.Name = "lblMFeeBox";
            this.lblMFeeBox.Size = new System.Drawing.Size(0, 13);
            this.lblMFeeBox.TabIndex = 15;
            this.lblMFeeBox.Click += new System.EventHandler(this.lblMFeeBox_Click);
            // 
            // frmMFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 402);
            this.Controls.Add(this.gbxMembershipFees);
            this.Controls.Add(this.gbxMembershipLength);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.gbxTypeMembership);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmMFC";
            this.Text = "Membership Fee Calculator";
            this.Load += new System.EventHandler(this.frmMFC_Load);
            this.gbxTypeMembership.ResumeLayout(false);
            this.gbxTypeMembership.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.gbxMembershipLength.ResumeLayout(false);
            this.gbxMembershipLength.PerformLayout();
            this.gbxMembershipFees.ResumeLayout(false);
            this.gbxMembershipFees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkPersonalTrainer;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumberOfMonths;
        private System.Windows.Forms.GroupBox gbxTypeMembership;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.GroupBox gbxMembershipLength;
        private System.Windows.Forms.GroupBox gbxMembershipFees;
        private System.Windows.Forms.Label lblMFeeBox;
        private System.Windows.Forms.Label lblTotalBox;
    }
}

