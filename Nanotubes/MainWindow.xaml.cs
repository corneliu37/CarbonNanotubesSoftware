
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using System.Windows.Forms;
//using MLApp;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using System.Net.Sockets;


namespace Nanotubes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
   
    public partial class MainWindow : Window
    {
        int c;

         

        public MainWindow()
        {
            //label1.Text = "Client Socket Program - Server Connected ...";

            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int c;
            c = 2;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //this.TextBox_TextChanged = TextBox.Text ;//= "eee";
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxName4.Text = s;
            }
            catch { }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;
            //TextBox textBox = sender as TextBox;

            //first = 0.01* Double.Parse(textBoxName.Text)*Double.Parse(textBoxName1.Text) * Double.Parse(textBoxName2.Text);
            //first = (3.14 / 4) * (   Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2)   );
            try
            {
                first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxName3.Text = s;
                //if (textBox == null)
                //{
                //MessageBox.Show("test"); 
                // MessageBox.Show(textBoxName.Text);
                //}
                //MessageBox.Show(textBox.Text);
                /*try
                {
                    //answer = int.Parse(textBox.Text);
                    answer = Convert.ToInt32(textBox.Text);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} is outside the range of the Int32 type.", textBox.Text);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                      textBox.Text.GetType().Name, textBox.Text);
                }
                catch 
                {
                    Console.WriteLine("The {0} value '{1}' is not");
                }   

                */

                //string var2;
                
                //var2 = answer.ToString();
                //string b;
                //b = "111";
                //c = c+1;



                //    MessageBox.Show(var2);
                //if (RadioButton1.IsChecked == true)
                //{
                //   MessageBox.Show(var2);
                //}
                //else
                //{
                //    RadioButton2.IsChecked = true;
                //    MessageBox.Show("Goodbye.");
                //}

            }
            catch { }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 subWindow = new Window1();
            subWindow.Show();
            //Console.WriteLine("Floating point quotient:    {0}");
        }


        private void Button_Click3(object sender, RoutedEventArgs e)
        {


            //float a;
            double first =0.0f;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {

                first = (1.0 / 1315.0 ) * ( 3.14 * 2 *  Double.Parse(textBoxName5.Text)  *  Double.Parse(textBoxName2.Text)  );

                //first = 1*3;
               // first = (1 / 1315 ) * ( 3.14 * 2 * 
        
                //first = ( float.Parse(textBoxName5.Text) ) * ( float.Parse(textBoxName2.Text)  );

                //first = (1 / 1315) * (3 * 2 * first); 

                //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
               
                textBoxName6.Text = s;
            }
            catch { }



        }
        
        private void textBoxName5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxName6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        public void msg(string mesg)
        {

            // textBlock1.Text = textBlock1.Text + Environment.NewLine + " >> " + mesg;

            Console.WriteLine(mesg);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

                //client 

                System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
                //NetworkStream serverStream;

                msg("Client Started");

                //System.Windows.MessageBox.Show("The Length of Composite can not be smaller than the Length of the Nano Tube");
                try
                {
                //msg("Am I here?");


                //It is waiting here for connection from the other PC ?
                clientSocket.Connect("127.0.0.1", 8888);

                //System.Windows.MessageBox.Show(" 2 ");
             
                NetworkStream serverStream = clientSocket.GetStream();
             
                //System.Windows.MessageBox.Show("The Length of Composite can not be smaller than the Length of the Nano Tube");
                
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Message from Client$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                
                //System.Windows.MessageBox.Show("The Length of Composite can not be smaller than the Length of the Nano Tube");

                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                msg("Data from Server : " + returndata);
                
                //System.Windows.MessageBox.Show("The Length of Composite can not be smaller than the Length of the Nano Tube");
            }
            catch { }

        }




    }

   
    //[XmlInclude(typeof(MySerializableClass))]
    [Serializable]
    public class MySerializableClass
    {

        public double LengthofNanotube;
        public double RadiusofNanotube;
        public double VolumeofNanotube;
        public double LengthofComposite;
        public double WidthofNanotube;
        public double HeightofNanotube;
        public double VolumeofComposite;
        public double VolumeofMatrix;
        public double VolumeFractionFibre;
        public double VolumeFractionMatrix;
        public double ElasticFibre;
        public double ElasticMatrix;
        public double RuleofMixture;
        public double InverseofRuleofMixture;
        public double WeightofSingleWall;

        public double LengthofActualFibre;
        public double LengthofNormalizingFibre;
        public double NormalisingStrength;
        public double ActualStress;
        public double WeibullModulus;
        public double ProbabilityofFailure;




        public MySerializableClass(string tN1, string tN2, string tN3, string tN4, string tN5, string tN6, string tN7, string tN8, string tN9, string tN10, string tN11, string tN12, string tN13, string tN14, string tN15, string tN16, string tN17, string tN18, string tN19, string tN20, string tN21)
        {

            //try
              
                LengthofNanotube = Double.Parse(tN1);
                RadiusofNanotube = Double.Parse(tN2);
                VolumeofNanotube = Double.Parse(tN3);
                LengthofComposite = Double.Parse(tN4);
                WidthofNanotube = Double.Parse(tN5);
                HeightofNanotube = Double.Parse(tN6);
                VolumeofComposite = Double.Parse(tN7);
                VolumeofMatrix = Double.Parse(tN8);
                VolumeFractionFibre = Double.Parse(tN9);
                VolumeFractionMatrix = Double.Parse(tN10);
                ElasticFibre = Double.Parse(tN11);
                ElasticMatrix = Double.Parse(tN12);
                RuleofMixture = Double.Parse(tN13);
                InverseofRuleofMixture = Double.Parse(tN14);
                WeightofSingleWall = Double.Parse(tN15);

               LengthofActualFibre = Double.Parse(tN16);
               LengthofNormalizingFibre = Double.Parse(tN17);
               NormalisingStrength = Double.Parse(tN18);
               ActualStress = Double.Parse(tN19);
               WeibullModulus = Double.Parse(tN20);
               ProbabilityofFailure = Double.Parse(tN21);

            //}
            //catch { }
        }


        public MySerializableClass( )
        {

        }


    }

    
    public class DeSerializableClass
    {

        public float LengthofNanotube;
        public float RadiusofNanotube;
        public float VolumeofNanotube;
        public float LengthofComposite;
        public float WidthofNanotube;
        public float HeightofNanotube;
        public float VolumeofComposite;
        public float VolumeofMatrix;
        public float VolumeFractionFibre;
        public float VolumeFractionMatrix;
        public float ElasticFibre;
        public float ElasticMatrix;
        public float RuleofMixture;
        public float InverseofRuleofMixture;

        /*
        public DeSerializableClass(string tN1, string tN2, string tN3, string tN4, string tN5, string tN6, string tN7, string tN8, string tN9, string tN10, string tN11, string tN12, string tN13, string tN14)
        {

            try
            {
            LengthofNanotube = tN1;
            RadiusofNanotube = tN2;
            VolumeofNanotube = tN3;
            LengthofComposite =tN4;
            WidthofNanotube =tN5;
            HeightofNanotube = tN6;
            VolumeofComposite = tN7;
            VolumeofMatrix = tN8;
            VolumeFractionFibre = tN9;
            VolumeFractionMatrix = tN10;
            ElasticFibre = tN11;
            ElasticMatrix = tN12;
            RuleofMixture = tN13;
            InverseofRuleofMixture = tN14;

            }
            catch { }
        }
        

        public DeSerializableClass()
        {

            try
            {
                this.LengthofNanotube = "eed";
                this.RadiusofNanotube = "eed";
                this.VolumeofNanotube = "eed";
                this.LengthofComposite = "eed";
                this.WidthofNanotube = "eed";
                this.HeightofNanotube = "eed";
                this.VolumeofComposite = "eed";
                this.VolumeofMatrix = "eed";
                this.VolumeFractionFibre = "eed";
                this.VolumeFractionMatrix = "eed";
                this.ElasticFibre = "eed";
                this.ElasticMatrix = "eed";
                this.RuleofMixture = "eed";
                this.InverseofRuleofMixture = "eed";

            }
            catch { }

        }

        */
    }

    public class Alpha
    {

        // This method that will be called when the thread is started
        public void Beta()
        {
            /*while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }*/
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
            
            //WindowInteropHelper wih = new WindowInteropHelper(this);
            //wih.Owner = form.Handle;

            /*System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
            System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();

            // Set the text of button1 to "OK".
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


            form1.ShowDialog();*/
        }
    };


    public interface AB
    {

         //public List <string> items  //= new List<string>(); 


    }


    public partial class Window2 : Window  
    {
        int c;
        //public List<string> items = new List<string>();     
        //private Window subForm;


        public Window2()
        {
            //Thread.Sleep(5000);
            //Alpha oAlpha = new Alpha();
            //Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));
            // Start the thread
            //oThread.Start();
            //oThread.Abort();

            InitializeComponent();

            listBox1.ItemsSource = App.items;

            //this.Refresh();
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            // If there is an image and it has a location,  
            // paint it when the Form is repainted. 
            /*base.OnPaint(e);
            if (this.picture != null && this.pictureLocation != Point.Empty)
            {
                e.Graphics.DrawImage(this.picture, this.pictureLocation);
            }*/
            //this.refresh();

        }

        private void Button_Clicks12(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;
            
            //private ListBox ListBox1 ; 
            
            //ListBox listBox1 = new ListBox();
            //object sender1;
            //System.ComponentModel.CancelEventArgs e1;
            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {

                //first = Double.Parse(textBoxNamess1.Text);



                App.items.Add("Ni = " + textBoxNamess1.Text + "   " + "Li = " + textBoxNamess2.Text + "   " + "Wi = "+textBoxNamess3.Text);

                App.Ni.Add(Double.Parse(textBoxNamess1.Text));

                App.Li.Add(Double.Parse(textBoxNamess2.Text));

                App.Wi.Add(Double.Parse(textBoxNamess3.Text));

                listBox1.ItemsSource = null;
            
                listBox1.ItemsSource = App.items;

                //this.Refresh();
               
                //Window2.subForm.Refresh();

                //listBox1.Update(); 

                //this.Close();
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = 3.14 * Math.Pow(Double.Parse(textBoxNames2.Text), 2) * Double.Parse(textBoxNames1.Text); // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //s = Convert.ToString(first);
                //textBoxNames3.Text = s;
                //MessageBox.Show(Convert.ToString(first));



            }
            catch { }

        }

        private void PrintText(object sender, RoutedEventArgs e)
        {


        }


        private void Button_Clicks13(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;
            int selectedIndex ; 

            //object sender1;
            //System.ComponentModel.CancelEventArgs e1;
            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

            selectedIndex = listBox1.SelectedIndex;

            try
            {

                
                App.items.RemoveAt(selectedIndex);

                App.Ni.RemoveAt(selectedIndex);

                App.Li.RemoveAt(selectedIndex);

                App.Wi.RemoveAt(selectedIndex);
                //first = Double.Parse(textBoxNamess1.Text);
                //this.Close();
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = 3.14 * Math.Pow(Double.Parse(textBoxNames2.Text), 2) * Double.Parse(textBoxNames1.Text); // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //s = Convert.ToString(first);
                //textBoxNames3.Text = s;
                //MessageBox.Show(Convert.ToString(first));



            }
            catch { }

            //listBox1.DataSource = null;
            //listBox1.DataSource = items;
           

            listBox1.ItemsSource = null;
            listBox1.ItemsSource = App.items;


        }

        /*private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();7
        }*/

        /*public void Close()
        {
            //this.Closing -= Window_Closing;
            //Add closing logic here.
            base.Close();
        }*/


        private void Button_Clicks14(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            this.Close(); // closes the button 
        }


    }



    public partial class Window3 : Window //System.Windows.Forms.Form
    {
        int c;
        
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button4;
		
        public Window3()
        {
            //Thread.Sleep(5000);
            //Alpha oAlpha = new Alpha();
            //Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));
            // Start the thread
            //oThread.Start();
            //oThread.Abort();


            InitializeComponent();



        }

        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Create the interop host control.
            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            // Create the MaskedTextBox control.
            //MaskedTextBox mtbDate = new MaskedTextBox("00/00/0000");

            // Assign the MaskedTextBox control as the host control's child.
            //host.Child = mtbDate;

            // Add the interop host control to the Grid 
            // control's collection of child controls. 
            //this.grid1.Children.Add(host);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Change Prperties Through Coding";
            this.BackColor = Color.Brown;
            this.Size = new Size(350, 125);
            this.Location = new Point(300, 300);
            this.MaximizeBox = false;
        }*/

      
    }   
 


    public partial class Window1 : Window
    {
        int c;
        public Window1()
        {
            //Thread.Sleep(5000);
            //Alpha oAlpha = new Alpha();
            //Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));
            // Start the thread
            //oThread.Start();
            //oThread.Abort();

            InitializeComponent();



        }


        private void Button_Clicks1(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                first = 3.14 * Math.Pow(Double.Parse(textBoxNames2.Text), 2) * Double.Parse(textBoxNames1.Text); // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxNames3.Text = s;
            }
            catch { }

        }

        private void Button_Clicks2(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                if ( (Double.Parse(textBoxNames4.Text) == 1) & (Double.Parse(textBoxNames5.Text) == 1) & (Double.Parse(textBoxNames6.Text) ==1) )
                {

                  first = Double.Parse(textBoxNames1.Text) * 4*Double.Parse(textBoxNames2.Text) * Double.Parse(textBoxNames2.Text);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                  s = Convert.ToString(first);
                  textBoxNames7.Text = s;

                }
                else 
                {
                  first = Double.Parse(textBoxNames4.Text) * Double.Parse(textBoxNames5.Text) * Double.Parse(textBoxNames6.Text);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                  s = Convert.ToString(first);
                  textBoxNames7.Text = s;
                }

            }
            catch { }

        }

        private void Button_Clicks3(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                
                    first = Double.Parse(textBoxNames7.Text) - Double.Parse(textBoxNames3.Text) ;  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                    
                    s = Convert.ToString(first);
                    textBoxNames8.Text = s;
                                

            }
            catch { }

        }


        private void Button_Clicks4(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


                first = Double.Parse(textBoxNames3.Text) / (Double.Parse(textBoxNames3.Text) + Double.Parse(textBoxNames8.Text) );  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxNames9.Text = s;

                first = Double.Parse(textBoxNames8.Text) / (Double.Parse(textBoxNames3.Text) + Double.Parse(textBoxNames8.Text));  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxNames10.Text = s;

            }
            catch { }

        }


        private void Button_Clicks5(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


                first = Double.Parse(textBoxNames9.Text) * Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) * Double.Parse(textBoxNames12.Text);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxNames13.Text = s;

                

            }
            catch { }

        }



        private void Button_Clicks6(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


                first =   Math.Pow( ( Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text) ),-1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxNames14.Text = s;



            }
            catch { }

        }

        private void Button_Clicks7(object sender, RoutedEventArgs e)
        {
            //float a;
            double first = 0.0, second = 0.0, final= 0.0, third = 0.0 , final2 = 0.0 , fifth = 0.0;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                for (int i = 0; i < App.Li.Count; i++)
                {

                    first = first + App.Ni.ElementAt(i)*App.Li.ElementAt(i);
                }
                

                  for (int i = 0; i < App.Ni.Count; i++)
                  {

                      second = second + App.Ni.ElementAt(i);
                   }

                  for (int i = 0; i < App.Wi.Count; i++)
                  {

                      third = third + App.Ni.ElementAt(i) * App.Wi.ElementAt(i);
                  }

                  for (int i = 0; i < App.Wi.Count; i++)
                  {

                      fifth = fifth + App.Wi.ElementAt(i) ;
                  }


                   final = first/second;

                   final2 = third / fifth;

                  // first = 1.0;

                   //final = 24;    

                  textBoxNames16.Text = Convert.ToString(final);

                  textBoxNames18.Text = Convert.ToString(final2);
                   //MessageBox.Show(Convert.ToString(first));
                   //App.Ni.Add(Double.Parse(textBoxNamess1.Text));
                   //App.Li.A
                //Double.Parse(textBoxName15.Text); 

                //first = Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                //s = Convert.ToString(first);
                //textBoxNames14.Text = s;



            }
            catch { }

        }

        private void Button_Clicks8(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                first = (1.0 / 1315.0) * (3.14 * 2 * Double.Parse(textBoxNames1.Text) * Double.Parse(textBoxNames2.Text));

                //first = Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                s = Convert.ToString(first);
                textBoxNames17.Text = s;



            }
            catch { }

        }

        private void Button_Clicks9(object sender, RoutedEventArgs e)
        {
            //float a;
            double first;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


                //first = Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                //s = Convert.ToString(first);
                //textBoxNames14.Text = s;



            }
            catch { }

        }


        private void Button_Clicks10(object sender, RoutedEventArgs e)
        {
            //float a;
            double first , second , third;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


                //first = Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                //first = 1- Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                second = Math.Pow(Double.Parse(textBoxNames22.Text) / Double.Parse(textBoxNames21.Text) , Double.Parse(textBoxNames23.Text));
                third =  -Double.Parse(textBoxNames19.Text) / Double.Parse(textBoxNames20.Text);

                first = 1 - Math.Pow(2.71, third*second);

                s = Convert.ToString(first);
                textBoxNames24.Text = s;



            }
            catch { }

        }
        

        private void Button_Clicks11(object sender, RoutedEventArgs e)
        {
            //float a;
            double first, second, third;
            //int answer;
            string s;

            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
            try
            {
                //first = (3.14 / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //first = (3.14 / 2 * Math.Sqrt(3) );// *(Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                Window2 subWindow = new Window2();
                subWindow.Show();
                //first = Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));

                //first = 1- Math.Pow((Double.Parse(textBoxNames9.Text) / Double.Parse(textBoxNames11.Text) + (1 - Double.Parse(textBoxNames9.Text)) / Double.Parse(textBoxNames12.Text)), -1);  // / (2 * Math.Sqrt(3))) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));
                //second = Math.Pow(Double.Parse(textBoxNames22.Text) / Double.Parse(textBoxNames21.Text), Double.Parse(textBoxNames23.Text));
                //third = -Double.Parse(textBoxNames19.Text) / Double.Parse(textBoxNames20.Text);

                //first = 1 - Math.Pow(2.71, third * second);

                //s = Convert.ToString(first);
                //textBoxNames24.Text = s;



            }
            catch { }

        }



        private void TextBoxs_TextChanged_1(object sender, TextChangedEventArgs e)
        {

            try
            {
                textBoxNames4.Text = textBoxNames1.Text;
                //this.TextBox_TextChanged = TextBox.Text ;//= "eee";
            }
            catch { }
        }


        private void TextBoxs_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            try
            {
                textBoxNames5.Text = Convert.ToString(2 * Double.Parse(textBoxNames2.Text));
                textBoxNames6.Text = Convert.ToString(2 * Double.Parse(textBoxNames2.Text));
            }
            catch { }

            //this.TextBox_TextChanged = TextBox.Text ;//= "eee";
        }

        

        private void TextBoxs_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Double.Parse(textBoxNames4.Text) < Double.Parse(textBoxNames1.Text))
                {
                    //MessageBox.Show("The Length of Composite can not be smaller than the Length of the Nano Tube");
                    textBoxNames4.Text = textBoxNames1.Text;
                }
            }
            catch { }
            //textBoxNames5.Text = Convert.ToString(2*Double.Parse(textBoxNames2.Text));
            //textBoxNames6.Text = Convert.ToString(2*Double.Parse(textBoxNames2.Text));
            //this.TextBox_TextChanged = TextBox.Text ;//= "eee";
        }

        private void TextBoxs_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Double.Parse(textBoxNames5.Text) < 2 * Double.Parse(textBoxNames2.Text))
                {
                    //MessageBox.Show("The Width of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    textBoxNames5.Text = Convert.ToString(2 * Double.Parse(textBoxNames2.Text));
                }
            }
            catch { }
            //textBoxNames5.Text = Convert.ToString(2*Double.Parse(textBoxNames2.Text));
            //textBoxNames6.Text = Convert.ToString(2*Double.Parse(textBoxNames2.Text));
            //this.TextBox_TextChanged = TextBox.Text ;//= "eee";
        }
        
        private void TextBoxs_TextChanged_5(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Double.Parse(textBoxNames6.Text) < 2 * Double.Parse(textBoxNames2.Text))
                {
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    textBoxNames6.Text = Convert.ToString(2 * Double.Parse(textBoxNames2.Text));
                }
            }
            catch { }
            //textBoxNames5.Text = Convert.ToString(2*Double.Parse(textBoxNames2.Text));
            //textBoxNames6.Text = Convert.ToString(2*Double.Parse(textBoxNames2.Text));
            //this.TextBox_TextChanged = TextBox.Text ;//= "eee";
        }


        private void Save_Database_File_Nanotube_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");

            try
            {

                //MySerializableClass obj = new MySerializableClass(textBoxNames1.Text, textBoxNames2.Text, textBoxNames3.Text, textBoxNames4.Text, textBoxNames5.Text, textBoxNames6.Text, textBoxNames7.Text, textBoxNames8.Text, textBoxNames9.Text, textBoxNames10.Text, textBoxNames11.Text, textBoxNames12.Text, textBoxNames13.Text, textBoxNames14.Text, textBoxNames17.Text, textBoxNames19.Text, textBoxNames20.Text, textBoxNames21.Text, textBoxNames22.Text, textBoxNames23.Text, textBoxNames24.Text);

                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                //XmlSerializer mySerializer = new XmlSerializer(typeof(MySerializableClass));

                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                //dlg.FileName = "Document"; // Default file name
                //dlg.DefaultExt = ".text"; // Default file extension
                //dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
                //string fileText = "testYour output text";
                // Show save file dialog box
                //Nullable<bool> result = dlg.ShowDialog();

                dlg.FileName = "Database"; // Default file name
                dlg.DefaultExt = ".mdf"; // Default file extension
                dlg.Filter = "mdf  (.mdf)|*.mdf"; // Filter files by extension
                Nullable<bool> result = dlg.ShowDialog();
                // Process save file dialog box results
                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");

                if (result == true)
                {
                  

                         /* String str;
                          SqlConnection myConn = new SqlConnection("Server=server;Integrated security=SSPI;database=master ");

                          str = "CREATE DATABASE MyDatabase ON PRIMARY " +
                               "(NAME = MyDatabase_Data, " +
                               //"FILENAME = 'C:\\MyDatabaseData.mdf', " +
                               "FILENAME = '" +
                               dlg.FileName +
                               "', " +
                               "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                               "LOG ON (NAME = MyDatabase_Log, " +
                               "FILENAME = '" +   
                               dlg.FileName +
                               ".ldf'"   +
                               ", " +
                               "SIZE = 1MB, " +
                               "MAXSIZE = 5MB, " +
                               "FILEGROWTH = 10%)";

                                SqlCommand myCommand = new SqlCommand(str, myConn);

                           try
                           {
                                myConn.Open();
                                myCommand.ExecuteNonQuery();
                                System.Windows.MessageBox.Show("DataBase is Created Successfully");//"MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           }
                           catch (System.Exception ex)
                           {
                               //MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               DumpException(ex);
                               System.Windows.MessageBox.Show(str);
                           }
                           finally
                           {
                               //if (myConn.State == ConnectionState.Open)
                               //{
                               myConn.Close();
                               //}
                           }
		                */       

                    // Save document
                    //string filename = dlg.FileName;
                    //File.WriteAllText(dlg.FileName, fileText);

                    // To write to a file, create a StreamWriter object.
                    //StreamWriter myWriter = new StreamWriter(dlg.FileName);
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    //XmlSerializer mySerializer = new XmlSerializer(typeof(MySerializableClass));
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    //mySerializer.Serialize(myWriter, obj);
                    //myWriter.Close();

                }

            }
            catch (Exception ex)
            {
                DumpException(ex);
            }
 

         }


        private void Save_XML_File_Nanotube_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");

            /*string fileText = "Your output text";

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }*/

            try
            {
                //Console.WriteLine("error");


                MySerializableClass obj = new MySerializableClass(textBoxNames1.Text, textBoxNames2.Text, textBoxNames3.Text, textBoxNames4.Text, textBoxNames5.Text, textBoxNames6.Text, textBoxNames7.Text, textBoxNames8.Text, textBoxNames9.Text, textBoxNames10.Text, textBoxNames11.Text, textBoxNames12.Text, textBoxNames13.Text, textBoxNames14.Text, textBoxNames17.Text, textBoxNames19.Text, textBoxNames20.Text, textBoxNames21.Text, textBoxNames22.Text, textBoxNames23.Text, textBoxNames24.Text);
            
                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                //XmlSerializer mySerializer = new XmlSerializer(typeof(MySerializableClass));
                


                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                //dlg.FileName = "Document"; // Default file name
                //dlg.DefaultExt = ".text"; // Default file extension
                //dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
                //string fileText = "testYour output text";
                // Show save file dialog box
                //Nullable<bool> result = dlg.ShowDialog();

                dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".XML"; // Default file extension
                dlg.Filter = "XML documents (.xml)|*.xml"; // Filter files by extension
                Nullable<bool> result = dlg.ShowDialog();
                // Process save file dialog box results
                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                
                if (result == true)
                {
                    // Save document
                    //string filename = dlg.FileName;
                    //File.WriteAllText(dlg.FileName, fileText);

                    // To write to a file, create a StreamWriter object.
                    StreamWriter myWriter = new StreamWriter(dlg.FileName);
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    XmlSerializer mySerializer = new XmlSerializer(typeof(MySerializableClass));
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    mySerializer.Serialize(myWriter, obj);
                    myWriter.Close();
                }

            }
            catch (Exception ex) {
                DumpException(ex);
            }

        }




        private void Open_XML_File_Nanotube_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");

            /*string fileText = "Your output text";

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }*/
           
            try
            {
                //Console.WriteLine("error");


                MySerializableClass obj = new MySerializableClass() ; //= new MySerializableClass(textBoxNames1.Text, textBoxNames2.Text, textBoxNames3.Text, textBoxNames4.Text, textBoxNames5.Text, textBoxNames6.Text, textBoxNames7.Text, textBoxNames8.Text, textBoxNames9.Text, textBoxNames10.Text, textBoxNames11.Text, textBoxNames12.Text, textBoxNames13.Text, textBoxNames14.Text);
                 
                
                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                //XmlSerializer mySerializer = new XmlSerializer(typeof(MySerializableClass));



                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                //dlg.FileName = "Document"; // Default file name
                //dlg.DefaultExt = ".text"; // Default file extension
                //dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
                //string fileText = "testYour output text";
                // Show save file dialog box
                //Nullable<bool> result = dlg.ShowDialog();

                //dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".XML"; // Default file extension
                dlg.Filter = "XML documents (.xml)|*.xml"; // Filter files by extension
                Nullable<bool> result = dlg.ShowDialog();
                // Process save file dialog box results
                //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
               
                if (result == true)
                {
                    // Save document
                    //string filename = dlg.FileName;
                    //File.WriteAllText(dlg.FileName, fileText);

                    // To write to a file, create a StreamWriter object.
                    FileStream myFileStream = new FileStream(dlg.FileName, FileMode.Open);

                    XmlReader reader = XmlReader.Create(myFileStream);

                    //MessageBox.Show(dlg.FileName);
                    //StreamWriter myWriter = new StreamWriter(dlg.FileName);
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");
                    XmlSerializer mySerializer = new XmlSerializer(typeof(MySerializableClass));
                    
                    //MessageBox.Show("The Height of Composite can not be smaller than 2 times the Radius of the Nano Tube");

                    try
                    {
                        MySerializableClass obj1; 
                        obj1 = (MySerializableClass)mySerializer.Deserialize(reader);

                        
                        textBoxNames1.Text = Convert.ToString(obj1.LengthofNanotube);
                        textBoxNames2.Text = Convert.ToString(obj1.RadiusofNanotube);
                        textBoxNames3.Text = Convert.ToString(obj1.VolumeofNanotube);
                        textBoxNames4.Text = Convert.ToString(obj1.LengthofNanotube);
                        textBoxNames5.Text = Convert.ToString(obj1.WidthofNanotube);
                        textBoxNames6.Text = Convert.ToString(obj1.HeightofNanotube);
                        textBoxNames7.Text = Convert.ToString(obj1.VolumeofComposite);

                        textBoxNames8.Text = Convert.ToString(obj1.VolumeofMatrix);
                        textBoxNames9.Text = Convert.ToString(obj1.VolumeFractionFibre);
                        textBoxNames10.Text = Convert.ToString(obj1.VolumeFractionMatrix);
                        textBoxNames11.Text = Convert.ToString(obj1.ElasticFibre);
                        textBoxNames12.Text = Convert.ToString(obj1.ElasticMatrix);
                        textBoxNames13.Text = Convert.ToString(obj1.RuleofMixture);
                        textBoxNames14.Text = Convert.ToString(obj1.InverseofRuleofMixture);

                        textBoxNames17.Text = Convert.ToString(obj1.WeightofSingleWall);


                        textBoxNames19.Text =Convert.ToString(obj1.LengthofActualFibre) ;
                        textBoxNames20.Text =Convert.ToString(obj1.LengthofNormalizingFibre);
                        textBoxNames21.Text =Convert.ToString(obj1.NormalisingStrength) ;
                        textBoxNames22.Text =Convert.ToString(obj1.ActualStress);
                        textBoxNames23.Text =Convert.ToString(obj1.WeibullModulus);
                        textBoxNames24.Text = Convert.ToString(obj1.ProbabilityofFailure);


                        myFileStream.Close();

                        //obj = (Nanotubes.DeSerializableClass) mySerializer.Deserialize(myFileStream);

                        //MessageBox.Show(dlg.FileName);
                   
                    }
                    catch (Exception ex) {
                        DumpException(ex);
                    }


                    //mySerializer.Serialize(myWriter, obj);
                    //myWriter.Close();
                }

            }
            catch (Exception ex)
            {
                DumpException(ex);
            }
           
        }



        private void Button_Clicks20(object sender, RoutedEventArgs e)
        {
            //float a;
            double first, second, third;
            //int answer;
            string s;
            int selectedIndex;

            //object sender1;
            //System.ComponentModel.CancelEventArgs e1;
            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));



            try
            {

                if (Double.Parse(textBoxNames30.Text) >= Double.Parse(textBoxNames31.Text))
                {
                    second = (Double.Parse(textBoxNames33.Text) / Double.Parse(textBoxNames32.Text)) * Math.Pow(((Double.Parse(textBoxNames30.Text) - Double.Parse(textBoxNames31.Text)) / Double.Parse(textBoxNames32.Text)), (Double.Parse(textBoxNames33.Text) - 1));
                    third = Math.Pow(2.71, Math.Pow((-1) * ((Double.Parse(textBoxNames30.Text) - Double.Parse(textBoxNames31.Text)) / Double.Parse(textBoxNames32.Text)), (Double.Parse(textBoxNames33.Text))));
                    first = second * third;
                    s = Convert.ToString(first);
                    textBoxNames34.Text = s;
                }
                else
                {

                    s = "0";
                    textBoxNames34.Text = s;
                }


            }
            catch { }

            
        }

        private void Button_Clicks51(object sender, RoutedEventArgs e)
        {

            double first, second, third = 0;
            //int answer;
            string s;
            int selectedIndex;

            //object sender1;
            //System.ComponentModel.CancelEventArgs e1;
            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


            try
            {

               // Window3 subWindow = new Window3();
               // subWindow.Show();

                Alpha oAlpha = new Alpha();
                Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));
                // Start the thread
                oThread.Start();

                //Form form = new Form();
                //WindowInteropHelper wih = new WindowInteropHelper(this);
                //wih.Owner = form.Handle;
                //form.ShowDialog();

                //var activationContext = Type.GetTypeFromProgID("matlab.application.single");
                //var matlab = (MLApp.MLApp)Activator.CreateInstance(activationContext);
                //matlab.Execute("1+2");
                //Console.WriteLine(matlab.Execute("1+2"));
                //Console.ReadKey();

            }
            catch { }
        }


        private void Button_Clicks41(object sender, RoutedEventArgs e)
        {
            //float a;
            double first, second, third = 0;
            //int answer;
            string s;
            int selectedIndex;

            //object sender1;
            //System.ComponentModel.CancelEventArgs e1;
            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


            try
            {

                //var activationContext = Type.GetTypeFromProgID("matlab.application.single");
                //var matlab = (MLApp.MLApp) Activator.CreateInstance(activationContext);
                //matlab.Execute("1+2");
                
                //Console.WriteLine(matlab.Execute("1+2"));
                //Console.ReadKey();

            }
            catch { }


        }


        private void Button_Clicks40(object sender, RoutedEventArgs e)
        {
            //float a;
            double first, second, third = 0;
            //int answer;
            string s;
            int selectedIndex;

            //object sender1;
            //System.ComponentModel.CancelEventArgs e1;
            //first = (3.14 / 4) * (Math.Pow(Double.Parse(textBoxName2.Text) / Double.Parse(textBoxName.Text), 2));


            try
            {

                // Double.Parse(textBoxName5.Text) * Double.Parse(textBoxName2.Text)
                for (int i = 0; i < Double.Parse(textBoxNames43.Text); i++)
                 {   
                   third = third + i ;
                 }

                second = 3.14 * Double.Parse(textBoxNames41.Text) + 2 * Double.Parse(textBoxNames42.Text) * third;
                
                first = (1.0 / 1315.0) * (3.14  * Double.Parse(textBoxNames40.Text) * second );

                s = Convert.ToString(first);

                textBoxNames44.Text = s;
                               

            }
            catch { }


        }


        public static void DumpException(Exception ex)
        {
            Console.WriteLine("--------- Outer Exception Data ---------");
            WriteExceptionInfo(ex);
            ex = ex.InnerException;
            if (null != ex)
            {
                Console.WriteLine("--------- Inner Exception Data ---------");
                WriteExceptionInfo(ex.InnerException);
                ex = ex.InnerException;
            }
        }

        public static void WriteExceptionInfo(Exception ex)
        {
            Console.WriteLine("Message: {0}", ex.Message);
            Console.WriteLine("Exception Type: {0}", ex.GetType().FullName);
            Console.WriteLine("Source: {0}", ex.Source);
            Console.WriteLine("StrackTrace: {0}", ex.StackTrace);
            Console.WriteLine("TargetSite: {0}", ex.TargetSite);
        }



    }//public partial class Window1 : Window     


}//namespace
