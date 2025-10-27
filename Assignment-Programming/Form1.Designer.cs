namespace Assignment_Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            trackExerciseToolStripMenuItem = new ToolStripMenuItem();
            logFoodAndCaloriesToolStripMenuItem = new ToolStripMenuItem();
            logWaterIntakeToolStripMenuItem = new ToolStripMenuItem();
            logWeightToolStripMenuItem = new ToolStripMenuItem();
            viewProgressToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            btn_Hidden = new Button();
            lblEverything = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Violet;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, trackExerciseToolStripMenuItem, logFoodAndCaloriesToolStripMenuItem, logWaterIntakeToolStripMenuItem, logWeightToolStripMenuItem, viewProgressToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1628, 100);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(22, 96);
            toolStripMenuItem1.Text = ".";
            // 
            // trackExerciseToolStripMenuItem
            // 
            trackExerciseToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            trackExerciseToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            trackExerciseToolStripMenuItem.Image = (Image)resources.GetObject("trackExerciseToolStripMenuItem.Image");
            trackExerciseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            trackExerciseToolStripMenuItem.Name = "trackExerciseToolStripMenuItem";
            trackExerciseToolStripMenuItem.Size = new Size(183, 96);
            trackExerciseToolStripMenuItem.Text = "Track Exercise";
            trackExerciseToolStripMenuItem.Click += trackExerciseToolStripMenuItem_Click;
            // 
            // logFoodAndCaloriesToolStripMenuItem
            // 
            logFoodAndCaloriesToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            logFoodAndCaloriesToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            logFoodAndCaloriesToolStripMenuItem.Image = (Image)resources.GetObject("logFoodAndCaloriesToolStripMenuItem.Image");
            logFoodAndCaloriesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logFoodAndCaloriesToolStripMenuItem.Name = "logFoodAndCaloriesToolStripMenuItem";
            logFoodAndCaloriesToolStripMenuItem.Size = new Size(260, 96);
            logFoodAndCaloriesToolStripMenuItem.Text = "Log Food and Calories ";
            logFoodAndCaloriesToolStripMenuItem.Click += logFoodAndCaloriesToolStripMenuItem_Click_1;
            // 
            // logWaterIntakeToolStripMenuItem
            // 
            logWaterIntakeToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            logWaterIntakeToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            logWaterIntakeToolStripMenuItem.Image = (Image)resources.GetObject("logWaterIntakeToolStripMenuItem.Image");
            logWaterIntakeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logWaterIntakeToolStripMenuItem.Name = "logWaterIntakeToolStripMenuItem";
            logWaterIntakeToolStripMenuItem.Size = new Size(199, 96);
            logWaterIntakeToolStripMenuItem.Text = "Log Water Intake";
            logWaterIntakeToolStripMenuItem.Click += logWaterIntakeToolStripMenuItem_Click;
            // 
            // logWeightToolStripMenuItem
            // 
            logWeightToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            logWeightToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            logWeightToolStripMenuItem.Image = (Image)resources.GetObject("logWeightToolStripMenuItem.Image");
            logWeightToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logWeightToolStripMenuItem.Name = "logWeightToolStripMenuItem";
            logWeightToolStripMenuItem.Size = new Size(172, 96);
            logWeightToolStripMenuItem.Text = "Log Weight";
            logWeightToolStripMenuItem.Click += logWeightToolStripMenuItem_Click;
            // 
            // viewProgressToolStripMenuItem
            // 
            viewProgressToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            viewProgressToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            viewProgressToolStripMenuItem.Image = (Image)resources.GetObject("viewProgressToolStripMenuItem.Image");
            viewProgressToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewProgressToolStripMenuItem.Name = "viewProgressToolStripMenuItem";
            viewProgressToolStripMenuItem.Size = new Size(201, 96);
            viewProgressToolStripMenuItem.Text = "View Progress";
            viewProgressToolStripMenuItem.Click += viewProgressToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            saveToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(194, 96);
            saveToolStripMenuItem.Text = "Save Progress";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            loadToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            loadToolStripMenuItem.Image = (Image)resources.GetObject("loadToolStripMenuItem.Image");
            loadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(192, 96);
            loadToolStripMenuItem.Text = "Load Progress";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            quitToolStripMenuItem.ForeColor = Color.DarkSlateBlue;
            quitToolStripMenuItem.Image = (Image)resources.GetObject("quitToolStripMenuItem.Image");
            quitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(140, 96);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // btn_Hidden
            // 
            btn_Hidden.Location = new Point(0, 103);
            btn_Hidden.Name = "btn_Hidden";
            btn_Hidden.Size = new Size(116, 56);
            btn_Hidden.TabIndex = 1;
            btn_Hidden.Text = ">>";
            btn_Hidden.UseVisualStyleBackColor = true;
            btn_Hidden.Click += btn_Hidden_Click;
            // 
            // lblEverything
            // 
            lblEverything.AutoSize = true;
            lblEverything.Font = new Font("Segoe UI", 40F);
            lblEverything.Location = new Point(219, 338);
            lblEverything.Name = "lblEverything";
            lblEverything.Size = new Size(0, 72);
            lblEverything.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1628, 450);
            Controls.Add(lblEverything);
            Controls.Add(btn_Hidden);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem trackExerciseToolStripMenuItem;
        private ToolStripMenuItem logFoodAndCaloriesToolStripMenuItem;
        private ToolStripMenuItem logWaterIntakeToolStripMenuItem;
        private ToolStripMenuItem logWeightToolStripMenuItem;
        private ToolStripMenuItem viewProgressToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button btn_Hidden;
        private Label lblEverything;
    }
}
