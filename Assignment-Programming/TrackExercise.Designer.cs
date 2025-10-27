namespace Assignment_Project1
{
    partial class TrackExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackExercise));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtExerciseName = new TextBox();
            txtSets = new TextBox();
            txtReps = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnYes = new Button();
            btnNo = new Button();
            panel1 = new Panel();
            txtExercises = new RichTextBox();
            lblExerciseMssg = new Label();
            btnSave = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            dateTimePicker = new DateTimePicker();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(439, 89);
            label1.TabIndex = 0;
            label1.Text = "Track Exercise";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(204, 136);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 1;
            label2.Text = "Exercise Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(204, 211);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 2;
            label3.Text = "Sets";
            // 
            // txtExerciseName
            // 
            txtExerciseName.Location = new Point(373, 134);
            txtExerciseName.Name = "txtExerciseName";
            txtExerciseName.Size = new Size(100, 23);
            txtExerciseName.TabIndex = 3;
            // 
            // txtSets
            // 
            txtSets.Location = new Point(373, 213);
            txtSets.Name = "txtSets";
            txtSets.Size = new Size(100, 23);
            txtSets.TabIndex = 4;
            // 
            // txtReps
            // 
            txtReps.Location = new Point(373, 283);
            txtReps.Name = "txtReps";
            txtReps.Size = new Size(100, 23);
            txtReps.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(204, 285);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 6;
            label4.Text = "Reps";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(204, 357);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 8;
            label5.Text = "Add Another Exercise";
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 12F);
            btnYes.Location = new Point(373, 334);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(45, 45);
            btnYes.TabIndex = 9;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += button1_Click;
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI", 12F);
            btnNo.Location = new Point(428, 335);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(45, 44);
            btnNo.TabIndex = 10;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtExercises);
            panel1.Location = new Point(546, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 172);
            panel1.TabIndex = 11;
            // 
            // txtExercises
            // 
            txtExercises.Location = new Point(3, 4);
            txtExercises.Name = "txtExercises";
            txtExercises.Size = new Size(435, 165);
            txtExercises.TabIndex = 2;
            txtExercises.Text = "";
            // 
            // lblExerciseMssg
            // 
            lblExerciseMssg.AutoSize = true;
            lblExerciseMssg.Font = new Font("Segoe UI", 10F);
            lblExerciseMssg.Location = new Point(567, 309);
            lblExerciseMssg.Name = "lblExerciseMssg";
            lblExerciseMssg.Size = new Size(0, 19);
            lblExerciseMssg.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(774, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 45);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(546, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 45);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(613, 333);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 45);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(801, 9);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 47;
            dateTimePicker.Visible = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(693, 333);
            button3.Name = "button3";
            button3.Size = new Size(75, 45);
            button3.TabIndex = 49;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TrackExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(999, 591);
            Controls.Add(button3);
            Controls.Add(dateTimePicker);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(lblExerciseMssg);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtReps);
            Controls.Add(txtSets);
            Controls.Add(txtExerciseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "TrackExercise";
            Text = "TrackExercise";
            Load += TrackExercise_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtExerciseName;
        private TextBox txtSets;
        private TextBox txtReps;
        private Label label4;
        private Label label5;
        private Button btnYes;
        private Button btnNo;
        private Panel panel1;
        private Button btnSave;
        private Label lblExerciseMssg;
        private Button btnAdd;
        private RichTextBox txtExercises;
        private Button btnClear;
        private DateTimePicker dateTimePicker;
        private Button button3;
    }
}