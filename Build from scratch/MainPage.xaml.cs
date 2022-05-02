using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Build_from_scratch
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            mylable.Text = "name is " + name
                + "\nx is " + x
                + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x==10)
            {
                mylable.Text = "x must be 10";
            }
            else
            {
                mylable.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int somevalue = 3;
            string name = "Bobbo Jr.";
            if ((somevalue==3)&&(name=="Joe"))
            {
                mylable.Text = "x is 3 and name is Joe";
            }
            mylable.Text = "This line runs no matter what";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            /*
            int count = 0;

            while (count<10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            mylable.Text = "The answer is " + count;
            */
            int p = 2;
            int count = 0;
            for (int q = 2; q < 32; q=q*2)
            {
                while (p<q)
                {
                    p = p * 2;
                }
                q = p - q;
                count++;
            }
            mylable.Text = count.ToString();
        }
    }
}
