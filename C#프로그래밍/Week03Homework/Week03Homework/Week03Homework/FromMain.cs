using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Week03Homework
{
    public partial class FormMain : Form
    {
        private double beforeNumber = 0;
        private string label = null;
        private double inputNumber = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnNumer_Click(object sender, EventArgs e)
        {
            Button target = (Button) sender;
            double number = double.Parse(inputNumber + target.Text);
            lblNumbers.Text = number.ToString();
            inputNumber = number;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            double afterNumber = 0;
            if (beforeNumber == 0){
                beforeNumber = inputNumber;
            }
            switch (label)
            {
                case "÷":
                    afterNumber = beforeNumber / inputNumber;
                    break;
                case "X":
                    afterNumber = beforeNumber * inputNumber;
                    break;
                case "-":
                    afterNumber = beforeNumber - inputNumber;
                    break;
                case "+":
                    afterNumber = beforeNumber + inputNumber;
                    break;
                default:
                    afterNumber = inputNumber;
                    break;
            }
            lblExpression.Text = afterNumber + " " + target.Text + " ";
            if (target.Text == "=") {
                if (beforeNumber != 0 && inputNumber != 0){
                    lblExpression.Text = beforeNumber + " " + label + " " + inputNumber + " = " + afterNumber;
                    label = null;
                    inputNumber = afterNumber;
                }
                else{
                    MessageBox.Show("숫자를 입력해주세요");
                    return;
                }
            }else{
                inputNumber = 0;
                label = target.Text;
            }
            lblNumbers.Text = afterNumber.ToString();
            beforeNumber = afterNumber;
            //MessageBox.Show(label +"/"+ beforeNumber + "/" + inputNumber);
        }
    }
}
