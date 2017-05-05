using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nanotubes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public static items; //variable in App.xaml.cs 
        public static List<string> items  = new List<string>();

        public static List<double> Ni = new List<double>();
        public static List<double> Li = new List<double>();
        public static List<double> Wi = new List<double>();


        public void Application_Startup(object sender, StartupEventArgs e)
        {

           // Window2.listBox1.Refresh(); 

         
        }


    }
}
