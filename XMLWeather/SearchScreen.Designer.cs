namespace XMLWeather
{
    partial class SearchScreen
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
            this.underline = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.citySearchBox = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.spinningEarth2 = new System.Windows.Forms.PictureBox();
            this.spinningEarth1 = new System.Windows.Forms.PictureBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countrySearchBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinningEarth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinningEarth1)).BeginInit();
            this.SuspendLayout();
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.Color.Transparent;
            this.underline.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.ForeColor = System.Drawing.Color.White;
            this.underline.Location = new System.Drawing.Point(199, 25);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(65, 29);
            this.underline.TabIndex = 64;
            this.underline.Text = "____________________________";
            this.underline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(11, 15);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 28);
            this.homeButton.TabIndex = 65;
            this.homeButton.Text = "Today";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(104, 16);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(79, 28);
            this.forecastLabel.TabIndex = 66;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(185, 17);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(100, 28);
            this.searchLabel.TabIndex = 71;
            this.searchLabel.Text = "Search";
            // 
            // citySearchBox
            // 
            this.citySearchBox.Location = new System.Drawing.Point(130, 264);
            this.citySearchBox.Name = "citySearchBox";
            this.citySearchBox.Size = new System.Drawing.Size(100, 20);
            this.citySearchBox.TabIndex = 72;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.Transparent;
            this.searchText.Font = new System.Drawing.Font("Rubik Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.White;
            this.searchText.Location = new System.Drawing.Point(11, 227);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(101, 28);
            this.searchText.TabIndex = 73;
            this.searchText.Text = "Search:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Barlow Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(88, 343);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 41);
            this.searchButton.TabIndex = 74;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // spinningEarth2
            // 
            this.spinningEarth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spinningEarth2.Image = global::XMLWeather.Properties.Resources.spinningEarth;
            this.spinningEarth2.Location = new System.Drawing.Point(89, 444);
            this.spinningEarth2.Name = "spinningEarth2";
            this.spinningEarth2.Size = new System.Drawing.Size(117, 114);
            this.spinningEarth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinningEarth2.TabIndex = 76;
            this.spinningEarth2.TabStop = false;
            // 
            // spinningEarth1
            // 
            this.spinningEarth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spinningEarth1.Image = global::XMLWeather.Properties.Resources.spinningEarth;
            this.spinningEarth1.Location = new System.Drawing.Point(89, 101);
            this.spinningEarth1.Name = "spinningEarth1";
            this.spinningEarth1.Size = new System.Drawing.Size(117, 114);
            this.spinningEarth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinningEarth1.TabIndex = 75;
            this.spinningEarth1.TabStop = false;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(71, 266);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(41, 20);
            this.cityLabel.TabIndex = 77;
            this.cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.Color.White;
            this.countryLabel.Location = new System.Drawing.Point(39, 301);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(73, 20);
            this.countryLabel.TabIndex = 78;
            this.countryLabel.Text = "Country:";
            // 
            // countrySearchBox
            // 
            this.countrySearchBox.Location = new System.Drawing.Point(130, 299);
            this.countrySearchBox.Name = "countrySearchBox";
            this.countrySearchBox.Size = new System.Drawing.Size(100, 20);
            this.countrySearchBox.TabIndex = 79;
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(50, 403);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(199, 20);
            this.errorLabel.TabIndex = 80;
            this.errorLabel.Text = "Error! Place doesn\'t exist!";
            this.errorLabel.Visible = false;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.countrySearchBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.spinningEarth2);
            this.Controls.Add(this.spinningEarth1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.citySearchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.underline);
            this.DoubleBuffered = true;
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(291, 600);
            ((System.ComponentModel.ISupportInitialize)(this.spinningEarth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinningEarth1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label underline;
        private System.Windows.Forms.Label homeButton;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox citySearchBox;
        private System.Windows.Forms.Label searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox spinningEarth1;
        private System.Windows.Forms.PictureBox spinningEarth2;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countrySearchBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
