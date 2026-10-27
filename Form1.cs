namespace Card_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox4.Text;
        }
        bool k = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (k == false)
            {
                k = true;
                pictureBox3.ImageLocation = "C:\\Users\\Student\\Desktop\\img1\\hidden.png";
                textBox5.UseSystemPasswordChar = false;
            }
            else
            {
                k = false;
                pictureBox3.ImageLocation = "C:\\Users\\Student\\Desktop\\img1\\view.png";
                textBox5.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text))
            {
                timer1.Start();
                progressBar1.Visible = true;
                MessageBox.Show("Empty or null boxes", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if(textBox1.Text.Length==19 && int.TryParse(textBox4.Text, out int cvc) && textBox4.Text.Length==3)
                {
                    timer1.Start();
                    progressBar1.Visible = true;
                    MessageBox.Show("Card information check", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong include card information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Operation completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d==DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }
    }
}
