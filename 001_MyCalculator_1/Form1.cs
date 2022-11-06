namespace _001_MyCalculator_1
{
    public partial class Form1 : Form
    {
        double FirstNumber = 0;
        double SecondNumber = 0;
        double Result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSecondNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

            bool isValidFirstNumber = false;
            bool isValidSecondNumber = false;
            isValidFirstNumber = Double.TryParse(txtFirstNumber.Text, out FirstNumber);
            isValidSecondNumber = Double.TryParse(txtSecondNumber.Text, out SecondNumber);
            if (isValidFirstNumber == false || isValidSecondNumber == false)
            {
                lblResult.Text = ("Please enter valid numbers");
            }
            else {

                Result = FirstNumber + SecondNumber;

                lblResult.Text = ("Addition Result is : " + Result);

            }
            lblSubtract.BackColor = Color.Transparent;
            lblMultiplication.BackColor = Color.Transparent;
            lblDivision.BackColor = Color.Transparent;
            lblAdd.BackColor = Color.LightBlue;
        }

        private void lblSubtract_Click(object sender, EventArgs e)
        {
            bool isValidFirstNumber = false;
            bool isValidSecondNumber = false;
            isValidFirstNumber = Double.TryParse(txtFirstNumber.Text, out FirstNumber);
            isValidSecondNumber = Double.TryParse(txtSecondNumber.Text, out SecondNumber);
            if (isValidFirstNumber == false || isValidSecondNumber == false)
            {
                lblResult.Text = ("Please enter valid numbers");
            }
            else
            {

                Result = FirstNumber - SecondNumber;

                lblResult.Text = ("Subtraction Result is : " + Result);

            }

            lblAdd.BackColor = Color.Transparent;
            lblMultiplication.BackColor = Color.Transparent;
            lblDivision.BackColor = Color.Transparent;
            lblSubtract.BackColor = Color.LightBlue;
        }

        private void lblMultiplication_Click(object sender, EventArgs e)
        {
            bool isValidFirstNumber = false;
            bool isValidSecondNumber = false;
            isValidFirstNumber = Double.TryParse(txtFirstNumber.Text, out FirstNumber);
            isValidSecondNumber = Double.TryParse(txtSecondNumber.Text, out SecondNumber);
            if (isValidFirstNumber == false || isValidSecondNumber == false)
            {
                lblResult.Text = ("Please enter valid numbers");
            }
            else
            {
                Result = FirstNumber * SecondNumber;

                lblResult.Text = ("Multiplication Result is : " + Result);

            }
            lblAdd.BackColor = Color.Transparent;
            lblSubtract.BackColor = Color.Transparent;           
            lblDivision.BackColor = Color.Transparent;           
            lblMultiplication.BackColor = Color.LightBlue;
        }

        private void lblDivision_Click(object sender, EventArgs e)
        {
            bool isValidFirstNumber = false;
            bool isValidSecondNumber = false;
            isValidFirstNumber = Double.TryParse(txtFirstNumber.Text, out FirstNumber);
            isValidSecondNumber = Double.TryParse(txtSecondNumber.Text, out SecondNumber);
            if (isValidFirstNumber == false || isValidSecondNumber == false)
            {
                lblResult.Text = ("Please enter valid numbers");
            }
            else
            {

                Result = FirstNumber / SecondNumber;

                lblResult.Text = ("Division Result is : " + Result);

            }
            lblAdd.BackColor = Color.Transparent;
            lblSubtract.BackColor = Color.Transparent;
            lblMultiplication.BackColor = Color.Transparent;
            lblDivision.BackColor = Color.LightBlue;
        }
    }
}