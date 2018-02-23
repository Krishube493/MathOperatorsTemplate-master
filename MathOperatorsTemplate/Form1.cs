/* date: September 2012
 * author: Mr. T.
 * purpose: template created to demonstrate math operations
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathOperatorsTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            // Variable Declarations
            double numberOne, numberTwo, numberThree;
            double sum, difference, product, quotient;
            const double PRICE = 11.2;

            //Variable Assignment
            numberOne = 30;
            numberTwo = 5.17;
            numberThree = 2.11;

            //Calculation and output lines
            outputLabel.Text = "First Number: " + numberOne + "  Second Number:  " + numberTwo + "  Third Number: " + numberThree + "\n\n";

            //Sum
            sum = numberOne + numberTwo;
            outputLabel.Text += "\n The sum of numberOne + numberTwo is = " + sum;

            //Diffrence
            difference = numberOne - numberTwo;
            outputLabel.Text += "\n The Diffrence of numberOne - numberTwo is = " + difference;
            
            //Product
            product = numberOne * numberTwo;
            outputLabel.Text += "\n The Product of numberOne * numberTwo is = " + product;

            //Quotient 
            quotient = numberOne - numberTwo;
            outputLabel.Text += "\n The Quotient of numberOne - numberTwo is = " + quotient;

            //Add or subtract one.... FIX THIS
            numberOne++;
            outputLabel.Text += "\nNumberOne incremented is:" + numberOne;

            numberOne--;
            numberOne--;
            outputLabel.Text += "\nnumberone decremented is:" + numberOne;
        }
    }
}
