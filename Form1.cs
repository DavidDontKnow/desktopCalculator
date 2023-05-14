namespace desktopCalculator
{
    public partial class Calculator : Form
    {

        string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
                result.Clear();


            Button btn = (Button)sender;
            result.Text = result.Text + btn.Text;

        }

        private void clearResult(object sender, EventArgs e)
        {
            result.Text = "0";
            previousValue.Clear();
        }

        public void operator_Click(object sender, EventArgs e)
        {

            Button operatorBtn = (Button)sender;
            previousValue.Text = result.Text;
            result.Clear();
            operation = operatorBtn.Text;


        }

        private void preformOperation(object sender, EventArgs e)
        {
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
            String oldString = result.Text;
            String newString = oldString.Remove(oldString.Length - 1, 1);
            result.Text = newString;
        }
    }
}