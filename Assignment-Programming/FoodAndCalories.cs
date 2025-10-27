using System;
using System.IO;
using System.Windows.Forms;


namespace Assignment_Project1
{
    public partial class FoodAndCalories : Form
    {
        private const string foodLogFile = "foodlog.txt";

        public FoodAndCalories()
        {
            InitializeComponent();
            pnlSnack.Visible = false;
        }

        // Load the food data from file
        public void LoadData()
        {
            if (File.Exists(foodLogFile))
            {
                txtFoodLog.Text = File.ReadAllText(foodLogFile);
                lblFoodMssg.Text = "Food and calories loaded successfully.";
            }
            else
            {
                lblFoodMssg.Text = "No food log file found.";
            }
        }

        // Event handler for adding new food entry
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string breakfast = txtBreakfast.Text;
            string lunch = txtLunch.Text;
            string dinner = txtDinner.Text;
            string snack = txtSnack.Text;
            int sCalories = 0; // Default snack calorie


            if (!int.TryParse(txtBrCalories.Text, out int bCalories))
            {
                lblFoodMssg.Text = "Please enter a valid number for breakfast calories.";
                return;
            }

            if (!int.TryParse(txtLnCalories.Text, out int lCalories))
            {
                lblFoodMssg.Text = "Please enter a valid number for lunch calories.";
                return;
            }

            if (!int.TryParse(txtDnCalories.Text, out int dCalories))
            {
                lblFoodMssg.Text = "Please enter a valid number for dinner calories.";
                return;
            }

            // snack calories if snack panel is visible
            if (pnlSnack.Visible)
            {
                snack = txtSnack.Text;


                if (!int.TryParse(txtSnCalories.Text, out sCalories))
                {
                    lblFoodMssg.Text = "Please enter a valid number for snack calories.";
                    return;
                }
            }

            // Checking if all are filled in
            if (breakfast == "" || lunch == "" || dinner == "")
            {
                lblFoodMssg.Text = "Please fill in all fields.";
                return;
            }

            string date = dateTimePicker.Value.ToShortDateString();
            int totalCalories = bCalories + lCalories + dCalories + sCalories;
            string foodEntry = $"{date}: Breakfast: {breakfast} ({bCalories} calories), Lunch: {lunch} ({lCalories} calories), Dinner: {dinner} ({dCalories} calories), Snack: {snack} ({sCalories} calories) - Total: {totalCalories} calories";

            bool entryExists = false;
            if (File.Exists(foodLogFile))
            {
                string[] lines = File.ReadAllLines(foodLogFile);

                foreach (var line in lines)
                {
                    if (line.StartsWith(date))
                    {
                        entryExists = true;
                        break;
                    }
                }

            }

            if (entryExists)
            {
                lblFoodMssg.Text = "You have already logged food for today.";
                return;
            }

            txtFoodLog.AppendText(foodEntry + Environment.NewLine);
            lblFoodMssg.Text = "Entry added.";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pnlSnack.Visible = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pnlSnack.Visible = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(foodLogFile, txtFoodLog.Text);
            lblFoodMssg.Text = "Data saved successfully.";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFoodLog.Clear();
            lblFoodMssg.Text = "Cleared.";
        }

        private void FoodAndCalories_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dateToDelete = dateTimePicker.Value.ToShortDateString();  
            string[] lines = File.ReadAllLines(foodLogFile);
            bool entryFound = false;
            var newLines = new List<string>();

            if (!File.Exists(foodLogFile))
            {
                lblFoodMssg.Text = "No food log file found.";
                return;
            }

            if (!entryFound)
            {
                lblFoodMssg.Text = "No food entry found for this date.";
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
            //overwriting past data added
            File.WriteAllLines(foodLogFile, newLines);
            lblFoodMssg.Text = "Food entry deleted.";
            txtFoodLog.Text = string.Join(Environment.NewLine, newLines);  
        }
    }
}
