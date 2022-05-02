using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;

            //强制转换测试：错误语句已被注释
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myInt;
            //bool myBool = (bool)myInt;
            string myString = "false";
            //myBool = (bool)myString;
            //myString = (string)myInt;
            myString = myInt.ToString();
            //myBool = (bool)myByte;
            //myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt /*+ myBool*/ + myDouble + myChar;
        }
    }
}