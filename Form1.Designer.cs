namespace dotnet_l3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			textBox1 = new TextBox();
			numericUpDown1 = new NumericUpDown();
			tabPage2 = new TabPage();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			comboBox1 = new ComboBox();
			tabPage3 = new TabPage();
			textBox_op2 = new TextBox();
			textBox_res = new TextBox();
			textBox_op1 = new TextBox();
			button_div = new Button();
			button_minus = new Button();
			button_mul = new Button();
			button_plus = new Button();
			tabPage4 = new TabPage();
			button3 = new Button();
			comboBox2 = new ComboBox();
			textBox_floats = new TextBox();
			tabPage5 = new TabPage();
			button51 = new Button();
			numericUpDown51 = new NumericUpDown();
			textBox51 = new TextBox();
			tabPage6 = new TabPage();
			tabPage7 = new TabPage();
			textBox61 = new TextBox();
			textBox62 = new TextBox();
			button4 = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			tabPage2.SuspendLayout();
			tabPage3.SuspendLayout();
			tabPage4.SuspendLayout();
			tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown51).BeginInit();
			tabPage6.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Controls.Add(tabPage5);
			tabControl1.Controls.Add(tabPage6);
			tabControl1.Controls.Add(tabPage7);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.ItemSize = new Size(61, 20);
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(800, 450);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(textBox1);
			tabPage1.Controls.Add(numericUpDown1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(792, 422);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Первая";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Bottom;
			textBox1.Location = new Point(3, 26);
			textBox1.Margin = new Padding(3, 33, 3, 3);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(786, 393);
			textBox1.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(0, 0);
			numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(373, 23);
			numericUpDown1.TabIndex = 0;
			numericUpDown1.Value = new decimal(new int[] { 42, 0, 0, 0 });
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(textBox3);
			tabPage2.Controls.Add(textBox2);
			tabPage2.Controls.Add(button2);
			tabPage2.Controls.Add(button1);
			tabPage2.Controls.Add(comboBox1);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(792, 422);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Вторая";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(8, 95);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(156, 23);
			textBox3.TabIndex = 4;
			textBox3.Text = "textbox3";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(8, 66);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(156, 23);
			textBox2.TabIndex = 3;
			textBox2.Text = "textbox2";
			// 
			// button2
			// 
			button2.Location = new Point(89, 37);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// button1
			// 
			button1.Location = new Point(8, 37);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(8, 8);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(156, 23);
			comboBox1.TabIndex = 0;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(textBox_op2);
			tabPage3.Controls.Add(textBox_res);
			tabPage3.Controls.Add(textBox_op1);
			tabPage3.Controls.Add(button_div);
			tabPage3.Controls.Add(button_minus);
			tabPage3.Controls.Add(button_mul);
			tabPage3.Controls.Add(button_plus);
			tabPage3.Location = new Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new Size(792, 422);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Третья";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// textBox_op2
			// 
			textBox_op2.Location = new Point(8, 95);
			textBox_op2.Name = "textBox_op2";
			textBox_op2.Size = new Size(156, 23);
			textBox_op2.TabIndex = 5;
			textBox_op2.TextAlign = HorizontalAlignment.Right;
			// 
			// textBox_res
			// 
			textBox_res.Location = new Point(8, 124);
			textBox_res.Name = "textBox_res";
			textBox_res.Size = new Size(156, 23);
			textBox_res.TabIndex = 6;
			textBox_res.TextAlign = HorizontalAlignment.Right;
			// 
			// textBox_op1
			// 
			textBox_op1.Location = new Point(8, 66);
			textBox_op1.Name = "textBox_op1";
			textBox_op1.Size = new Size(156, 23);
			textBox_op1.TabIndex = 4;
			textBox_op1.TextAlign = HorizontalAlignment.Right;
			// 
			// button_div
			// 
			button_div.Location = new Point(8, 37);
			button_div.Name = "button_div";
			button_div.Size = new Size(75, 23);
			button_div.TabIndex = 3;
			button_div.Text = "/";
			button_div.UseVisualStyleBackColor = true;
			button_div.Click += button_div_Click;
			// 
			// button_minus
			// 
			button_minus.Location = new Point(89, 8);
			button_minus.Name = "button_minus";
			button_minus.Size = new Size(75, 23);
			button_minus.TabIndex = 2;
			button_minus.Text = "-";
			button_minus.UseVisualStyleBackColor = true;
			button_minus.Click += button_minus_Click;
			// 
			// button_mul
			// 
			button_mul.Location = new Point(89, 37);
			button_mul.Name = "button_mul";
			button_mul.Size = new Size(75, 23);
			button_mul.TabIndex = 1;
			button_mul.Text = "*";
			button_mul.UseVisualStyleBackColor = true;
			button_mul.Click += button_mul_Click;
			// 
			// button_plus
			// 
			button_plus.Location = new Point(8, 8);
			button_plus.Name = "button_plus";
			button_plus.Size = new Size(75, 23);
			button_plus.TabIndex = 0;
			button_plus.Text = "+";
			button_plus.UseVisualStyleBackColor = true;
			button_plus.Click += button_plus_Click;
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(button3);
			tabPage4.Controls.Add(comboBox2);
			tabPage4.Controls.Add(textBox_floats);
			tabPage4.Location = new Point(4, 24);
			tabPage4.Name = "tabPage4";
			tabPage4.Size = new Size(792, 422);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Четвёртая";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(8, 66);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 2;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(8, 37);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(121, 23);
			comboBox2.TabIndex = 1;
			// 
			// textBox_floats
			// 
			textBox_floats.Location = new Point(8, 95);
			textBox_floats.Multiline = true;
			textBox_floats.Name = "textBox_floats";
			textBox_floats.ScrollBars = ScrollBars.Both;
			textBox_floats.Size = new Size(268, 156);
			textBox_floats.TabIndex = 0;
			// 
			// tabPage5
			// 
			tabPage5.Controls.Add(button51);
			tabPage5.Controls.Add(numericUpDown51);
			tabPage5.Controls.Add(textBox51);
			tabPage5.Location = new Point(4, 24);
			tabPage5.Name = "tabPage5";
			tabPage5.Size = new Size(792, 422);
			tabPage5.TabIndex = 4;
			tabPage5.Text = "Пятая";
			tabPage5.UseVisualStyleBackColor = true;
			// 
			// button51
			// 
			button51.Location = new Point(8, 45);
			button51.Name = "button51";
			button51.Size = new Size(75, 23);
			button51.TabIndex = 2;
			button51.Text = "button4";
			button51.UseVisualStyleBackColor = true;
			button51.Click += button51_Click;
			// 
			// numericUpDown51
			// 
			numericUpDown51.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
			numericUpDown51.Location = new Point(8, 16);
			numericUpDown51.Maximum = new decimal(new int[] { 1, 0, 0, 131072 });
			numericUpDown51.Minimum = new decimal(new int[] { 1, 0, 0, 393216 });
			numericUpDown51.Name = "numericUpDown51";
			numericUpDown51.Size = new Size(120, 23);
			numericUpDown51.TabIndex = 1;
			numericUpDown51.Value = new decimal(new int[] { 1, 0, 0, 393216 });
			// 
			// textBox51
			// 
			textBox51.Location = new Point(3, 74);
			textBox51.Multiline = true;
			textBox51.Name = "textBox51";
			textBox51.ScrollBars = ScrollBars.Both;
			textBox51.Size = new Size(250, 105);
			textBox51.TabIndex = 0;
			// 
			// tabPage6
			// 
			tabPage6.Controls.Add(button4);
			tabPage6.Controls.Add(textBox62);
			tabPage6.Controls.Add(textBox61);
			tabPage6.Location = new Point(4, 24);
			tabPage6.Name = "tabPage6";
			tabPage6.Size = new Size(792, 422);
			tabPage6.TabIndex = 5;
			tabPage6.Text = "Шестая";
			tabPage6.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			tabPage7.Location = new Point(4, 24);
			tabPage7.Name = "tabPage7";
			tabPage7.Size = new Size(792, 422);
			tabPage7.TabIndex = 6;
			tabPage7.Text = "Седьмая";
			tabPage7.UseVisualStyleBackColor = true;
			// 
			// textBox61
			// 
			textBox61.Location = new Point(20, 90);
			textBox61.Multiline = true;
			textBox61.Name = "textBox61";
			textBox61.ScrollBars = ScrollBars.Both;
			textBox61.Size = new Size(266, 216);
			textBox61.TabIndex = 0;
			// 
			// textBox62
			// 
			textBox62.Location = new Point(321, 90);
			textBox62.Multiline = true;
			textBox62.Name = "textBox62";
			textBox62.ScrollBars = ScrollBars.Both;
			textBox62.Size = new Size(308, 216);
			textBox62.TabIndex = 1;
			// 
			// button4
			// 
			button4.Location = new Point(20, 17);
			button4.Name = "button4";
			button4.Size = new Size(206, 23);
			button4.TabIndex = 2;
			button4.Text = "button4";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Name = "Form1";
			Text = "Form1";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			tabPage4.ResumeLayout(false);
			tabPage4.PerformLayout();
			tabPage5.ResumeLayout(false);
			tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown51).EndInit();
			tabPage6.ResumeLayout(false);
			tabPage6.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private TabPage tabPage5;
		private TabPage tabPage6;
		private TabPage tabPage7;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox1;
		private TextBox textBox3;
		private TextBox textBox2;
		private Button button2;
		private Button button1;
		private TextBox textBox_op2;
		private TextBox textBox_res;
		private TextBox textBox_op1;
		private Button button_div;
		private Button button_minus;
		private Button button_mul;
		private Button button_plus;
		private Button button3;
		private ComboBox comboBox2;
		private TextBox textBox_floats;
		private Button button51;
		private NumericUpDown numericUpDown51;
		private TextBox textBox51;
		private Button button4;
		private TextBox textBox62;
		private TextBox textBox61;
	}
}
