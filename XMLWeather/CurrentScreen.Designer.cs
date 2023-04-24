namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.highTemp = new System.Windows.Forms.Label();
            this.lowTemp = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.humidityMeasure = new System.Windows.Forms.ProgressBar();
            this.humidityValue = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunriseInfoLabel = new System.Windows.Forms.Label();
            this.sunsetInfoLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.underline = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.windValueLabel = new System.Windows.Forms.Label();
            this.sunsetIcon = new System.Windows.Forms.PictureBox();
            this.sunriseIcon = new System.Windows.Forms.PictureBox();
            this.condition = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sunsetIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunriseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoEllipsis = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(69, 73);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(170, 43);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "Stratford";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(122, 125);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(67, 50);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "Temperature";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(94, 13);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(79, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // highTemp
            // 
            this.highTemp.AutoSize = true;
            this.highTemp.BackColor = System.Drawing.Color.Transparent;
            this.highTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highTemp.ForeColor = System.Drawing.Color.Red;
            this.highTemp.Location = new System.Drawing.Point(184, 188);
            this.highTemp.Name = "highTemp";
            this.highTemp.Size = new System.Drawing.Size(25, 24);
            this.highTemp.TabIndex = 43;
            this.highTemp.Text = "H";
            // 
            // lowTemp
            // 
            this.lowTemp.AutoSize = true;
            this.lowTemp.BackColor = System.Drawing.Color.Transparent;
            this.lowTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lowTemp.Location = new System.Drawing.Point(86, 188);
            this.lowTemp.Name = "lowTemp";
            this.lowTemp.Size = new System.Drawing.Size(21, 24);
            this.lowTemp.TabIndex = 44;
            this.lowTemp.Text = "L";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(23, 573);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 13);
            this.dateLabel.TabIndex = 45;
            this.dateLabel.Text = "Updated";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(30, 335);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(83, 20);
            this.humidityLabel.TabIndex = 47;
            this.humidityLabel.Text = "Humidity:";
            // 
            // humidityMeasure
            // 
            this.humidityMeasure.Location = new System.Drawing.Point(128, 332);
            this.humidityMeasure.Name = "humidityMeasure";
            this.humidityMeasure.Size = new System.Drawing.Size(102, 23);
            this.humidityMeasure.TabIndex = 48;
            // 
            // humidityValue
            // 
            this.humidityValue.AutoSize = true;
            this.humidityValue.BackColor = System.Drawing.Color.Transparent;
            this.humidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityValue.ForeColor = System.Drawing.Color.White;
            this.humidityValue.Location = new System.Drawing.Point(152, 370);
            this.humidityValue.Name = "humidityValue";
            this.humidityValue.Size = new System.Drawing.Size(52, 18);
            this.humidityValue.TabIndex = 49;
            this.humidityValue.Text = "label1";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.AutoSize = true;
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseLabel.Location = new System.Drawing.Point(30, 419);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(75, 20);
            this.sunriseLabel.TabIndex = 50;
            this.sunriseLabel.Text = "Sunrise:";
            // 
            // sunriseInfoLabel
            // 
            this.sunriseInfoLabel.AutoSize = true;
            this.sunriseInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseInfoLabel.Font = new System.Drawing.Font("Rubik Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseInfoLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseInfoLabel.Location = new System.Drawing.Point(113, 426);
            this.sunriseInfoLabel.Name = "sunriseInfoLabel";
            this.sunriseInfoLabel.Size = new System.Drawing.Size(39, 13);
            this.sunriseInfoLabel.TabIndex = 52;
            this.sunriseInfoLabel.Text = "Hello";
            // 
            // sunsetInfoLabel
            // 
            this.sunsetInfoLabel.AutoSize = true;
            this.sunsetInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetInfoLabel.Font = new System.Drawing.Font("Rubik Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetInfoLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetInfoLabel.Location = new System.Drawing.Point(112, 471);
            this.sunsetInfoLabel.Name = "sunsetInfoLabel";
            this.sunsetInfoLabel.Size = new System.Drawing.Size(39, 13);
            this.sunsetInfoLabel.TabIndex = 53;
            this.sunsetInfoLabel.Text = "Hello";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.AutoSize = true;
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetLabel.Location = new System.Drawing.Point(31, 466);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(71, 20);
            this.sunsetLabel.TabIndex = 54;
            this.sunsetLabel.Text = "Sunset:";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(6, 10);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(79, 28);
            this.todayLabel.TabIndex = 56;
            this.todayLabel.Text = "Today";
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.Color.Transparent;
            this.underline.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.ForeColor = System.Drawing.Color.White;
            this.underline.Location = new System.Drawing.Point(20, 20);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(48, 29);
            this.underline.TabIndex = 64;
            this.underline.Text = "____________________________";
            this.underline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(181, 13);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(91, 28);
            this.searchLabel.TabIndex = 65;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(31, 511);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(54, 20);
            this.windLabel.TabIndex = 66;
            this.windLabel.Text = "Wind:";
            // 
            // windValueLabel
            // 
            this.windValueLabel.AutoSize = true;
            this.windValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.windValueLabel.Font = new System.Drawing.Font("Rubik Medium", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windValueLabel.ForeColor = System.Drawing.Color.White;
            this.windValueLabel.Location = new System.Drawing.Point(91, 517);
            this.windValueLabel.Name = "windValueLabel";
            this.windValueLabel.Size = new System.Drawing.Size(31, 12);
            this.windValueLabel.TabIndex = 67;
            this.windValueLabel.Text = "Hello";
            // 
            // sunsetIcon
            // 
            this.sunsetIcon.BackColor = System.Drawing.Color.Transparent;
            this.sunsetIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunsetIcon.Image = global::XMLWeather.Properties.Resources.sunset;
            this.sunsetIcon.Location = new System.Drawing.Point(217, 466);
            this.sunsetIcon.Name = "sunsetIcon";
            this.sunsetIcon.Size = new System.Drawing.Size(37, 32);
            this.sunsetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunsetIcon.TabIndex = 55;
            this.sunsetIcon.TabStop = false;
            // 
            // sunriseIcon
            // 
            this.sunriseIcon.BackColor = System.Drawing.Color.Transparent;
            this.sunriseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunriseIcon.Image = global::XMLWeather.Properties.Resources.sunrise;
            this.sunriseIcon.Location = new System.Drawing.Point(217, 416);
            this.sunriseIcon.Name = "sunriseIcon";
            this.sunriseIcon.Size = new System.Drawing.Size(37, 32);
            this.sunriseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunriseIcon.TabIndex = 51;
            this.sunriseIcon.TabStop = false;
            // 
            // condition
            // 
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Location = new System.Drawing.Point(112, 233);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(71, 60);
            this.condition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.condition.TabIndex = 46;
            this.condition.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::XMLWeather.Properties.Resources.windIconT;
            this.pictureBox1.Location = new System.Drawing.Point(188, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.windValueLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.sunsetIcon);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunsetInfoLabel);
            this.Controls.Add(this.sunriseInfoLabel);
            this.Controls.Add(this.sunriseIcon);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.humidityValue);
            this.Controls.Add(this.humidityMeasure);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.lowTemp);
            this.Controls.Add(this.highTemp);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(291, 600);
            ((System.ComponentModel.ISupportInitialize)(this.sunsetIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunriseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label highTemp;
        private System.Windows.Forms.Label lowTemp;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox condition;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.ProgressBar humidityMeasure;
        private System.Windows.Forms.Label humidityValue;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.PictureBox sunriseIcon;
        private System.Windows.Forms.Label sunriseInfoLabel;
        private System.Windows.Forms.Label sunsetInfoLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.PictureBox sunsetIcon;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label underline;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windValueLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
