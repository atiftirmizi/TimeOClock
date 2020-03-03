namespace TimeOClock
{
    partial class FormRegisterGroupBox
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.RegistrationTextBox = new System.Windows.Forms.GroupBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.pinLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employerLabel = new System.Windows.Forms.Label();
            this.employerTextBox = new System.Windows.Forms.TextBox();
            this.registerFormButton = new System.Windows.Forms.Button();
            this.passwordRecoveryGroupBox = new System.Windows.Forms.GroupBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.cellPhoneextBox = new System.Windows.Forms.MaskedTextBox();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.managerNameTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.temsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.termsCheckBox = new System.Windows.Forms.CheckBox();
            this.managerLastNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.RegistrationTextBox.SuspendLayout();
            this.passwordRecoveryGroupBox.SuspendLayout();
            this.ManagerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 54);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Employee";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(26, 17);
            this.adminRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(54, 17);
            this.adminRadioButton.TabIndex = 1;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RegistrationTextBox
            // 
            this.RegistrationTextBox.Controls.Add(this.pinTextBox);
            this.RegistrationTextBox.Controls.Add(this.pinLabel);
            this.RegistrationTextBox.Controls.Add(this.passwordTextBox);
            this.RegistrationTextBox.Controls.Add(this.passwordLabel);
            this.RegistrationTextBox.Controls.Add(this.emailTextBox);
            this.RegistrationTextBox.Controls.Add(this.label1);
            this.RegistrationTextBox.Controls.Add(this.employerLabel);
            this.RegistrationTextBox.Controls.Add(this.employerTextBox);
            this.RegistrationTextBox.Location = new System.Drawing.Point(26, 94);
            this.RegistrationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationTextBox.Name = "RegistrationTextBox";
            this.RegistrationTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.RegistrationTextBox.Size = new System.Drawing.Size(267, 177);
            this.RegistrationTextBox.TabIndex = 2;
            this.RegistrationTextBox.TabStop = false;
            this.RegistrationTextBox.Text = "Register";
            this.RegistrationTextBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(97, 136);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pinTextBox.MaxLength = 5;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(147, 20);
            this.pinTextBox.TabIndex = 7;
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(4, 138);
            this.pinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(64, 13);
            this.pinLabel.TabIndex = 6;
            this.pinLabel.Text = "Pin (5 digits)";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 96);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(147, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(4, 97);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(97, 62);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(147, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // employerLabel
            // 
            this.employerLabel.AutoSize = true;
            this.employerLabel.Location = new System.Drawing.Point(4, 26);
            this.employerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employerLabel.Name = "employerLabel";
            this.employerLabel.Size = new System.Drawing.Size(81, 13);
            this.employerLabel.TabIndex = 1;
            this.employerLabel.Text = "Employer Name";
            // 
            // employerTextBox
            // 
            this.employerTextBox.Location = new System.Drawing.Point(97, 24);
            this.employerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.employerTextBox.Name = "employerTextBox";
            this.employerTextBox.Size = new System.Drawing.Size(147, 20);
            this.employerTextBox.TabIndex = 0;
            // 
            // registerFormButton
            // 
            this.registerFormButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registerFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerFormButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerFormButton.Location = new System.Drawing.Point(226, 395);
            this.registerFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerFormButton.Name = "registerFormButton";
            this.registerFormButton.Size = new System.Drawing.Size(121, 33);
            this.registerFormButton.TabIndex = 6;
            this.registerFormButton.Text = "Submit";
            this.registerFormButton.UseVisualStyleBackColor = false;
            this.registerFormButton.Click += new System.EventHandler(this.registerFormButton_Click);
            // 
            // passwordRecoveryGroupBox
            // 
            this.passwordRecoveryGroupBox.Controls.Add(this.dobLabel);
            this.passwordRecoveryGroupBox.Controls.Add(this.dateTimePicker1);
            this.passwordRecoveryGroupBox.Controls.Add(this.cellphoneLabel);
            this.passwordRecoveryGroupBox.Controls.Add(this.cellPhoneextBox);
            this.passwordRecoveryGroupBox.Location = new System.Drawing.Point(326, 101);
            this.passwordRecoveryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRecoveryGroupBox.Name = "passwordRecoveryGroupBox";
            this.passwordRecoveryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.passwordRecoveryGroupBox.Size = new System.Drawing.Size(212, 123);
            this.passwordRecoveryGroupBox.TabIndex = 7;
            this.passwordRecoveryGroupBox.TabStop = false;
            this.passwordRecoveryGroupBox.Text = "Password Recovery";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(4, 73);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(66, 13);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(1, 24);
            this.cellphoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(58, 13);
            this.cellphoneLabel.TabIndex = 1;
            this.cellphoneLabel.Text = "Cell Phone";
            this.cellphoneLabel.Click += new System.EventHandler(this.cellphoneLabel_Click);
            // 
            // cellPhoneextBox
            // 
            this.cellPhoneextBox.Location = new System.Drawing.Point(4, 39);
            this.cellPhoneextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cellPhoneextBox.Name = "cellPhoneextBox";
            this.cellPhoneextBox.Size = new System.Drawing.Size(79, 20);
            this.cellPhoneextBox.TabIndex = 0;
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.AutoSize = true;
            this.managerNameLabel.Location = new System.Drawing.Point(5, 20);
            this.managerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(112, 13);
            this.managerNameLabel.TabIndex = 8;
            this.managerNameLabel.Text = "Manager\'s First Name:";
            this.managerNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // managerNameTextBox
            // 
            this.managerNameTextBox.Location = new System.Drawing.Point(5, 35);
            this.managerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.managerNameTextBox.Name = "managerNameTextBox";
            this.managerNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.managerNameTextBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(3, 411);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(77, 26);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // temsLinkLabel
            // 
            this.temsLinkLabel.AutoSize = true;
            this.temsLinkLabel.Location = new System.Drawing.Point(210, 377);
            this.temsLinkLabel.Name = "temsLinkLabel";
            this.temsLinkLabel.Size = new System.Drawing.Size(157, 13);
            this.temsLinkLabel.TabIndex = 11;
            this.temsLinkLabel.TabStop = true;
            this.temsLinkLabel.Text = "I agree to Terms and Conditions";
            this.temsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.temsLinkLabel_LinkClicked);
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.AutoSize = true;
            this.termsCheckBox.Location = new System.Drawing.Point(198, 376);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.termsCheckBox.TabIndex = 12;
            this.termsCheckBox.UseVisualStyleBackColor = true;
            // 
            // managerLastNameLabel
            // 
            this.managerLastNameLabel.AutoSize = true;
            this.managerLastNameLabel.Location = new System.Drawing.Point(2, 70);
            this.managerLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managerLastNameLabel.Name = "managerLastNameLabel";
            this.managerLastNameLabel.Size = new System.Drawing.Size(113, 13);
            this.managerLastNameLabel.TabIndex = 13;
            this.managerLastNameLabel.Text = "Manager\'s Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 14;
            // 
            // ManagerGroupBox
            // 
            this.ManagerGroupBox.Controls.Add(this.managerNameTextBox);
            this.ManagerGroupBox.Controls.Add(this.textBox1);
            this.ManagerGroupBox.Controls.Add(this.managerNameLabel);
            this.ManagerGroupBox.Controls.Add(this.managerLastNameLabel);
            this.ManagerGroupBox.Location = new System.Drawing.Point(326, 230);
            this.ManagerGroupBox.Name = "ManagerGroupBox";
            this.ManagerGroupBox.Size = new System.Drawing.Size(212, 117);
            this.ManagerGroupBox.TabIndex = 15;
            this.ManagerGroupBox.TabStop = false;
            this.ManagerGroupBox.Text = "Manager Info";
            // 
            // FormRegisterGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 439);
            this.Controls.Add(this.ManagerGroupBox);
            this.Controls.Add(this.termsCheckBox);
            this.Controls.Add(this.temsLinkLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.passwordRecoveryGroupBox);
            this.Controls.Add(this.registerFormButton);
            this.Controls.Add(this.RegistrationTextBox);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegisterGroupBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.RegistrationTextBox.ResumeLayout(false);
            this.RegistrationTextBox.PerformLayout();
            this.passwordRecoveryGroupBox.ResumeLayout(false);
            this.passwordRecoveryGroupBox.PerformLayout();
            this.ManagerGroupBox.ResumeLayout(false);
            this.ManagerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.GroupBox RegistrationTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employerLabel;
        private System.Windows.Forms.TextBox employerTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerFormButton;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.GroupBox passwordRecoveryGroupBox;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.MaskedTextBox cellPhoneextBox;
        private System.Windows.Forms.Label managerNameLabel;
        private System.Windows.Forms.TextBox managerNameTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.LinkLabel temsLinkLabel;
        private System.Windows.Forms.CheckBox termsCheckBox;
        private System.Windows.Forms.Label managerLastNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox ManagerGroupBox;
    }
}