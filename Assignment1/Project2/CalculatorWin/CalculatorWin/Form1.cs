namespace CalculatorWin
{
    public partial class Form1 : Form
    {
        double num1, num2, ans;
        string op = "";
        bool ena1 = false, ena2 = false, ena3 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNum1.Text))
            {
                return;
            }
            ena1 = Double.TryParse(tbNum1.Text, out num1);
        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNum2.Text))
            {
                return;
            }
            ena2 = Double.TryParse(tbNum2.Text, out num2);
        }

        private void cbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = cbOp.Text;
            ena3 = true;
            switch (op)
            {
                case "+": ans = num1 + num2; break;
                case "-": ans = num1 - num2; break;
                case "*": ans = num1 * num2; break;
                case "/": ans = num1 / num2; break;
                default: ena3 = false; break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ena1 && ena2 && ena3)
            {
                lblAns.Text = ans + "";
            }
            else
            {
                lblAns.Text = "";
            }
        }
    }
}