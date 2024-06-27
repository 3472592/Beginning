using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ch2App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Vova";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name +
                "\nx is " + x + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string Name = "Vova";
            int DateBirth = 13;
            string MonthBirth = "January";
            int YearBirth = 2004;
            if (Name == "Vova" && DateBirth == 12 
                && MonthBirth == "January"
                && YearBirth == 2004)
            {
                myLabel.Text = "Thats Him";
            } else
            {
                myLabel.Text = "Thats not Him";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int id = 42069;
            string personName = "Vova";
            if ((id == 42069) && (personName == "Vova"))
            {
                myLabel.Text = "Hello " + personName;
            } else
            {
                myLabel.Text = "You are not " + personName;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int c = 0;

            while (c < 10)
            {
                c++;
            }
            myLabel.Text = "The answer is " + c.ToString();
        }
    }
}
