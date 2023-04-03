namespace WindowsFormShape
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupRec = new System.Windows.Forms.GroupBox();
            this.groupSquare = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRectangleLength = new System.Windows.Forms.TextBox();
            this.txtWidthRectangle = new System.Windows.Forms.TextBox();
            this.txtLengthSquare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumofSides = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupRec.SuspendLayout();
            this.groupSquare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSquare);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Location = new System.Drawing.Point(76, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(23, 30);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(23, 53);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(59, 17);
            this.rbSquare.TabIndex = 2;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumofSides);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(369, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // groupRec
            // 
            this.groupRec.Controls.Add(this.txtWidthRectangle);
            this.groupRec.Controls.Add(this.txtRectangleLength);
            this.groupRec.Controls.Add(this.label2);
            this.groupRec.Controls.Add(this.label1);
            this.groupRec.Location = new System.Drawing.Point(76, 203);
            this.groupRec.Name = "groupRec";
            this.groupRec.Size = new System.Drawing.Size(184, 111);
            this.groupRec.TabIndex = 3;
            this.groupRec.TabStop = false;
            this.groupRec.Text = "Rectangle";
            // 
            // groupSquare
            // 
            this.groupSquare.Controls.Add(this.txtLengthSquare);
            this.groupSquare.Controls.Add(this.label4);
            this.groupSquare.Location = new System.Drawing.Point(369, 203);
            this.groupSquare.Name = "groupSquare";
            this.groupSquare.Size = new System.Drawing.Size(184, 111);
            this.groupSquare.TabIndex = 3;
            this.groupSquare.TabStop = false;
            this.groupSquare.Text = "Square";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // txtRectangleLength
            // 
            this.txtRectangleLength.Location = new System.Drawing.Point(51, 39);
            this.txtRectangleLength.Name = "txtRectangleLength";
            this.txtRectangleLength.Size = new System.Drawing.Size(100, 20);
            this.txtRectangleLength.TabIndex = 2;
            // 
            // txtWidthRectangle
            // 
            this.txtWidthRectangle.Location = new System.Drawing.Point(51, 66);
            this.txtWidthRectangle.Name = "txtWidthRectangle";
            this.txtWidthRectangle.Size = new System.Drawing.Size(100, 20);
            this.txtWidthRectangle.TabIndex = 3;
            // 
            // txtLengthSquare
            // 
            this.txtLengthSquare.Location = new System.Drawing.Point(67, 39);
            this.txtLengthSquare.Name = "txtLengthSquare";
            this.txtLengthSquare.Size = new System.Drawing.Size(100, 20);
            this.txtLengthSquare.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            // 
            // txtNumofSides
            // 
            this.txtNumofSides.Location = new System.Drawing.Point(79, 57);
            this.txtNumofSides.Name = "txtNumofSides";
            this.txtNumofSides.Size = new System.Drawing.Size(100, 20);
            this.txtNumofSides.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. of Sides";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupSquare);
            this.Controls.Add(this.groupRec);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupRec.ResumeLayout(false);
            this.groupRec.PerformLayout();
            this.groupSquare.ResumeLayout(false);
            this.groupSquare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupSquare;
        private System.Windows.Forms.TextBox txtNumofSides;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWidthRectangle;
        private System.Windows.Forms.TextBox txtRectangleLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLengthSquare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

