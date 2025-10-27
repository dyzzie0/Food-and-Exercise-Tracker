using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Assignment_Project1
{
    public partial class LogWeight : Form
    {
        private const string weightLogFile = "weightlog.txt";
        private string inputUnit = "kg";//kg is set as the defualt 
        private string outputUnit = "kg";//kg is set as the default

        public LogWeight()
        {
            InitializeComponent();
            pnlConvert.Visible = false;//initially the conversion table is hidden until user presses no
        }

        public void LoadData()
        {
            if (File.Exists(weightLogFile))
            {
                txtWeightLog.Text = File.ReadAllText(weightLogFile);
                lblMessage.Text = "Weight log loaded successfully.";
            }
            else
            {
                lblMessage.Text = "No weight log file found.";
            }
        }
        //adding data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWeight.Text == "" || !double.TryParse(txtWeight.Text, out double weight))
            {
                lblMessage.Text = "Please enter a valid weight.";
                return;
            }

            double convertedWeight = ConvertedWeight(weight, inputUnit, "kg");
            string date = dateTimePicker.Value.ToShortDateString();
            string[] lines = File.ReadAllLines(weightLogFile);
            bool entryExists = false;

            foreach (var line in lines)
            {
                if (line.StartsWith(date))
                {
                    entryExists = true;
                    break;
                }
            }
            if (entryExists)
            {
                lblMessage.Text = "You have already logged weight for today.";
                return;
            }

            string weightEntry = $"{date}: {convertedWeight} kg";
            txtWeightLog.AppendText(weightEntry + Environment.NewLine);
            lblMessage.Text = "Weight entry added.";
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (txtWeight.Text == "" || !double.TryParse(txtWeight.Text, out double weight))
            {
                lblMessage.Text = "Please enter a valid weight for conversion.";
                return;
            }

            double convertedWeight = ConvertedWeight(weight, inputUnit, outputUnit);
            if (convertedWeight == 0)
            {
                lblMessage.Text = "Invalid unit for conversion.";
                return;
            }

            txtConvertedWeight.Text = $"{convertedWeight} {outputUnit}";
            lblMessage.Text = "Conversion completed.";
        }
        //Conversion calculator which is hidden initaly 
        private double ConvertedWeight(double weight, string fromThis, string toThat)
        {
            if (fromThis == toThat)
            {
                return weight;
            }

            switch (fromThis)
            {
                case "lbs":
                    weight *= 0.5;
                    break;
                case "st":
                    weight *= 6.4;
                    break;
                case "kg":
                    break;
                default:
                    return 0;
            }

            switch (toThat)
            {
                case "lbs":
                    weight /= 0.5;
                    break;
                case "st":
                    weight /= 6.4;
                    break;
                case "kg":
                    break;
                default:
                    return 0;
            }

            return weight;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.AppendAllText(weightLogFile, txtWeightLog.Text);
            lblMessage.Text = "Your weight log has been saved successfully.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlConvert.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlConvert.Visible = true;
        }

        private void btnKgInput_Click(object sender, EventArgs e)
        {
            inputUnit = "kg";
        }

        private void btnLbsInput_Click(object sender, EventArgs e)
        {
            inputUnit = "lbs";
        }

        private void btnStInput_Click(object sender, EventArgs e)
        {
            inputUnit = "st";
        }

        private void btnKgOutput_Click(object sender, EventArgs e)
        {
            outputUnit = "kg";
        }

        private void btnLbsOutput_Click(object sender, EventArgs e)
        {
            outputUnit = "lbs";
        }

        private void btnStOutput_Click(object sender, EventArgs e)
        {
            outputUnit = "st";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtConvertedWeight.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeightLog.Clear();
            lblMessage.Text = "Cleared..";
        }

        private void LogWeight_Load(object sender, EventArgs e)
        {

        }
        //delete option so users can correct their data if wrong
        private void button5_Click(object sender, EventArgs e)
        {
            string dateToDelete = dateTimePicker.Value.ToShortDateString();
            string[] lines = File.ReadAllLines(weightLogFile);
            bool entryFound = false;
            var newLines = new List<string>();

            if (!File.Exists(weightLogFile))
            {
                lblMessage.Text = "No weight log found.";
                return;
            }

            if (!entryFound)
            {
                lblMessage.Text = "No weight entry found for this date, sorry.";
                return;
            }

            foreach (var line in lines)
            {
                if (line.StartsWith(dateToDelete))
                {
                    entryFound = true;
                }
                else
                {
                    newLines.Add(line);
                }
            }

            File.WriteAllLines(weightLogFile, newLines);
            lblMessage.Text = "Weight was entry deleted.";
            txtWeightLog.Text = string.Join(Environment.NewLine, newLines);
        }
    }
}