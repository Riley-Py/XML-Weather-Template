﻿namespace XMLWeather
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
            this.sunsetIcon = new System.Windows.Forms.PictureBox();
            this.sunriseIcon = new System.Windows.Forms.PictureBox();
            this.condition = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sunsetIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunriseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condition)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(64, 71);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(137, 43);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "Stratford";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(102, 126);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(67, 50);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "Temperature";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(148, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
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
            this.highTemp.Location = new System.Drawing.Point(164, 189);
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
            this.lowTemp.Location = new System.Drawing.Point(66, 189);
            this.lowTemp.Name = "lowTemp";
            this.lowTemp.Size = new System.Drawing.Size(21, 24);
            this.lowTemp.TabIndex = 44;
            this.lowTemp.Text = "L";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(3, 574);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 13);
            this.dateLabel.TabIndex = 45;
            this.dateLabel.Text = "Updated";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(10, 336);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(83, 20);
            this.humidityLabel.TabIndex = 47;
            this.humidityLabel.Text = "Humidity:";
            // 
            // humidityMeasure
            // 
            this.humidityMeasure.Location = new System.Drawing.Point(108, 333);
            this.humidityMeasure.Name = "humidityMeasure";
            this.humidityMeasure.Size = new System.Drawing.Size(102, 23);
            this.humidityMeasure.TabIndex = 48;
            // 
            // humidityValue
            // 
            this.humidityValue.AutoSize = true;
            this.humidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityValue.ForeColor = System.Drawing.Color.White;
            this.humidityValue.Location = new System.Drawing.Point(132, 371);
            this.humidityValue.Name = "humidityValue";
            this.humidityValue.Size = new System.Drawing.Size(52, 18);
            this.humidityValue.TabIndex = 49;
            this.humidityValue.Text = "label1";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.AutoSize = true;
            this.sunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseLabel.Location = new System.Drawing.Point(10, 420);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(75, 20);
            this.sunriseLabel.TabIndex = 50;
            this.sunriseLabel.Text = "Sunrise:";
            // 
            // sunriseInfoLabel
            // 
            this.sunriseInfoLabel.AutoSize = true;
            this.sunriseInfoLabel.Font = new System.Drawing.Font("Rubik Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseInfoLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseInfoLabel.Location = new System.Drawing.Point(93, 427);
            this.sunriseInfoLabel.Name = "sunriseInfoLabel";
            this.sunriseInfoLabel.Size = new System.Drawing.Size(39, 13);
            this.sunriseInfoLabel.TabIndex = 52;
            this.sunriseInfoLabel.Text = "Hello";
            // 
            // sunsetInfoLabel
            // 
            this.sunsetInfoLabel.AutoSize = true;
            this.sunsetInfoLabel.Font = new System.Drawing.Font("Rubik Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetInfoLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetInfoLabel.Location = new System.Drawing.Point(92, 472);
            this.sunsetInfoLabel.Name = "sunsetInfoLabel";
            this.sunsetInfoLabel.Size = new System.Drawing.Size(39, 13);
            this.sunsetInfoLabel.TabIndex = 53;
            this.sunsetInfoLabel.Text = "Hello";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.AutoSize = true;
            this.sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetLabel.Location = new System.Drawing.Point(11, 467);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(71, 20);
            this.sunsetLabel.TabIndex = 54;
            this.sunsetLabel.Text = "Sunset:";
            // 
            // sunsetIcon
            // 
            this.sunsetIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunsetIcon.Image = global::XMLWeather.Properties.Resources.sunset;
            this.sunsetIcon.Location = new System.Drawing.Point(197, 467);
            this.sunsetIcon.Name = "sunsetIcon";
            this.sunsetIcon.Size = new System.Drawing.Size(37, 33);
            this.sunsetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunsetIcon.TabIndex = 55;
            this.sunsetIcon.TabStop = false;
            // 
            // sunriseIcon
            // 
            this.sunriseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sunriseIcon.Image = global::XMLWeather.Properties.Resources.sunrise;
            this.sunriseIcon.Location = new System.Drawing.Point(197, 417);
            this.sunriseIcon.Name = "sunriseIcon";
            this.sunriseIcon.Size = new System.Drawing.Size(37, 33);
            this.sunriseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunriseIcon.TabIndex = 51;
            this.sunriseIcon.TabStop = false;
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(92, 234);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(71, 60);
            this.condition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.condition.TabIndex = 46;
            this.condition.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
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
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(249, 600);
            ((System.ComponentModel.ISupportInitialize)(this.sunsetIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunriseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condition)).EndInit();
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
    }
}
