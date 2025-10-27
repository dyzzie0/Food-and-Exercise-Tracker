namespace Assignment_Project1
{
    partial class WaterIntake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterIntake));
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            txtWaterLog = new RichTextBox();
            lblWaterMssg = new Label();
            txtWater = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            dateTimePicker = new DateTimePicker();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(471, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 45);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(241, 111);
            label2.Name = "label2";
            label2.Size = new Size(313, 21);
            label2.TabIndex = 15;
            label2.Text = "How much water did you drink today in ml?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(276, 4);
            label1.Name = "label1";
            label1.Size = new Size(231, 89);
            label1.TabIndex = 14;
            label1.Text = "Water ";
            // 
            // txtWaterLog
            // 
            txtWaterLog.Location = new Point(226, 212);
            txtWaterLog.Name = "txtWaterLog";
            txtWaterLog.Size = new Size(483, 101);
            txtWaterLog.TabIndex = 28;
            txtWaterLog.Text = "";
            // 
            // lblWaterMssg
            // 
            lblWaterMssg.AutoSize = true;
            lblWaterMssg.Location = new Point(296, 377);
            lblWaterMssg.Name = "lblWaterMssg";
            lblWaterMssg.Size = new Size(0, 15);
            lblWaterMssg.TabIndex = 29;
            // 
            // txtWater
            // 
            txtWater.Font = new Font("Segoe UI", 20F);
            txtWater.Location = new Point(226, 148);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(483, 43);
            txtWater.TabIndex = 30;
            txtWater.Text = " ";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(226, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 45);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(310, 319);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 45);
            btnClear.TabIndex = 45;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(597, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 46;
            dateTimePicker.Visible = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(390, 319);
            button3.Name = "button3";
            button3.Size = new Size(75, 45);
            button3.TabIndex = 49;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // WaterIntake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(dateTimePicker);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtWater);
            Controls.Add(lblWaterMssg);
            Controls.Add(txtWaterLog);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "WaterIntake";
            Text = "WaterIntake";
            Load += WaterIntake_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label label2;
        private Label label1;
        private RichTextBox txtWaterLog;
        private Label lblWaterMssg;
        private TextBox txtWater;
        private Button btnAdd;
        private Button btnClear;
        private DateTimePicker dateTimePicker;
        private Button button3;
    }
}