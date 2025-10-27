using System;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace Assignment_Project1
{
    public partial class TrackExercise : Form
    {
        private const string exerciseLogFile = "exercises.txt";

        public TrackExercise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtExerciseName.Text = "";
            txtSets.Text = "";
            txtReps.Text = "";
            lblExerciseMssg.Text = "";
        }

        //Loading up exercises 
        public void LoadData()
        {
            if (File.Exists(exerciseLogFile))
            {
                txtExercises.Text = File.ReadAllText(exerciseLogFile);
                lblExerciseMssg.Text = "Exercises loaded successfully.";
            }
            else
            {
                lblExerciseMssg.Text = "No exercise file found.";
            }
        }
        //Checking if they're numbers between 1-100
        private bool Number(string input, int min, int max)
        {
            if (int.TryParse(input, out int number))
            {
                return number >= min && number <= max;
            }
            return false;
        }
        //Checking if exercise is only a string
        private bool Exercise(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sets = int.Parse(txtSets.Text);
            int reps = int.Parse(txtReps.Text);
            string date = dateTimePicker.Value.ToShortDateString();

            if (txtExerciseName.Text == "" || !Exercise(txtExerciseName.Text) || !Number(txtSets.Text, 1, 100) || !Number(txtReps.Text, 1, 100))
            {
                lblExerciseMssg.Text = "Please fill in all field with letters and enter valid numbers between 1 and 100.";
                return;
            }

            string exerciseEntry = $"{dateTimePicker.Value.ToShortDateString()}: {txtExerciseName.Text} - {sets} sets of {reps} reps";
            txtExercises.AppendText(exerciseEntry + Environment.NewLine);
            lblExerciseMssg.Text = "Exercise added. Do you want to add another";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblExerciseMssg.Text = "All exercises logged.";
        }
        //Appending text file
        private void btnSave_Click(object sender, EventArgs e)
        {
            File.AppendAllText(exerciseLogFile, txtExercises.Text);
            lblExerciseMssg.Text = "Exercises saved successfully.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExercises.Clear();
            lblExerciseMssg.Text = "Cleared.";
        }

        private void TrackExercise_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dateToDelete = dateTimePicker.Value.ToShortDateString();
            string[] lines = File.ReadAllLines(exerciseLogFile);
            bool entryFound = false;
            var newLines = new List<string>();

            if (!File.Exists(exerciseLogFile))
            {
                lblExerciseMssg.Text = "No exercise log found. ";
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

            if (!entryFound)
            {
                lblExerciseMssg.Text = "No exercise entry found for this date, sorry. ";
                return;
            }

            File.WriteAllLines(exerciseLogFile, newLines);
            lblExerciseMssg.Text = "Exercises entry deleted.";
            txtExercises.Text = string.Join(Environment.NewLine, newLines);
        }
    }
}
