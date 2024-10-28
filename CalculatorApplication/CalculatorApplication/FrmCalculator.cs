using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        double number1 = 0, number2 = 0;
        Formula<double> Calculation;

        public FrmCalculator()
        {
            CalculatorClass cal = new CalculatorClass();
            InitializeComponent();
            cbOperator1.Items.Add("+");
            cbOperator1.Items.Add("-");
            cbOperator1.Items.Add("*");
            cbOperator1.Items.Add("/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOperator1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtBoxInput1.Text == "")
            {
                number1 = 0;
            }
            else 
            {
                number1 = Convert.ToDouble(txtBoxInput1.Text);
            }
            if (txtBoxInput2.Text == "")
            {
                number2 = 0;
            }
            else 
            {
                number2 = Convert.ToDouble(txtBoxInput2.Text);
            }
            switch (cbOperator1.SelectedIndex) {
                case 0:
                    CalculationEvent += Calculation;
                    Calculation = new Formula<double>(CalculatorClass.getSum);
                    AnswerBox.Text = Calculation(number1, number2).ToString();
                    CalculationEvent += Calculation;
                    break;
                case 1:
                    CalculationEvent += Calculation;
                    Calculation = new Formula<double>(CalculatorClass.getDiff);
                    AnswerBox.Text = Calculation(number1, number2).ToString();
                    break;
                case 2:
                    CalculationEvent += Calculation;
                    Calculation = new Formula<double>(CalculatorClass.getProd);
                    AnswerBox.Text = Calculation(number1, number2).ToString();
                    
                    break;
                case 3:
                    CalculationEvent += Calculation;
                    Calculation = new Formula<double>(CalculatorClass.getQuot);
                    try
                    {
                        if (number1 == 0 || number2 == 0)
                        {
                            throw new DivideByZero("Division by zero");
                        }
                        else
                        {
                            AnswerBox.Text = Calculation(number1, number2).ToString();
                            
                        }
                    }
                    catch(DivideByZero dze) {
                        Debug.WriteLine(dze.ToString());
                        CalculationEvent -= Calculation;
                    }
                    break;
            }
            CalculationEvent -= Calculation;
        }
        public event Formula<double> CalculationEvent {
            add {
                Debug.WriteLine("Delegate Added");
                Calculation += value;
            }
            remove {
                Debug.WriteLine("Delegate Removed");
                Calculation += value;
            }
        }

        private double FrmCalculator_CalculationEvent(double number1, double number2)
        {
            throw new NotImplementedException();
        }
    }
}
