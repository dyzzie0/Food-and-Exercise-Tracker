using System;
using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_Project1
{
    public partial class WaterIntake : Form
    {
        private const string waterLogFile = "waterlog.txt";

        public WaterIntake()
        {
            InitializeComponent();
        }
        //Loading up water data
        public void LoadData()
        {
            if (File.Exists(waterLogFile))
            {
                txtWaterLog.Text = File.ReadAllText(waterLogFile);
                lblWaterMssg.Text = "Water intake loaded successfully.";
            }
            else
            {
                lblWaterMssg.Text = "No water log file found.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.AppendAllText(waterLogFile, txtWaterLog.Text);
            lblWaterMssg.Text = "Data saved successfully.";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWater.Text == "")
            {
                lblWaterMssg.Text = "Please enter the amount of water consumed.";
                return;
            }

            string waterInput = txtWater.Text;
            if (!int.TryParse(waterInput, out int waterAmount))
            {
                lblWaterMssg.Text = "Please enter a valid number for water consumed.";
                return;
            }
            //conversion checker
            string waterUnit = "ml";

            if (waterAmount >= 1000)
            {
                waterAmount = waterAmount / 1000;
                waterUnit = "l";
            }
            //displaying data added
            string date = dateTimePicker.Value.ToShortDateString();
            string logEntry = $"{date}: {waterAmount} {waterUnit}";
            txtWaterLog.AppendText(logEntry + Environment.NewLine);
            lblWaterMssg.Text = "Water intake logged successfully.";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWaterLog.Clear();
            lblWaterMssg.Text = "Log cleared.";
        }

        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void WaterIntake_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string dateToDelete = dateTimePicker.Value.ToShortDateString();
            string[] lines = File.ReadAllLines(waterLogFile);
            bool entryFound = false;
            var newLines = new List<string>();

            if (!File.Exists(waterLogFile))
            {
                lblWaterMssg.Text = "No water log found.";
                return;
            }

            if (!entryFound)
            {
                lblWaterMssg.Text = "No water entry found for this date.";
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

            File.WriteAllLines(waterLogFile, newLines);

            lblWaterMssg.Text = "Water entry deleted.";
            txtWaterLog.Text = string.Join(Environment.NewLine, newLines);
        }
    }
}



