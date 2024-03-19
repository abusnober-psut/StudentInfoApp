namespace StudentInfoApp
{
    partial class frmInfo
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.nudGPA = new System.Windows.Forms.NumericUpDown();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cbBus = new System.Windows.Forms.CheckBox();
            this.cbCar = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlLevel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 26);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 22);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Enter Student Name");
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(45, 66);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(153, 63);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(225, 64);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 356);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Items.AddRange(new object[] {
            "item1",
            "item2"});
            this.lstStudents.Location = new System.Drawing.Point(431, 186);
            this.lstStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(244, 164);
            this.lstStudents.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(576, 356);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(431, 357);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 28);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Count of List Items";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(45, 100);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 16);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country:";
            // 
            // comboCountry
            // 
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Items.AddRange(new object[] {
            "Jordan",
            "Palestine",
            "Syria",
            "Iraq"});
            this.comboCountry.Location = new System.Drawing.Point(153, 95);
            this.comboCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(207, 24);
            this.comboCountry.TabIndex = 10;
            this.comboCountry.SelectedIndexChanged += new System.EventHandler(this.comboCountry_SelectedIndexChanged);
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Location = new System.Drawing.Point(4, 23);
            this.lblYearLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(40, 16);
            this.lblYearLevel.TabIndex = 11;
            this.lblYearLevel.Text = "Level";
            // 
            // pnlLevel
            // 
            this.pnlLevel.Controls.Add(this.radioButton3);
            this.pnlLevel.Controls.Add(this.radioButton4);
            this.pnlLevel.Controls.Add(this.radioButton2);
            this.pnlLevel.Controls.Add(this.radioButton1);
            this.pnlLevel.Controls.Add(this.lblYearLevel);
            this.pnlLevel.Location = new System.Drawing.Point(49, 134);
            this.pnlLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(312, 92);
            this.pnlLevel.TabIndex = 14;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(108, 55);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 20);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Third";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(197, 57);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 20);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fourth";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(111, 20);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "First";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(197, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 20);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Second";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGPA);
            this.groupBox1.Controls.Add(this.nudGPA);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(49, 242);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(312, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Academic Info";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(11, 32);
            this.lblGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(38, 16);
            this.lblGPA.TabIndex = 16;
            this.lblGPA.Text = "GPA:";
            // 
            // nudGPA
            // 
            this.nudGPA.DecimalPlaces = 2;
            this.nudGPA.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudGPA.Location = new System.Drawing.Point(111, 32);
            this.nudGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudGPA.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudGPA.Name = "nudGPA";
            this.nudGPA.Size = new System.Drawing.Size(104, 22);
            this.nudGPA.TabIndex = 15;
            this.toolTip1.SetToolTip(this.nudGPA, "GPA");
            this.nudGPA.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // picLogo
            // 
            this.picLogo.Image = global::StudentInfoApp.Properties.Resources.PSUT_Logo;
            this.picLogo.Location = new System.Drawing.Point(551, 30);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 86);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            this.picLogo.MouseLeave += new System.EventHandler(this.picLogo_MouseLeave);
            this.picLogo.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // cbBus
            // 
            this.cbBus.AutoSize = true;
            this.cbBus.Location = new System.Drawing.Point(57, 322);
            this.cbBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(108, 20);
            this.cbBus.TabIndex = 16;
            this.cbBus.Text = "Bus Services";
            this.cbBus.UseVisualStyleBackColor = true;
            this.cbBus.CheckedChanged += new System.EventHandler(this.cbBus_CheckedChanged);
            // 
            // cbCar
            // 
            this.cbCar.AutoSize = true;
            this.cbCar.Location = new System.Drawing.Point(203, 322);
            this.cbCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(137, 20);
            this.cbCar.TabIndex = 17;
            this.cbCar.Text = "Car Park Services";
            this.cbCar.UseVisualStyleBackColor = true;
            this.cbCar.CheckedChanged += new System.EventHandler(this.cbCar_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(4, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 393);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.cbBus);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlLevel);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInfo";
            this.Text = "Student Info Form";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.pnlLevel.ResumeLayout(false);
            this.pnlLevel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.NumericUpDown nudGPA;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.CheckBox cbBus;
        private System.Windows.Forms.CheckBox cbCar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

