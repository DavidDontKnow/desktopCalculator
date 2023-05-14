namespace desktopCalculator
{
    public partial class Calculator : Form
    {
        // sets operation to be uses by preformOperation
        string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }


        
        private void button_Click(object sender, EventArgs e)
        {
            //clears out 0 when user clicks btn
            if (result.Text == "0")
                result.Clear();

            //takes btn obj and converts to Button to read property of what btn was clicked
            Button btn = (Button)sender;
            //uses results btn text prop to update based on buton passed in 
            result.Text = result.Text + btn.Text;

        }

        private void clearResult(object sender, EventArgs e)
        {
            //prints 0 on results feild 
            result.Text = "0";
            //clears out previousValue to empty string
            previousValue.Clear();
        }

        public void operator_Click(object sender, EventArgs e)
        {
            //converts obj btn to btn to read operator 
            Button operatorBtn = (Button)sender;
            //sets result.text to previous value 
            previousValue.Text = result.Text;
            //clears resut
            result.Clear();
            //saves operatior to be used in preformOperation()
            operation = operatorBtn.Text;


        }

        private void preformOperation(object sender, EventArgs e)
        {
            // switch to run arithmatic depedenet on operation passed from operator_Click()
            switch (operation)
            {
                case "+":
                    result.Text = (Double.Parse(previousValue.Text) + Double.Parse(result.Text)).ToString();
                    previousValue.Clear();
                    break;
                case "-":
                    result.Text = (Double.Parse(previousValue.Text) - Double.Parse(result.Text)).ToString();
                    previousValue.Clear();
                    break;
                case "x":
                    result.Text = (Double.Parse(previousValue.Text) * Double.Parse(result.Text)).ToString();
                    previousValue.Clear();
                    break;
                case "÷":
                    result.Text = (Double.Parse(previousValue.Text) / Double.Parse(result.Text)).ToString();
                    previousValue.Clear();
                    break;
                default:
                    break;

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //sets old string from results.text to the reove last character 
            String oldString = result.Text;
            //sets new string to be altered old string
            String newString = oldString.Remove(oldString.Length - 1, 1);
            //sets results to newString val
            result.Text = newString;
        }
    }
}