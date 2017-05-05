using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nanotubes
{
    public partial class Form1 : Form
    {

        //Form form1; 

        public Form1()
        {
            //try
            //{
                    //System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                    //System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
                    //MessageBox.Show("The Length");
              //      Form1 form1 = new Form1();
              
            //}
            //catch { }

                /*// Set the text of button1 to "OK".
                button1.Text = "OK";
                // Set the position of the button on the form.
                button1.Location = new System.Drawing.Point(10, 10);
                // Set the text of button2 to "Cancel".
                button2.Text = "Cancel";
                // Set the position of the button based on the location of button1.
                button2.Location
                   = new System.Drawing.Point(button1.Left, button1.Height + button1.Top + 10);
                // Set the caption bar text of the form.   
                form1.Text = "My Dialog Box";
                // Display a help button on the form.
                form1.HelpButton = true;

                // Define the border style of the form to a dialog box.
                form1.FormBorderStyle = FormBorderStyle.FixedDialog;
                // Set the MaximizeBox to false to remove the maximize box.
                form1.MaximizeBox = false;
                // Set the MinimizeBox to false to remove the minimize box.
                form1.MinimizeBox = false;
                // Set the accept button of the form to button1.
                form1.AcceptButton = button1;
                // Set the cancel button of the form to button2.
                form1.CancelButton = button2;
                // Set the start position of the form to the center of the screen.
                form1.StartPosition = FormStartPosition.CenterScreen;

                // Add button1 to the form.
                form1.Controls.Add(button1);
                // Add button2 to the form.
                form1.Controls.Add(button2);
                */

                //form1.ShowDialog();
          
            //MessageBox.Show("The Length");
            //form1.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox5.Text = "0.000000652";
            this.textBox4.Text = "0.000000000876";
            this.textBox1.Text = "0.000000000278";

            this.textBox6.Text = "0.142";

            this.textBox8.Text = "0.142";

            this.textBox3.Text = "0.00000005488";

            this.textBox7.Text = "0.147";

            // Change Prperties Through Coding
            /*try
            {
                
                this.Text = "Change Prperties Through Coding";
                this.BackColor = Color.Brown;
                this.Size = new Size(350, 125);
                this.Location = new Point(300, 300);
                this.MaximizeBox = false;
            }
            catch { }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //float a;
            double first, second, third,first1;
            //int answer;
            string s,s1;
            int selectedIndex;

            //second = (Double.Parse(textBoxNames33.Text) / Double.Parse(textBoxNames32.Text)) * Math.Pow(((Double.Parse(textBoxNames30.Text) - Double.Parse(textBoxNames31.Text)) / Double.Parse(textBoxNames32.Text)), (Double.Parse(textBoxNames33.Text) - 1));
            //third = Math.Pow(2.71, Math.Pow((-1) * ((Double.Parse(textBoxNames30.Text) - Double.Parse(textBoxNames31.Text)) / Double.Parse(textBoxNames32.Text)), (Double.Parse(textBoxNames33.Text))));
            

            first =  (  Math.Pow(Double.Parse(this.textBox5.Text),2) * Double.Parse(this.textBox6.Text) )  /  ( 4*3.14* Double.Parse(this.textBox4.Text)  )  ;
            s = Convert.ToString(first);
            this.textBox3.Text =  s;

        



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //float a;
            double first1;
            //int answer;
            string s1;
            

            first1 = (3.14 / (6 * 1.73)) * ((Double.Parse(this.textBox7.Text) * Double.Parse(this.textBox3.Text)) / Double.Parse(this.textBox6.Text));            //(Math.Pow(Double.Parse(this.textBox5.Text), 2) * Double.Parse(this.textBox6.Text)) / (4 * 3.14 * Double.Parse(this.textBox4.Text));
            s1 = Convert.ToString(first1);
            this.textBox2.Text = s1;


        }
    }
}
