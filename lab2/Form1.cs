using System.Globalization;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int RecursiveFibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void FiboCal_Click(object sender, EventArgs e)
        {
            int number = int.Parse(FiboInput.Text);
            int result = RecursiveFibonacci(number);
            lblFiboResult.Text = $"F = {result}";
        }

        public int RecursivePower(int n, int power)
        {
            {
                if (power == 0)
                    return 1;

                return n * RecursivePower(n, power - 1);
            }
        }

        private void inputx_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPowerResult_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(inputx.Text);
            int exponent = int.Parse(inputpower.Text);
            int result = RecursivePower(baseNum, exponent);
            lblPowerResult.Text = $"Result: {result}";
        }
        private void btnPowerCalculate_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(inputx.Text);
            int exponent = int.Parse(inputpower.Text);
            int result = RecursivePower(baseNum, exponent);
            lblPowerResult.Text = $"Power: {result}";
        }
    }
}


