namespace Eichberger_Alexandra_ComplexCalculator
{
    public partial class MainView : Form
    {
        private HistoryView _history;
        private int lastNumberChanged = 2;
        public MainView()
        {
            _history = new HistoryView();
            _history.Restore += OnRestore;
            InitializeComponent();
        }

        private void OnRestore(object? sender, ComplexNumber e)
        {
            if (lastNumberChanged == 2)
            {
                txb_Number1.Text = e.ToString();
                lastNumberChanged = 1;
            }
            else
            {
                txb_Number2.Text = e.ToString();
                lastNumberChanged = 2;
            }
        }

        #region Events
        private void btn_addition_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber number1 = parseInputToComplexNumber(txb_Number1.Text);
                ComplexNumber number2 = parseInputToComplexNumber(txb_Number2.Text);
                ComplexNumber result = number1 + number2;
                txb_Result.Text = result.ToString();
                _history.AddCalulation(number1, number2, "+", result);
                lastNumberChanged = 2;
            }
            catch (FormatException)
            {
                ErrorFormat();
            }
            catch (IndexOutOfRangeException)
            {
                ErrorFormat();
            }
        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber number1 = parseInputToComplexNumber(txb_Number1.Text);
                ComplexNumber number2 = parseInputToComplexNumber(txb_Number2.Text);
                ComplexNumber result = number1 - number2;
                txb_Result.Text = result.ToString();
                _history.AddCalulation(number1, number2, "-", result);
                lastNumberChanged = 2;
            }
            catch (FormatException)
            {
                ErrorFormat();
            }
            catch (IndexOutOfRangeException)
            {
                ErrorFormat();
            }
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber number1 = parseInputToComplexNumber(txb_Number1.Text);
                ComplexNumber number2 = parseInputToComplexNumber(txb_Number2.Text);
                ComplexNumber result = number1 * number2;
                txb_Result.Text = result.ToString();
                _history.AddCalulation(number1, number2, "*", result);
                lastNumberChanged = 2;
            }
            catch (FormatException)
            {
                ErrorFormat();
            }
            catch (IndexOutOfRangeException)
            {
                ErrorFormat();
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber number1 = parseInputToComplexNumber(txb_Number1.Text);
                ComplexNumber number2 = parseInputToComplexNumber(txb_Number2.Text);
                ComplexNumber result = number1 / number2;
                txb_Result.Text = result.ToString();
                _history.AddCalulation(number1, number2, "/", result);
                lastNumberChanged = 2;
            }
            catch (FormatException)
            {
                ErrorFormat();
            }
            catch (IndexOutOfRangeException)
            {
                ErrorFormat();
            }
        }

        private void btn_ShowHistory_Click(object sender, EventArgs e)
        {
            _history.Show();
        }
        
        #endregion

        #region Methods
        private ComplexNumber parseInputToComplexNumber(string input)
        {
            string[] inputString = input.Split(' ');

            double real = double.Parse(inputString[0]);
            double im = double.Parse(inputString[2].Trim('i','j'));

            if (inputString[1] == "-")
            {
                im *= -1;
            }

            return new ComplexNumber(real, im);
        }
        #endregion

        #region ErrorMessages
        private void ErrorFormat()
        {
            MessageBox.Show("Bitte gib eine Imaginäre Zahl in der Form a + ib ein. Auch Leerzeichen beachten!", "Falscher Datentyp!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}