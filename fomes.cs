--- CHECK BOX ---

if (checkBox1.Checked)
{
    textBox2.UseSystemPasswordChar = false;
}
else
{
    textBox2.UseSystemPasswordChar = true;
}

--- CLOSE ---

 this.Close();

--- LOG ---

 String name = textBox1.Text.ToString();
 String password = textBox2.Text.ToString(); 

 if(string.IsNullOrEmpty(name) || String.IsNullOrEmpty(password )) {
     MessageBox.Show("Field is Empty");
 }
 else
 {
     MessageBox.Show(
         $"name is : {name}\n" +
         $"password is : {password}"
         );
 }

--- FILE UPLOAD ---

 OpenFileDialog open = new OpenFileDialog();
 open.Filter = "[image(*.pdf)|*.pdf;]";

 if (open.ShowDialog() == DialogResult.OK)
 {
     label1.Text = open.FileName;
 }

--- IMAGE UPLOAD ---

OpenFileDialog open = new OpenFileDialog();
open.Filter = "[image files(*.jpg; *.jpeg; *.gif; *.bif)|*.jpg; *.jpeg; *.gif; *.bif]";
if (open.ShowDialog() == DialogResult.OK) {
    pictureBox1.Image = new Bitmap(open.FileName);
}

--- LINK PAGE ---

Form2 f = new Form2();
f.Show();
this.hide();

--- CONVERTOR ---

float value = (float)numericUpDown1.Value;

 if (checkBox1.Checked)
 {
     float ans = value / 350;
     label1.Text = ans.ToString();
 }
 else if (checkBox2.Checked)
 {
     float ans = value * 350;
     label1.Text = ans.ToString();

---- CAL ----

int value1 = (int)numericUpDown1.Value;
 int value2 = (int)numericUpDown2.Value;
 if (comboBox1.SelectedIndex == 0)
 {
     int sum = value1 + value2;
     label2.Text = sum.ToString();
 }
 if (comboBox1.SelectedIndex == 1)
 {
     int sub = value1 - value2;
     label2.Text = sub.ToString();
 }
 if (comboBox1.SelectedIndex == 2)
 {
     int mul = value1 * value2;
     label2.Text = mul.ToString();
 }
 if (comboBox1.SelectedIndex == 3)
 {
     int div = value1 / value2;
     label2.Text = div.ToString();
 }




--- VALIDATION ---

------------------- namevalid------------------------------

            String name = textBox1.Text.ToString();
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is Empty");
            }
            else
            {
                MessageBox.Show("Name is Ok");
            }

            --------------------password valid--------------------------

            String pw = textBox2.Text.ToString();
            string cpw = textBox3.Text.ToString();

            if (String.IsNullOrEmpty(pw) || String.IsNullOrEmpty(cpw))
            {
                MessageBox.Show("Password is Empty", "password validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pw == cpw)
                {
                    MessageBox.Show("Password is Valid", "password validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password is invalid", "password validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           -------------------- mail validate-------------------------------------------

        private bool isValid(String mail)
        {
            try
            {
                var valid = new System.Net.Mail.MailAddress(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
---------------------------------------------------------------------


            String mail = textBox4.Text.ToString();
            if (String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Email is Empty", "email validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (isValid(mail))
                {
                    MessageBox.Show("Email is Valid", "email validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email is Invalid", "email validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




               ----------------------------- age valid-------------------------------------

                DateTime bdy = dateTimePicker1.Value;
                DateTime currentdate = DateTime.Now;
                String test = bdy.ToString();

                if (String.IsNullOrEmpty(test))
                {
                    MessageBox.Show("Age is empty", "age validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int age = currentdate.Year - bdy.Year;

                    test2 = age.ToString();
                    MessageBox.Show("Age is ok", "age validation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

-------------------show all document-----------------------------------

                MessageBox.Show(
                    $"Name is: {name}\n" +
                    $"Password is: {pw}\n" +
                    $"Conform password is: {cpw}\n" +
                    $"Email is: {mail}\n" +
                    $"Age is {test2}"
                    );
        


       
        ------------------------clear button--------------------------

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.ResetText();
        }
    }
}

