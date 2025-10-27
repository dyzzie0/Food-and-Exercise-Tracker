using System.Windows.Forms;

namespace Assignment_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAllData();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (True == true)
            {
                menuStrip1.Dock = DockStyle.None;
                menuStrip1.Visible = false;
                True = false;

            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                menuStrip1.Visible = true;
                True = true;
            }

        }

        bool True = true;
        private void btn_Hidden_Click(object sender, EventArgs e)
        {
            if (True)
            {
                menuStrip1.Visible = false;
                True = false;
            }
            else
            {
                menuStrip1.Visible = true;
                True = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Have you saved your progress before quitting?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Oh hello again!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void trackExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackExercise trackExerciseForm = new TrackExercise();
            trackExerciseForm.Show();
        }

        private void logWaterIntakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaterIntake waterIntake = new WaterIntake();
            waterIntake.Show();
        }

        private void logWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogWeight logWeightForm = new LogWeight();
            logWeightForm.Show();
        }
        private void viewProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProgress displayProgress = new DisplayProgress();
            displayProgress.Show();
        }

        private void logFoodAndCaloriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FoodAndCalories foodAndCalories = new FoodAndCalories();
            foodAndCalories.Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }
        private void LoadAllData()
        {
            TrackExercise trackExerciseForm = new TrackExercise();
            trackExerciseForm.Show();
            trackExerciseForm.LoadData();


            FoodAndCalories foodAndCaloriesForm = new FoodAndCalories();
            foodAndCaloriesForm.Show();
            foodAndCaloriesForm.LoadData();


            WaterIntake waterIntakeForm = new WaterIntake();
            waterIntakeForm.Show();
            waterIntakeForm.LoadData();

            LogWeight logWeightForm = new LogWeight();
            logWeightForm.Show();
            logWeightForm.LoadData();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data has been saved!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}




