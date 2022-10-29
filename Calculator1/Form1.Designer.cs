namespace Calculator1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_choice = new System.Windows.Forms.ComboBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.txt_firstvalue = new System.Windows.Forms.TextBox();
            this.txt_2ndValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.lbl_last_operator = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 47);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter First Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter 2nd Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choice:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_choice
            // 
            this.cmb_choice.FormattingEnabled = true;
            this.cmb_choice.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply"});
            this.cmb_choice.Location = new System.Drawing.Point(222, 176);
            this.cmb_choice.Name = "cmb_choice";
            this.cmb_choice.Size = new System.Drawing.Size(100, 21);
            this.cmb_choice.TabIndex = 7;
            // 
            // btn_cal
            // 
            this.btn_cal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cal.Image = ((System.Drawing.Image)(resources.GetObject("btn_cal.Image")));
            this.btn_cal.Location = new System.Drawing.Point(194, 277);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(101, 39);
            this.btn_cal.TabIndex = 8;
            this.btn_cal.Text = "Calculator";
            this.btn_cal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // txt_firstvalue
            // 
            this.txt_firstvalue.Location = new System.Drawing.Point(222, 97);
            this.txt_firstvalue.Name = "txt_firstvalue";
            this.txt_firstvalue.Size = new System.Drawing.Size(100, 20);
            this.txt_firstvalue.TabIndex = 9;
            this.txt_firstvalue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_2ndValue
            // 
            this.txt_2ndValue.Location = new System.Drawing.Point(222, 129);
            this.txt_2ndValue.Name = "txt_2ndValue";
            this.txt_2ndValue.Size = new System.Drawing.Size(100, 20);
            this.txt_2ndValue.TabIndex = 10;
            this.txt_2ndValue.TextChanged += new System.EventHandler(this.txt_2ndValue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Answer";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(222, 212);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(100, 20);
            this.txt_Answer.TabIndex = 12;
            // 
            // lbl_last_operator
            // 
            this.lbl_last_operator.AutoSize = true;
            this.lbl_last_operator.Location = new System.Drawing.Point(9, 325);
            this.lbl_last_operator.Name = "lbl_last_operator";
            this.lbl_last_operator.Size = new System.Drawing.Size(71, 13);
            this.lbl_last_operator.TabIndex = 13;
            this.lbl_last_operator.Text = "Last Operator";
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(422, 285);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(75, 23);
            this.btn_History.TabIndex = 14;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(318, 285);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_last_operator);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_2ndValue);
            this.Controls.Add(this.txt_firstvalue);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.cmb_choice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_choice;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.TextBox txt_firstvalue;
        private System.Windows.Forms.TextBox txt_2ndValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Label lbl_last_operator;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label6;
    }
}

