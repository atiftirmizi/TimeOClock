namespace TimeOClock
{
    partial class FormDomain
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
            this.clockInButton = new System.Windows.Forms.Button();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ptoDetails = new System.Windows.Forms.LinkLabel();
            this.requestPTOLable = new System.Windows.Forms.Label();
            this.ptoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeMonthTextBox = new System.Windows.Forms.TextBox();
            this.timeMonthLabel = new System.Windows.Forms.Label();
            this.timeDayLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.concernLabel = new System.Windows.Forms.Label();
            this.concernsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.payGroupBox = new System.Windows.Forms.GroupBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.Time.SuspendLayout();
            this.timeGroupBox.SuspendLayout();
            this.currentTimeGroupBox.SuspendLayout();
            this.payGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockInButton
            // 
            this.clockInButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInButton.Location = new System.Drawing.Point(15, 17);
            this.clockInButton.Margin = new System.Windows.Forms.Padding(2);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(125, 60);
            this.clockInButton.TabIndex = 0;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = false;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // clockOutButton
            // 
            this.clockOutButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clockOutButton.Enabled = false;
            this.clockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutButton.Location = new System.Drawing.Point(15, 90);
            this.clockOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(125, 60);
            this.clockOutButton.TabIndex = 1;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.UseVisualStyleBackColor = false;
            this.clockOutButton.Click += new System.EventHandler(this.clockOutButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 70);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Time
            // 
            this.Time.Controls.Add(this.label2);
            this.Time.Controls.Add(this.dateTimePicker2);
            this.Time.Controls.Add(this.ptoDetails);
            this.Time.Controls.Add(this.requestPTOLable);
            this.Time.Controls.Add(this.dateTimePicker1);
            this.Time.Location = new System.Drawing.Point(8, 168);
            this.Time.Margin = new System.Windows.Forms.Padding(2);
            this.Time.Name = "Time";
            this.Time.Padding = new System.Windows.Forms.Padding(2);
            this.Time.Size = new System.Drawing.Size(217, 151);
            this.Time.TabIndex = 3;
            this.Time.TabStop = false;
            this.Time.Text = "Vacation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(4, 127);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // ptoDetails
            // 
            this.ptoDetails.AutoSize = true;
            this.ptoDetails.Location = new System.Drawing.Point(4, 24);
            this.ptoDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ptoDetails.Name = "ptoDetails";
            this.ptoDetails.Size = new System.Drawing.Size(65, 13);
            this.ptoDetails.TabIndex = 5;
            this.ptoDetails.TabStop = true;
            this.ptoDetails.Text = "View Details";
            this.ptoDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ptoDetails_LinkClicked);
            // 
            // requestPTOLable
            // 
            this.requestPTOLable.AutoSize = true;
            this.requestPTOLable.Location = new System.Drawing.Point(4, 54);
            this.requestPTOLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requestPTOLable.Name = "requestPTOLable";
            this.requestPTOLable.Size = new System.Drawing.Size(104, 13);
            this.requestPTOLable.TabIndex = 4;
            this.requestPTOLable.Text = "Request PTO (From)";
            this.requestPTOLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // ptoButton
            // 
            this.ptoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ptoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ptoButton.Location = new System.Drawing.Point(12, 322);
            this.ptoButton.Margin = new System.Windows.Forms.Padding(2);
            this.ptoButton.Name = "ptoButton";
            this.ptoButton.Size = new System.Drawing.Size(213, 29);
            this.ptoButton.TabIndex = 6;
            this.ptoButton.Text = "Submit";
            this.ptoButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 5;
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.timeMonthTextBox);
            this.timeGroupBox.Controls.Add(this.timeMonthLabel);
            this.timeGroupBox.Controls.Add(this.timeDayLabel);
            this.timeGroupBox.Controls.Add(this.textBox2);
            this.timeGroupBox.Controls.Add(this.timeLabel);
            this.timeGroupBox.Controls.Add(this.textBox1);
            this.timeGroupBox.Location = new System.Drawing.Point(229, 174);
            this.timeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.timeGroupBox.Size = new System.Drawing.Size(201, 145);
            this.timeGroupBox.TabIndex = 7;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Time";
            // 
            // timeMonthTextBox
            // 
            this.timeMonthTextBox.Location = new System.Drawing.Point(96, 99);
            this.timeMonthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeMonthTextBox.Name = "timeMonthTextBox";
            this.timeMonthTextBox.ReadOnly = true;
            this.timeMonthTextBox.Size = new System.Drawing.Size(81, 20);
            this.timeMonthTextBox.TabIndex = 10;
            // 
            // timeMonthLabel
            // 
            this.timeMonthLabel.AutoSize = true;
            this.timeMonthLabel.Location = new System.Drawing.Point(4, 99);
            this.timeMonthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeMonthLabel.Name = "timeMonthLabel";
            this.timeMonthLabel.Size = new System.Drawing.Size(69, 13);
            this.timeMonthLabel.TabIndex = 9;
            this.timeMonthLabel.Text = "Time (Month)";
            // 
            // timeDayLabel
            // 
            this.timeDayLabel.AutoSize = true;
            this.timeDayLabel.Location = new System.Drawing.Point(4, 64);
            this.timeDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDayLabel.Name = "timeDayLabel";
            this.timeDayLabel.Size = new System.Drawing.Size(58, 13);
            this.timeDayLabel.TabIndex = 8;
            this.timeDayLabel.Text = "Time (Day)";
            this.timeDayLabel.Click += new System.EventHandler(this.timeDayLabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 7;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(4, 31);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(68, 13);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time (Week)";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(13, 58);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(53, 24);
            this.currentTimeLabel.TabIndex = 8;
            this.currentTimeLabel.Text = "Time";
            this.currentTimeLabel.Click += new System.EventHandler(this.currentTimeLable_Click);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(13, 17);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(48, 24);
            this.currentDateLabel.TabIndex = 9;
            this.currentDateLabel.Text = "Date";
            this.currentDateLabel.Click += new System.EventHandler(this.currentDateLabel_Click);
            // 
            // currentTimeGroupBox
            // 
            this.currentTimeGroupBox.Controls.Add(this.currentTimeLabel);
            this.currentTimeGroupBox.Controls.Add(this.currentDateLabel);
            this.currentTimeGroupBox.Location = new System.Drawing.Point(179, 17);
            this.currentTimeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentTimeGroupBox.Name = "currentTimeGroupBox";
            this.currentTimeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.currentTimeGroupBox.Size = new System.Drawing.Size(334, 101);
            this.currentTimeGroupBox.TabIndex = 10;
            this.currentTimeGroupBox.TabStop = false;
            this.currentTimeGroupBox.Text = "Current Date and Time";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(434, 191);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 128);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // concernLabel
            // 
            this.concernLabel.AutoSize = true;
            this.concernLabel.Location = new System.Drawing.Point(434, 174);
            this.concernLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.concernLabel.Name = "concernLabel";
            this.concernLabel.Size = new System.Drawing.Size(116, 13);
            this.concernLabel.TabIndex = 12;
            this.concernLabel.Text = "Comments or Concerns";
            // 
            // concernsButton
            // 
            this.concernsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.concernsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concernsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.concernsButton.Location = new System.Drawing.Point(437, 323);
            this.concernsButton.Margin = new System.Windows.Forms.Padding(2);
            this.concernsButton.Name = "concernsButton";
            this.concernsButton.Size = new System.Drawing.Size(224, 28);
            this.concernsButton.TabIndex = 13;
            this.concernsButton.Text = "Submit";
            this.concernsButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(8, 369);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 26);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // payGroupBox
            // 
            this.payGroupBox.Controls.Add(this.payTextBox);
            this.payGroupBox.Controls.Add(this.payLabel);
            this.payGroupBox.Location = new System.Drawing.Point(518, 17);
            this.payGroupBox.Name = "payGroupBox";
            this.payGroupBox.Size = new System.Drawing.Size(143, 101);
            this.payGroupBox.TabIndex = 15;
            this.payGroupBox.TabStop = false;
            this.payGroupBox.Text = "Salary";
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(10, 49);
            this.payTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.ReadOnly = true;
            this.payTextBox.Size = new System.Drawing.Size(120, 20);
            this.payTextBox.TabIndex = 6;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(51, 21);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(35, 20);
            this.payLabel.TabIndex = 0;
            this.payLabel.Text = "Pay";
            // 
            // FormDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 396);
            this.Controls.Add(this.payGroupBox);
            this.Controls.Add(this.ptoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.concernsButton);
            this.Controls.Add(this.concernLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.currentTimeGroupBox);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockOutButton);
            this.Controls.Add(this.clockInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.FormDomain_Load);
            this.Time.ResumeLayout(false);
            this.Time.PerformLayout();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.currentTimeGroupBox.ResumeLayout(false);
            this.currentTimeGroupBox.PerformLayout();
            this.payGroupBox.ResumeLayout(false);
            this.payGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockInButton;
        private System.Windows.Forms.Button clockOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox Time;
        private System.Windows.Forms.Label requestPTOLable;
        private System.Windows.Forms.Button ptoButton;
        private System.Windows.Forms.LinkLabel ptoDetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.Label timeDayLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeMonthLabel;
        private System.Windows.Forms.TextBox timeMonthTextBox;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.GroupBox currentTimeGroupBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label concernLabel;
        private System.Windows.Forms.Button concernsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox payGroupBox;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox payTextBox;
    }
}