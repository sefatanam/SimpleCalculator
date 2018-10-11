using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorDesignUi
{
    public partial class DisplayTextbox : Form
    {
        double FirstNumber;
       // double SecondNumber;
        string Operation;
        public DisplayTextbox()
        {
            InitializeComponent();
        }

        private void CeButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            displayLabel.Text = string.Empty;
        }
        string oneButtonValue = "";
        private void OneButton_Click(object sender, EventArgs e)
        {
            oneButtonValue = 1.ToString();
            resultTextBox.Text += oneButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string twoButtonValue = "";
        private void TwoButton_Click(object sender, EventArgs e)
        {

            twoButtonValue = 2.ToString();
            resultTextBox.Text += twoButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }

        
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultTextBox.Text);
            displayLabel.Text += " X ";
            resultTextBox.Text = "";
            displayLabel.Text += resultTextBox.Text;
            Operation = "*";
            
        }


        
        private void EqualButton_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(resultTextBox.Text);

            if (Operation=="*")
            {

                Result=((FirstNumber)*(SecondNumber));
                resultTextBox.Text = Result.ToString();
                FirstNumber = Result;
                
                
            }

            if(Operation=="/")
            {
                if (SecondNumber==0)
                {
                    MessageBox.Show("Cannot Divided by Zero !");
                }else
                {
                    Result = ((FirstNumber) / (SecondNumber));
                    resultTextBox.Text = Result.ToString();
                    FirstNumber = Result;
                }
            }

            if (Operation=="+")
            {
                Result = ((FirstNumber) + (SecondNumber));
                resultTextBox.Text = Result.ToString();
                FirstNumber = Result;
            }
            if(Operation=="-")
            {
                Result = ((FirstNumber) - (SecondNumber));
                resultTextBox.Text = Result.ToString();
                FirstNumber = Result;
            }
   

            
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
        }

        private void DisplayLabel_Click(object sender, EventArgs e)
        {
            displayLabel.Text+= resultTextBox.Text;


        }

        string SevenButtonValue = "";
        private void SevenButton_Click(object sender, EventArgs e)
        {
            SevenButtonValue = 7.ToString();
            resultTextBox.Text += SevenButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string EightButtonValue = "";
        private void EightButton_Click(object sender, EventArgs e)
        {
            EightButtonValue = 8.ToString();
            resultTextBox.Text += EightButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string NineButtonValue = "";
        private void NineButton_Click(object sender, EventArgs e)
        {
            NineButtonValue = 9.ToString();
            resultTextBox.Text += NineButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string FourButtonValue="";
        private void FourButton_Click(object sender, EventArgs e)
        {
            FourButtonValue = 4.ToString();
            resultTextBox.Text += FourButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string FiveButtonValue = "";
        private void FiveButton_Click(object sender, EventArgs e)
        {
            FiveButtonValue = 5.ToString();
            resultTextBox.Text += FiveButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string SixButtonValue = "";
        private void SixButton_Click(object sender, EventArgs e)
        {
            SixButtonValue = 6.ToString();
            resultTextBox.Text += SixButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string ThreeButtonValue = "";
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            ThreeButtonValue = 3.ToString();
            resultTextBox.Text += ThreeButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }
        string ZeroButtonValue = "";
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ZeroButtonValue = 0.ToString();
            resultTextBox.Text += ZeroButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "";
            displayLabel.Text += " + ";
            Operation = "+";
            

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "";
            displayLabel.Text += " - ";
            Operation = "-";
        }

        private void DividedButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "";
            displayLabel.Text += " ÷ ";
            Operation = "/";
        }

        string PointButtonValue = "";
        private void PointButton_Click(object sender, EventArgs e)
        {
            PointButtonValue = ".".ToString();
            resultTextBox.Text +=PointButtonValue.ToString();
            displayLabel.Text = resultTextBox.Text;
        }

        private void DisplayTextbox_Load(object sender, EventArgs e)
        {

        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}
