namespace dotnet_l3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			int val = ((int)this.numericUpDown1.Value);
			this.textBox1.Clear();
			for (int i = 1; i <= val; ++i)
				this.textBox1.Text += ($"{i} ");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.comboBox1.Items.Add(this.textBox2.Text);
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.comboBox1.Items.Clear();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var i = this.comboBox1.SelectedIndex;
			var src = this.comboBox1.Items[i];
			if (src != null) {
				this.textBox3.Text = src.ToString();
			}
		}

		private void button_plus_Click(object sender, EventArgs e)
		{
			float op1, op2;
			if (!float.TryParse(this.textBox_op1.Text, out op1)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}
			if (!float.TryParse(this.textBox_op2.Text, out op2)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}

			this.textBox_res.Text = (op1 + op2).ToString();
		}

		private void button_minus_Click(object sender, EventArgs e)
		{
			float op1, op2;
			if (!float.TryParse(this.textBox_op1.Text, out op1)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}
			if (!float.TryParse(this.textBox_op2.Text, out op2)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}

			this.textBox_res.Text = (op1 - op2).ToString();
		}

		private void button_div_Click(object sender, EventArgs e)
		{
			float op1, op2;
			if (!float.TryParse(this.textBox_op1.Text, out op1)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}
			if (!float.TryParse(this.textBox_op2.Text, out op2)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}
			if (op2 == 0.0) {
				this.textBox_res.Text = "Div by zero!";
				return;
			}


			this.textBox_res.Text = (op1 / op2).ToString();
		}

		private void button_mul_Click(object sender, EventArgs e)
		{
			float op1, op2;
			if (!float.TryParse(this.textBox_op1.Text, out op1)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}
			if (!float.TryParse(this.textBox_op2.Text, out op2)) {
				this.textBox_res.Text = "Invalid!";
				return;
			}

			this.textBox_res.Text = (op1 * op2).ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.comboBox2.Items.Clear();
			foreach (var line in this.textBox_floats.Lines) {
				float num;
				if (float.TryParse(line, out num)) {
					this.comboBox2.Items.Add(num);
				}
			}
		}

		private void button51_Click(object sender, EventArgs e)
		{
			var start_time = System.DateTime.UtcNow;
			this.textBox51.Clear();

			var n = this.numericUpDown51.Value;
			decimal sum = 0, x = 1;
			do {
				decimal part = 1 / x++;
				if (part < n)
					break;
				sum += part;
				this.textBox51.Text += $"{sum}\r\n";
				this.textBox51.Refresh();
			} while (true);

			var duration = System.DateTime.UtcNow - start_time;
			MessageBox.Show(duration.TotalSeconds.ToString("N3") + " секунд");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var lines = this.textBox61.Lines;
			for (var i = lines.Length - 1; i >= 0; i--) {
				decimal dumb;
				if (decimal.TryParse(lines[i], out dumb)) {
					continue;
				}
				this.textBox62.AppendText($"{lines[i]}\r\n");
			}
		}

		private void tab7_print_invalid()
		{
			this.textBox7out.Text = "Неправильный ввод";
		}

		private void button7calc_Click(object sender, EventArgs e)
		{
			this.textBox7out.Clear();
			double a, b, h;
			var box_a = this.textBox7a.Text;
			var box_b = this.textBox7b.Text;
			var box_h = this.textBox7h.Text;

			if (!double.TryParse(box_a, out a)) {
				tab7_print_invalid();
				return;
			}
			if (!double.TryParse(box_b, out b)) {
				tab7_print_invalid();
				return;
			}
			if (!double.TryParse(box_h, out h)) {
				tab7_print_invalid();
				return;
			}
		}
	}
}
