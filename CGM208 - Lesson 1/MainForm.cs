using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGM208___Lesson_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        void btnCalculate_Click(object sender, EventArgs e)
        {
            var textResultFormat = "Result : {0}";

            var numA = 0;
            var numB = 0;

            var isCanParseA = int.TryParse(txtNumA.Text, out numA);
            var isCanParseB = int.TryParse(txtNumB.Text, out numB);

            if (isCanParseA && isCanParseB) {
                var result = Sum(numA, numB);
                var resultText = string.Format(textResultFormat, result);
                MessageBox.Show(resultText);
            }
            else {
                MessageBox.Show("Please enter only number..");
                ClearTextBox();
            }
        }

        int Sum(int numA, int numB)
        {
            return numA + numB;
        }

        void ClearTextBox()
        {
            txtNumA.Text = "0";
            txtNumB.Text = "0";
        }
    }
}
