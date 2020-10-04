namespace OrderAppForms
{
    partial class SearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IdConfirmButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comConfirmButton = new System.Windows.Forms.Button();
            this.comNameTextBox = new System.Windows.Forms.TextBox();
            this.comLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cusAgeTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.cusConfirmButton = new System.Windows.Forms.Button();
            this.cusNameTextBox = new System.Windows.Forms.TextBox();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lowerTextBox = new System.Windows.Forms.TextBox();
            this.lowerLabel = new System.Windows.Forms.Label();
            this.moneyConfirmButton = new System.Windows.Forms.Button();
            this.upperTextBox = new System.Windows.Forms.TextBox();
            this.upperLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.searchTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 201);
            this.panel1.TabIndex = 0;
            // 
            // searchTabControl
            // 
            this.searchTabControl.Controls.Add(this.tabPage1);
            this.searchTabControl.Controls.Add(this.tabPage2);
            this.searchTabControl.Controls.Add(this.tabPage3);
            this.searchTabControl.Controls.Add(this.tabPage4);
            this.searchTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTabControl.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.searchTabControl.Location = new System.Drawing.Point(0, 0);
            this.searchTabControl.Name = "searchTabControl";
            this.searchTabControl.SelectedIndex = 0;
            this.searchTabControl.Size = new System.Drawing.Size(463, 201);
            this.searchTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IdConfirmButton);
            this.tabPage1.Controls.Add(this.IdTextBox);
            this.tabPage1.Controls.Add(this.IdLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IdConfirmButton
            // 
            this.IdConfirmButton.Location = new System.Drawing.Point(314, 55);
            this.IdConfirmButton.Name = "IdConfirmButton";
            this.IdConfirmButton.Size = new System.Drawing.Size(106, 48);
            this.IdConfirmButton.TabIndex = 2;
            this.IdConfirmButton.Text = "Confirm";
            this.IdConfirmButton.UseVisualStyleBackColor = true;
            this.IdConfirmButton.Click += new System.EventHandler(this.IdConfirmButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(73, 65);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(190, 29);
            this.IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(35, 68);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(32, 23);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comConfirmButton);
            this.tabPage2.Controls.Add(this.comNameTextBox);
            this.tabPage2.Controls.Add(this.comLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 165);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commodity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comConfirmButton
            // 
            this.comConfirmButton.Location = new System.Drawing.Point(314, 57);
            this.comConfirmButton.Name = "comConfirmButton";
            this.comConfirmButton.Size = new System.Drawing.Size(106, 48);
            this.comConfirmButton.TabIndex = 5;
            this.comConfirmButton.Text = "Confirm";
            this.comConfirmButton.UseVisualStyleBackColor = true;
            this.comConfirmButton.Click += new System.EventHandler(this.ComConfirmButton_Click);
            // 
            // comNameTextBox
            // 
            this.comNameTextBox.Location = new System.Drawing.Point(88, 67);
            this.comNameTextBox.Name = "comNameTextBox";
            this.comNameTextBox.Size = new System.Drawing.Size(181, 29);
            this.comNameTextBox.TabIndex = 4;
            // 
            // comLabel
            // 
            this.comLabel.AutoSize = true;
            this.comLabel.Location = new System.Drawing.Point(19, 70);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(63, 23);
            this.comLabel.TabIndex = 3;
            this.comLabel.Text = "Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cusAgeTextBox);
            this.tabPage3.Controls.Add(this.ageLabel);
            this.tabPage3.Controls.Add(this.cusConfirmButton);
            this.tabPage3.Controls.Add(this.cusNameTextBox);
            this.tabPage3.Controls.Add(this.cusNameLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(455, 165);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cusAgeTextBox
            // 
            this.cusAgeTextBox.Location = new System.Drawing.Point(96, 87);
            this.cusAgeTextBox.Name = "cusAgeTextBox";
            this.cusAgeTextBox.Size = new System.Drawing.Size(181, 29);
            this.cusAgeTextBox.TabIndex = 10;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(43, 90);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(47, 23);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age:";
            // 
            // cusConfirmButton
            // 
            this.cusConfirmButton.Location = new System.Drawing.Point(322, 58);
            this.cusConfirmButton.Name = "cusConfirmButton";
            this.cusConfirmButton.Size = new System.Drawing.Size(106, 48);
            this.cusConfirmButton.TabIndex = 8;
            this.cusConfirmButton.Text = "Confirm";
            this.cusConfirmButton.UseVisualStyleBackColor = true;
            this.cusConfirmButton.Click += new System.EventHandler(this.CusConfirmButton_Click);
            // 
            // cusNameTextBox
            // 
            this.cusNameTextBox.Location = new System.Drawing.Point(96, 39);
            this.cusNameTextBox.Name = "cusNameTextBox";
            this.cusNameTextBox.Size = new System.Drawing.Size(181, 29);
            this.cusNameTextBox.TabIndex = 7;
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.Location = new System.Drawing.Point(27, 42);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(63, 23);
            this.cusNameLabel.TabIndex = 6;
            this.cusNameLabel.Text = "Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lowerTextBox);
            this.tabPage4.Controls.Add(this.lowerLabel);
            this.tabPage4.Controls.Add(this.moneyConfirmButton);
            this.tabPage4.Controls.Add(this.upperTextBox);
            this.tabPage4.Controls.Add(this.upperLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(455, 165);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Money";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lowerTextBox
            // 
            this.lowerTextBox.Location = new System.Drawing.Point(96, 92);
            this.lowerTextBox.Name = "lowerTextBox";
            this.lowerTextBox.Size = new System.Drawing.Size(181, 29);
            this.lowerTextBox.TabIndex = 15;
            // 
            // lowerLabel
            // 
            this.lowerLabel.AutoSize = true;
            this.lowerLabel.Location = new System.Drawing.Point(29, 95);
            this.lowerLabel.Name = "lowerLabel";
            this.lowerLabel.Size = new System.Drawing.Size(63, 23);
            this.lowerLabel.TabIndex = 14;
            this.lowerLabel.Text = "Lower:";
            // 
            // moneyConfirmButton
            // 
            this.moneyConfirmButton.Location = new System.Drawing.Point(322, 63);
            this.moneyConfirmButton.Name = "moneyConfirmButton";
            this.moneyConfirmButton.Size = new System.Drawing.Size(106, 48);
            this.moneyConfirmButton.TabIndex = 13;
            this.moneyConfirmButton.Text = "Confirm";
            this.moneyConfirmButton.UseVisualStyleBackColor = true;
            this.moneyConfirmButton.Click += new System.EventHandler(this.MoneyConfirmButton_Click);
            // 
            // upperTextBox
            // 
            this.upperTextBox.Location = new System.Drawing.Point(96, 44);
            this.upperTextBox.Name = "upperTextBox";
            this.upperTextBox.Size = new System.Drawing.Size(181, 29);
            this.upperTextBox.TabIndex = 12;
            // 
            // upperLabel
            // 
            this.upperLabel.AutoSize = true;
            this.upperLabel.Location = new System.Drawing.Point(27, 47);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(65, 23);
            this.upperLabel.TabIndex = 11;
            this.upperLabel.Text = "Upper:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 201);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.searchTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl searchTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button IdConfirmButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button comConfirmButton;
        private System.Windows.Forms.TextBox comNameTextBox;
        private System.Windows.Forms.Label comLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox cusAgeTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button cusConfirmButton;
        private System.Windows.Forms.TextBox cusNameTextBox;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox lowerTextBox;
        private System.Windows.Forms.Label lowerLabel;
        private System.Windows.Forms.Button moneyConfirmButton;
        private System.Windows.Forms.TextBox upperTextBox;
        private System.Windows.Forms.Label upperLabel;
    }
}