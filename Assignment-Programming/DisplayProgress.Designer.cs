namespace Assignment_Project1
{
    partial class DisplayProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayProgress));
            dateTimePicker = new DateTimePicker();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtWeightLog = new RichTextBox();
            txtExerciseLog = new RichTextBox();
            txtWaterLog = new RichTextBox();
            txtFoodLog = new RichTextBox();
            label6 = new Label();
            label1 = new Label();
            lblStatus = new Label();
            btnView = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(172, 166);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtWeightLog);
            panel1.Controls.Add(txtExerciseLog);
            panel1.Controls.Add(txtWaterLog);
            panel1.Controls.Add(txtFoodLog);
            panel1.Location = new Point(108, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 277);
            panel1.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(347, 14);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 33;
            label5.Text = "Food Consumed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(347, 139);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 32;
            label4.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 139);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 31;
            label3.Text = "Water Consumed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 30;
            label2.Text = "Exercise";
            // 
            // txtWeightLog
            // 
            txtWeightLog.Location = new Point(347, 163);
            txtWeightLog.Name = "txtWeightLog";
            txtWeightLog.Size = new Size(312, 96);
            txtWeightLog.TabIndex = 7;
            txtWeightLog.Text = "";
            // 
            // txtExerciseLog
            // 
            txtExerciseLog.Location = new Point(24, 38);
            txtExerciseLog.Name = "txtExerciseLog";
            txtExerciseLog.Size = new Size(317, 96);
            txtExerciseLog.TabIndex = 6;
            txtExerciseLog.Text = "";
            // 
            // txtWaterLog
            // 
            txtWaterLog.Location = new Point(24, 163);
            txtWaterLog.Name = "txtWaterLog";
            txtWaterLog.Size = new Size(317, 96);
            txtWaterLog.TabIndex = 5;
            txtWaterLog.Text = "";
            // 
            // txtFoodLog
            // 
            txtFoodLog.Location = new Point(347, 38);
            txtFoodLog.Name = "txtFoodLog";
            txtFoodLog.Size = new Size(312, 96);
            txtFoodLog.TabIndex = 4;
            txtFoodLog.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 50F);
            label6.Location = new Point(303, -4);
            label6.Name = "label6";
            label6.Size = new Size(291, 89);
            label6.TabIndex = 14;
            label6.Text = "Progress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(316, 142);
            label1.Name = "label1";
            label1.Size = new Size(247, 21);
            label1.TabIndex = 27;
            label1.Text = "Choose the date you'd like to view";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(303, 457);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 28;
            // 
            // btnView
            // 
            btnView.Location = new Point(553, 168);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 29;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // DisplayProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(906, 571);
            Controls.Add(btnView);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(panel1);
            Controls.Add(label6);
            DoubleBuffered = true;
            Name = "DisplayProgress";
            Text = "DisplayProgress";
            Load += DisplayProgress_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label lblStatus;
        private Button btnView;
        private RichTextBox txtWeightLog;
        private RichTextBox txtExerciseLog;
        private RichTextBox txtWaterLog;
        private RichTextBox txtFoodLog;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}