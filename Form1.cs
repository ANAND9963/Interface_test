namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputePayBenifts_Click(object sender, EventArgs e)
        {
            double hoursWorked = double.Parse(txtHoursWorked.Text);
            double payRate = double.Parse(txtPayRate.Text);
            string dept =txtDepartment.Text;
            int yearsWorked = int.Parse(txtYearsWorked.Text);
            double overtimeRate =double.Parse(txtOverTimeRate.Text);
            Employee emp = new Employee();
            emp.HoursWorked = hoursWorked;
            emp.PayRate = payRate;
            double pay = emp.ComputePay(overtimeRate);
            double bonus = emp.ComputeBonus(yearsWorked, dept);
            MessageBox.Show("Pay =" + pay.ToString() + "\n" + "Bonus =" + bonus.ToString());
        }
    }
}
