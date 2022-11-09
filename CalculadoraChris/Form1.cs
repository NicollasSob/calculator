using System.Globalization;

namespace CalculadoraChris
{
    public partial class FrmCalculator : Form
    {
        decimal numberOne, numberTwo;
        string operation;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numberTwo = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            lblTextResult.Text += numberTwo + " = ";
            decimal result = 0;
            switch(operation)
            {
                case "sum":
                    result = numberOne + numberTwo;
                    break;
                case "sub":
                    result = numberOne - numberTwo;
                    break;
                case "mult":
                    result = numberOne * numberTwo;
                    break;
                case "div":
                    if(numberTwo == 0)
                    {
                        txtResult.Text = "Não é posivel dividir por zero";
                        return;
                    }
                    break;
                case "rest":
                    result = numberOne % numberTwo;
                    break;
            }

            txtResult.Text = result.ToString();
            lblTextResult.Text += result.ToString();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digiter um número");
                txtResult.Focus();
            }

            operation = "sum";
            lblTextResult.Text = txtResult.Text + " + ";

            txtResult.Clear();
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digiter um número");
                txtResult.Focus();
            }

            operation = "sub";
            lblTextResult.Text = txtResult.Text + " - ";

            txtResult.Clear();
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digiter um número");
                txtResult.Focus();
            }

            operation = "mult";
            lblTextResult.Text = txtResult.Text + " * ";

            txtResult.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digiter um número");
                txtResult.Focus();
            }

            operation = "div";
            lblTextResult.Text = txtResult.Text + " / ";

            txtResult.Clear();
        }

        private void rest_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digiter um número");
                txtResult.Focus();
            }

            operation = "rest";
            lblTextResult.Text = txtResult.Text + " % ";

            txtResult.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblTextResult.Text = "Nossa Calculadora";
        }
    }
}