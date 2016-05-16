using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicButtonCalculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display messagebox showing programer and what the program does
            MessageBox.Show("Matthew Vaughan\n\nPlace a number in each textbox\nThen click on which button suits\nthe appropriate calculation");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the application when clicked
            this.Close();
        }

        /// <summary>
        /// Add Button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Display the answer of the method called with the parameters passed through it
            txtAnswer.Text = ($"{Add(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))}");
        }

        /// <summary>
        /// Subtract Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //Display the answer of the method called with the parameters passed through it
            txtAnswer.Text = ($"{Subtract(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))}");
        }

        /// <summary>
        /// Multiply Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Display the answer of the method called with the parameters passed through it
            txtAnswer.Text = ($"{Multiply(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))}");
        }

        /// <summary>
        /// Divide Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Display the answer of the method called with the parameters passed through it
            txtAnswer.Text = ($"{Divide(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))}");
        }

        /// <summary>
        /// Add Method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static public double Add(double num1, double num2)
        {
            //return the sum
            return num1 + num2;
        }

        /// <summary>
        /// Subtract method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static public double Subtract(double num1, double num2)
        {
            //Return the difference
            return num1 - num2;
        }

        /// <summary>
        /// Multiply Method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static public double Multiply(double num1, double num2)
        {
            //Return the product
            return num1 * num2;
        }

        /// <summary>
        /// Divide method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static public double Divide(double num1, double num2)
        {
            //Return the quotient
            return num1 / num2;
        }

        /// <summary>
        /// Reset Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset all of the text boxes
            txtAnswer.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}
