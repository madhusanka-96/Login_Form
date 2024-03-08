using System.Diagnostics.Eventing.Reader;

namespace Registration_App
{
    public partial class Form1 : Form
    {
        private bool validemail(String email)
        {
            try
            {
                var mailadd = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstname = textBox1.Text.ToString();
            String lastname = textBox2.Text.ToString();
            String username = textBox3.Text.ToString();

            if (String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(lastname) || String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Name Validation", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Empty Value", "Name Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //password

            String pass = textBox4.Text.ToString();
            String conpass = textBox5.Text.ToString();

            if (String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(conpass))
            {
                MessageBox.Show("Empty Value", "Password Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pass == conpass)
            {
                MessageBox.Show("valid Value", "Name Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Empty Value", "Name Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //email

            String email = textBox6.Text.ToString();

            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Empty Value", "email Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validemail(email))
            {
                MessageBox.Show("Empty Value", "Email Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Empty Value", "Email Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //gender
            String m = radioButton1.Text.ToString();
            String f = radioButton2.Text.ToString();

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show(m);
                }
                else
                {
                    MessageBox.Show(f);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "[image file(* .jpg;* .jpeg;* .gif;* .bmp)| * .jpg;* .jpeg;* .gif;* .bmp]";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "[image(* .pdf)|*.pdf;]";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
              
            }
        }
    }
}
