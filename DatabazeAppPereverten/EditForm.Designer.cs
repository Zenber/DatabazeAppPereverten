namespace DatabazeAppPereverten
{
    partial class EditForm
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
            this.UlozAutoButton = new System.Windows.Forms.Button();
            this.ZnackaComboBox = new System.Windows.Forms.ComboBox();
            this.PalivoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZrusEditovaniButton = new System.Windows.Forms.Button();
            this.SpravneAutoAnoComboBox = new System.Windows.Forms.CheckBox();
            this.SpravneAutoNeComboBox = new System.Windows.Forms.CheckBox();
            this.NastartovaneAutoAnoComboBox = new System.Windows.Forms.CheckBox();
            this.NastartovaneAutoNeComboBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UlozAutoButton
            // 
            this.UlozAutoButton.Location = new System.Drawing.Point(161, 288);
            this.UlozAutoButton.Name = "UlozAutoButton";
            this.UlozAutoButton.Size = new System.Drawing.Size(98, 32);
            this.UlozAutoButton.TabIndex = 0;
            this.UlozAutoButton.Text = "Uloz";
            this.UlozAutoButton.UseVisualStyleBackColor = true;
            this.UlozAutoButton.Click += new System.EventHandler(this.UlozAutoButton_Click);
            // 
            // ZnackaComboBox
            // 
            this.ZnackaComboBox.FormattingEnabled = true;
            this.ZnackaComboBox.Items.AddRange(new object[] {
            "BMW",
            "Audi",
            "Opel",
            "Reno",
            "Skoda"});
            this.ZnackaComboBox.Location = new System.Drawing.Point(100, 74);
            this.ZnackaComboBox.Name = "ZnackaComboBox";
            this.ZnackaComboBox.Size = new System.Drawing.Size(159, 21);
            this.ZnackaComboBox.TabIndex = 1;
            // 
            // PalivoComboBox
            // 
            this.PalivoComboBox.FormattingEnabled = true;
            this.PalivoComboBox.Items.AddRange(new object[] {
            "Disel",
            "Benzin"});
            this.PalivoComboBox.Location = new System.Drawing.Point(100, 117);
            this.PalivoComboBox.Name = "PalivoComboBox";
            this.PalivoComboBox.Size = new System.Drawing.Size(159, 21);
            this.PalivoComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Znacka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spravne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nastartovane";
            // 
            // ZrusEditovaniButton
            // 
            this.ZrusEditovaniButton.Location = new System.Drawing.Point(21, 288);
            this.ZrusEditovaniButton.Name = "ZrusEditovaniButton";
            this.ZrusEditovaniButton.Size = new System.Drawing.Size(98, 32);
            this.ZrusEditovaniButton.TabIndex = 11;
            this.ZrusEditovaniButton.Text = "Zrus";
            this.ZrusEditovaniButton.UseVisualStyleBackColor = true;
            this.ZrusEditovaniButton.Click += new System.EventHandler(this.ZrusEditovaniButton_Click);
            // 
            // SpravneAutoAnoComboBox
            // 
            this.SpravneAutoAnoComboBox.AutoSize = true;
            this.SpravneAutoAnoComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.SpravneAutoAnoComboBox.Location = new System.Drawing.Point(103, 164);
            this.SpravneAutoAnoComboBox.Name = "SpravneAutoAnoComboBox";
            this.SpravneAutoAnoComboBox.Size = new System.Drawing.Size(45, 17);
            this.SpravneAutoAnoComboBox.TabIndex = 12;
            this.SpravneAutoAnoComboBox.Text = "Ano";
            this.SpravneAutoAnoComboBox.UseVisualStyleBackColor = false;
            this.SpravneAutoAnoComboBox.Click += new System.EventHandler(this.SpravneAnoClick);
            // 
            // SpravneAutoNeComboBox
            // 
            this.SpravneAutoNeComboBox.AutoSize = true;
            this.SpravneAutoNeComboBox.Location = new System.Drawing.Point(189, 163);
            this.SpravneAutoNeComboBox.Name = "SpravneAutoNeComboBox";
            this.SpravneAutoNeComboBox.Size = new System.Drawing.Size(40, 17);
            this.SpravneAutoNeComboBox.TabIndex = 13;
            this.SpravneAutoNeComboBox.Text = "Ne";
            this.SpravneAutoNeComboBox.UseVisualStyleBackColor = true;
            this.SpravneAutoNeComboBox.Click += new System.EventHandler(this.SpravneNeClick);
            // 
            // NastartovaneAutoAnoComboBox
            // 
            this.NastartovaneAutoAnoComboBox.AutoSize = true;
            this.NastartovaneAutoAnoComboBox.Location = new System.Drawing.Point(103, 199);
            this.NastartovaneAutoAnoComboBox.Name = "NastartovaneAutoAnoComboBox";
            this.NastartovaneAutoAnoComboBox.Size = new System.Drawing.Size(45, 17);
            this.NastartovaneAutoAnoComboBox.TabIndex = 14;
            this.NastartovaneAutoAnoComboBox.Text = "Ano";
            this.NastartovaneAutoAnoComboBox.UseVisualStyleBackColor = true;
            this.NastartovaneAutoAnoComboBox.Click += new System.EventHandler(this.NastartovaneAnoClick);
            // 
            // NastartovaneAutoNeComboBox
            // 
            this.NastartovaneAutoNeComboBox.AutoSize = true;
            this.NastartovaneAutoNeComboBox.Location = new System.Drawing.Point(189, 199);
            this.NastartovaneAutoNeComboBox.Name = "NastartovaneAutoNeComboBox";
            this.NastartovaneAutoNeComboBox.Size = new System.Drawing.Size(40, 17);
            this.NastartovaneAutoNeComboBox.TabIndex = 15;
            this.NastartovaneAutoNeComboBox.Text = "Ne";
            this.NastartovaneAutoNeComboBox.UseVisualStyleBackColor = true;
            this.NastartovaneAutoNeComboBox.Click += new System.EventHandler(this.NastartovaneNeClick);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 359);
            this.Controls.Add(this.NastartovaneAutoNeComboBox);
            this.Controls.Add(this.NastartovaneAutoAnoComboBox);
            this.Controls.Add(this.SpravneAutoNeComboBox);
            this.Controls.Add(this.SpravneAutoAnoComboBox);
            this.Controls.Add(this.ZrusEditovaniButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PalivoComboBox);
            this.Controls.Add(this.ZnackaComboBox);
            this.Controls.Add(this.UlozAutoButton);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UlozAutoButton;
        private System.Windows.Forms.ComboBox ZnackaComboBox;
        private System.Windows.Forms.ComboBox PalivoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ZrusEditovaniButton;
        private System.Windows.Forms.CheckBox SpravneAutoAnoComboBox;
        private System.Windows.Forms.CheckBox SpravneAutoNeComboBox;
        private System.Windows.Forms.CheckBox NastartovaneAutoAnoComboBox;
        private System.Windows.Forms.CheckBox NastartovaneAutoNeComboBox;
    }
}