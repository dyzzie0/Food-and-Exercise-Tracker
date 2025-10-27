namespace Assignment_Project1
{
    partial class LogWeight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWeight));
            dateTimePicker = new DateTimePicker();
            button3 = new Button();
            panel1 = new Panel();
            txtWeightLog = new RichTextBox();
            btnLbsInput = new Button();
            btnKgInput = new Button();
            txtWeight = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnStInput = new Button();
            label4 = new Label();
            btnStOutput = new Button();
            btnLbsOutput = new Button();
            btnKgOutput = new Button();
            btnAdd = new Button();
            btnConverter = new Button();
            txtConvertedWeight = new RichTextBox();
            pnlConvert = new Panel();
            btnReset = new Button();
            label5 = new Label();
            lblMessage = new Label();
            button2 = new Button();
            button1 = new Button();
            btnClear = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            pnlConvert.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(712, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 26;
            dateTimePicker.Visible = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(677, 354);
            button3.Name = "button3";
            button3.Size = new Size(100, 45);
            button3.TabIndex = 25;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtWeightLog);
            panel1.Location = new Point(457, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 170);
            panel1.TabIndex = 24;
            // 
            // txtWeightLog
            // 
            txtWeightLog.Location = new Point(3, 6);
            txtWeightLog.Name = "txtWeightLog";
            txtWeightLog.Size = new Size(395, 161);
            txtWeightLog.TabIndex = 0;
            txtWeightLog.Text = "";
            // 
            // btnLbsInput
            // 
            btnLbsInput.Font = new Font("Segoe UI", 12F);
            btnLbsInput.Location = new Point(125, 47);
            btnLbsInput.Name = "btnLbsInput";
            btnLbsInput.Size = new Size(45, 44);
            btnLbsInput.TabIndex = 23;
            btnLbsInput.Text = "Lbs";
            btnLbsInput.UseVisualStyleBackColor = true;
            btnLbsInput.Click += btnLbsInput_Click;
            // 
            // btnKgInput
            // 
            btnKgInput.Font = new Font("Segoe UI", 12F);
            btnKgInput.Location = new Point(69, 47);
            btnKgInput.Name = "btnKgInput";
            btnKgInput.Size = new Size(45, 45);
            btnKgInput.TabIndex = 22;
            btnKgInput.Text = "Kg";
            btnKgInput.UseVisualStyleBackColor = true;
            btnKgInput.Click += btnKgInput_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(302, 125);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 19);
            label3.Name = "label3";
            label3.Size = new Size(278, 21);
            label3.TabIndex = 16;
            label3.Text = "Choose the current unit of your weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(103, 123);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 15;
            label2.Text = "Enter current weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(205, 2);
            label1.Name = "label1";
            label1.Size = new Size(377, 89);
            label1.TabIndex = 14;
            label1.Text = "Log Weight";
            // 
            // btnStInput
            // 
            btnStInput.Font = new Font("Segoe UI", 12F);
            btnStInput.Location = new Point(190, 47);
            btnStInput.Name = "btnStInput";
            btnStInput.Size = new Size(45, 44);
            btnStInput.TabIndex = 27;
            btnStInput.Text = "St";
            btnStInput.UseVisualStyleBackColor = true;
            btnStInput.Click += btnStInput_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 117);
            label4.Name = "label4";
            label4.Size = new Size(279, 21);
            label4.TabIndex = 28;
            label4.Text = "Choose the unit you want to convert to";
            // 
            // btnStOutput
            // 
            btnStOutput.Font = new Font("Segoe UI", 12F);
            btnStOutput.Location = new Point(190, 150);
            btnStOutput.Name = "btnStOutput";
            btnStOutput.Size = new Size(45, 44);
            btnStOutput.TabIndex = 31;
            btnStOutput.Text = "St";
            btnStOutput.UseVisualStyleBackColor = true;
            btnStOutput.Click += btnStOutput_Click;
            // 
            // btnLbsOutput
            // 
            btnLbsOutput.Font = new Font("Segoe UI", 12F);
            btnLbsOutput.Location = new Point(125, 151);
            btnLbsOutput.Name = "btnLbsOutput";
            btnLbsOutput.Size = new Size(45, 44);
            btnLbsOutput.TabIndex = 30;
            btnLbsOutput.Text = "Lbs";
            btnLbsOutput.UseVisualStyleBackColor = true;
            btnLbsOutput.Click += btnLbsOutput_Click;
            // 
            // btnKgOutput
            // 
            btnKgOutput.Font = new Font("Segoe UI", 12F);
            btnKgOutput.Location = new Point(69, 150);
            btnKgOutput.Name = "btnKgOutput";
            btnKgOutput.Size = new Size(45, 45);
            btnKgOutput.TabIndex = 29;
            btnKgOutput.Text = "Kg";
            btnKgOutput.UseVisualStyleBackColor = true;
            btnKgOutput.Click += btnKgOutput_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(457, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 45);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Segoe UI", 12F);
            btnConverter.Location = new Point(13, 222);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(101, 45);
            btnConverter.TabIndex = 34;
            btnConverter.Text = "Convert";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtConvertedWeight
            // 
            txtConvertedWeight.Location = new Point(118, 222);
            txtConvertedWeight.Name = "txtConvertedWeight";
            txtConvertedWeight.Size = new Size(89, 45);
            txtConvertedWeight.TabIndex = 1;
            txtConvertedWeight.Text = "";
            // 
            // pnlConvert
            // 
            pnlConvert.BackColor = Color.White;
            pnlConvert.Controls.Add(btnReset);
            pnlConvert.Controls.Add(label3);
            pnlConvert.Controls.Add(txtConvertedWeight);
            pnlConvert.Controls.Add(label4);
            pnlConvert.Controls.Add(btnConverter);
            pnlConvert.Controls.Add(btnKgInput);
            pnlConvert.Controls.Add(btnLbsInput);
            pnlConvert.Controls.Add(btnStInput);
            pnlConvert.Controls.Add(btnStOutput);
            pnlConvert.Controls.Add(btnKgOutput);
            pnlConvert.Controls.Add(btnLbsOutput);
            pnlConvert.Location = new Point(55, 233);
            pnlConvert.Name = "pnlConvert";
            pnlConvert.Size = new Size(335, 277);
            pnlConvert.TabIndex = 35;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F);
            btnReset.Location = new Point(213, 222);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 45);
            btnReset.TabIndex = 35;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(42, 174);
            label5.Name = "label5";
            label5.Size = new Size(254, 21);
            label5.TabIndex = 36;
            label5.Text = "Is your weight already in Kilograms";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(598, 359);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 32;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(357, 162);
            button2.Name = "button2";
            button2.Size = new Size(45, 44);
            button2.TabIndex = 38;
            button2.Text = "No";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(302, 161);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 37;
            button1.Text = "Yes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(516, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 45);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(596, 354);
            button5.Name = "button5";
            button5.Size = new Size(75, 45);
            button5.TabIndex = 49;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // LogWeight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 558);
            Controls.Add(button5);
            Controls.Add(btnClear);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pnlConvert);
            Controls.Add(btnAdd);
            Controls.Add(lblMessage);
            Controls.Add(dateTimePicker);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(txtWeight);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "LogWeight";
            Text = "LogWeight";
            Load += LogWeight_Load;
            panel1.ResumeLayout(false);
            pnlConvert.ResumeLayout(false);
            pnlConvert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Button button3;
        private Panel panel1;
        private Button btnLbsInput;
        private Button btnKgInput;
        private TextBox txtWeight;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnStInput;
        private Label label4;
        private Button btnStOutput;
        private Button btnLbsOutput;
        private Button btnKgOutput;
        private RichTextBox txtWeightLog;
        private Button btnAdd;
        private Button btnConverter;
        private RichTextBox txtConvertedWeight;
        private Panel pnlConvert;
        private Label label5;
        private Label lblMessage;
        private Button button2;
        private Button button1;
        private Button btnReset;
        private Button btnClear;
        private Button button5;
    }
}