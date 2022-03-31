namespace CIS_161_Lab_3._2_Kelley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal federalRate = Convert.ToDecimal(".15");
            decimal stateRate = Convert.ToDecimal(".05");
            decimal hourPay = Convert.ToDecimal( hourPayBox.Text);
            decimal hoursWorked = Convert.ToDecimal(weeklyPayBox.Text);
            decimal grossPay = hourPay * hoursWorked;
            decimal federalTax = grossPay * federalRate;
            decimal stateTax = grossPay * stateRate;
            decimal netPay = grossPay - federalTax - stateTax;
            gross.Text = "$" + grossPay.ToString("0.00");
            federal.Text = "$" + federalTax.ToString("0.00");
            state.Text = "$" + stateTax.ToString("0.00");
            net.Text = "$" + netPay.ToString("0.00");

            
        }

        private void gross_Click(object sender, EventArgs e)
        {

        }

        private void weeklyPayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}