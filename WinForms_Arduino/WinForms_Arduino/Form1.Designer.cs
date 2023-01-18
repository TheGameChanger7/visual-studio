namespace WinForms_Arduino
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
            this.label_Temperature = new System.Windows.Forms.Label();
            this.label_Humidity = new System.Windows.Forms.Label();
            this.progressBar_Temperature = new System.Windows.Forms.ProgressBar();
            this.progressBar_Humidity = new System.Windows.Forms.ProgressBar();
            this.label_SerialPort = new System.Windows.Forms.Label();
            this.textBox_Portnumber = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Temperature
            // 
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Temperature.Location = new System.Drawing.Point(67, 30);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(71, 37);
            this.label_Temperature.TabIndex = 0;
            this.label_Temperature.Text = "온도";
            this.label_Temperature.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Humidity
            // 
            this.label_Humidity.AutoSize = true;
            this.label_Humidity.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Humidity.Location = new System.Drawing.Point(67, 123);
            this.label_Humidity.Name = "label_Humidity";
            this.label_Humidity.Size = new System.Drawing.Size(71, 37);
            this.label_Humidity.TabIndex = 1;
            this.label_Humidity.Text = "습도";
            // 
            // progressBar_Temperature
            // 
            this.progressBar_Temperature.Location = new System.Drawing.Point(143, 33);
            this.progressBar_Temperature.Name = "progressBar_Temperature";
            this.progressBar_Temperature.Size = new System.Drawing.Size(350, 29);
            this.progressBar_Temperature.TabIndex = 2;
            this.progressBar_Temperature.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar_Humidity
            // 
            this.progressBar_Humidity.Location = new System.Drawing.Point(143, 126);
            this.progressBar_Humidity.Name = "progressBar_Humidity";
            this.progressBar_Humidity.Size = new System.Drawing.Size(350, 29);
            this.progressBar_Humidity.TabIndex = 3;
            // 
            // label_SerialPort
            // 
            this.label_SerialPort.AutoSize = true;
            this.label_SerialPort.Font = new System.Drawing.Font("맑은 고딕", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SerialPort.Location = new System.Drawing.Point(231, 179);
            this.label_SerialPort.Name = "label_SerialPort";
            this.label_SerialPort.Size = new System.Drawing.Size(184, 45);
            this.label_SerialPort.TabIndex = 4;
            this.label_SerialPort.Text = "Serial Port";
            this.label_SerialPort.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Portnumber
            // 
            this.textBox_Portnumber.Location = new System.Drawing.Point(143, 250);
            this.textBox_Portnumber.Name = "textBox_Portnumber";
            this.textBox_Portnumber.Size = new System.Drawing.Size(350, 20);
            this.textBox_Portnumber.TabIndex = 5;
            // 
            // button_Open
            // 
            this.button_Open.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Open.Location = new System.Drawing.Point(143, 312);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(95, 51);
            this.button_Open.TabIndex = 6;
            this.button_Open.Text = "연결";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_OnClick_Open);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Close.Location = new System.Drawing.Point(382, 312);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(111, 51);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "종료";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_OnClick_Close);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 436);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Portnumber);
            this.Controls.Add(this.label_SerialPort);
            this.Controls.Add(this.progressBar_Humidity);
            this.Controls.Add(this.progressBar_Temperature);
            this.Controls.Add(this.label_Humidity);
            this.Controls.Add(this.label_Temperature);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Temperature;
        private Label label_Humidity;
        private ProgressBar progressBar_Temperature;
        private ProgressBar progressBar_Humidity;
        private Label label_SerialPort;
        private TextBox textBox_Portnumber;
        private Button button_Open;
        private Button button_Close;
    }
}