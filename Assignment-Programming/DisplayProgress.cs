using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Assignment_Project1
{
    public partial class DisplayProgress : Form
    {
        private const string foodLogFile = "foodlog.txt";
        private const string waterLogFile = "waterlog.txt";
        private const string exerciseLogFile = "exercises.txt";
        private const string weightLogFile = "weightlog.txt";

        public DisplayProgress()
        {
            InitializeComponent();
        }

        //Loading up data
        private string LoadDataForDate(string logFile, string date)
        {
            if (!File.Exists(logFile))
            {
                return "Sorry, no file found";
            }

            //checking if theres any data in the file

            string[] lines = File.ReadAllLines(logFile);
            string result = string.Empty;

            foreach (var line in lines)
            {
                if (line.StartsWith(date))
                {
                    result += line + Environment.NewLine;
                }
            }

            if (string.IsNullOrEmpty(result))
            {
                return "Sorry no data could be found";
            }

            return result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadDataForCurrentDate();
        }

        private void LoadDataForCurrentDate()
        {
            string selectedDate = dateTimePicker.Value.ToShortDateString();
            string foodData = LoadDataForDate(foodLogFile, selectedDate);
            string waterData = LoadDataForDate(waterLogFile, selectedDate);
            string exerciseData = LoadDataForDate(exerciseLogFile, selectedDate);
            string weightData = LoadDataForDate(weightLogFile, selectedDate);

            //Error messages for all possible entries
            if (foodData == "Sorry no data could be found" && waterData == "Sorry no data could be found" && exerciseData == "Sorry no data could be found" && weightData == "Sorry no data could be found")
            {
                lblStatus.Text = "No data found for the selected date.";
            }
            else
            { 
            if (foodData == "Sorry no data could be found")
            {
                    txtFoodLog.Text = "No food data found.";
            }
                else
                {
                    txtFoodLog.Text = foodData;
                }

                if (waterData == "Sorry no data could be found")
                {
                    txtWaterLog.Text = "No water data found.";
                }
                else
                {
                    txtWaterLog.Text = waterData;
                }

                if (exerciseData == "Sorry no data could be found")
                {
                    txtExerciseLog.Text = "No exercise data found.";
                }
                else
                {
                    txtExerciseLog.Text = exerciseData;
                }

                if (weightData == "Sorry no data could be found")
                {
                    txtWeightLog.Text = "No weight data found.";
                }
                else
                {
                    txtWeightLog.Text = weightData;
                }

                lblStatus.Text = "Data loaded successfully.";
            }
        }

        private void DisplayProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
