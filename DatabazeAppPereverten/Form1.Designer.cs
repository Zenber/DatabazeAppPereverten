using System.Windows.Forms;

namespace DatabazeAppPereverten
{
    partial class Form1
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
            this.AutaList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Znacka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Palivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JeSpravne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JeNastartovane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NactiButton = new System.Windows.Forms.Button();
            this.SmazSeznamButton = new System.Windows.Forms.Button();
            this.UpravButton = new System.Windows.Forms.Button();
            this.SmazButton = new System.Windows.Forms.Button();
            this.NastartujButton = new System.Windows.Forms.Button();
            this.OpravButton = new System.Windows.Forms.Button();
            this.ZastavButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutaList
            // 
            this.AutaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Znacka,
            this.Palivo,
            this.JeSpravne,
            this.JeNastartovane});
            this.AutaList.FullRowSelect = true;
            this.AutaList.HideSelection = false;
            this.AutaList.Location = new System.Drawing.Point(12, 12);
            this.AutaList.Name = "AutaList";
            this.AutaList.Size = new System.Drawing.Size(643, 342);
            this.AutaList.TabIndex = 0;
            this.AutaList.UseCompatibleStateImageBehavior = false;
            this.AutaList.View = System.Windows.Forms.View.Details;
            this.AutaList.SelectedIndexChanged += new System.EventHandler(this.AutaList_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Znacka
            // 
            this.Znacka.Text = "Znacka";
            this.Znacka.Width = 150;
            // 
            // Palivo
            // 
            this.Palivo.Text = "Palivo";
            this.Palivo.Width = 150;
            // 
            // JeSpravne
            // 
            this.JeSpravne.Text = "Je Spravne";
            this.JeSpravne.Width = 150;
            // 
            // JeNastartovane
            // 
            this.JeNastartovane.Text = "JeNastartovane";
            this.JeNastartovane.Width = 128;
            // 
            // NactiButton
            // 
            this.NactiButton.Location = new System.Drawing.Point(12, 383);
            this.NactiButton.Name = "NactiButton";
            this.NactiButton.Size = new System.Drawing.Size(98, 38);
            this.NactiButton.TabIndex = 1;
            this.NactiButton.Text = "Nacti";
            this.NactiButton.UseVisualStyleBackColor = true;
            this.NactiButton.Click += new System.EventHandler(this.NactiButton_Click);
            // 
            // SmazSeznamButton
            // 
            this.SmazSeznamButton.Location = new System.Drawing.Point(116, 383);
            this.SmazSeznamButton.Name = "SmazSeznamButton";
            this.SmazSeznamButton.Size = new System.Drawing.Size(98, 38);
            this.SmazSeznamButton.TabIndex = 2;
            this.SmazSeznamButton.Text = "Zmaz vse";
            this.SmazSeznamButton.UseVisualStyleBackColor = true;
            this.SmazSeznamButton.Click += new System.EventHandler(this.SmazSeznamButton_Click);
            // 
            // UpravButton
            // 
            this.UpravButton.Location = new System.Drawing.Point(529, 383);
            this.UpravButton.Name = "UpravButton";
            this.UpravButton.Size = new System.Drawing.Size(126, 38);
            this.UpravButton.TabIndex = 3;
            this.UpravButton.Text = "Uprav";
            this.UpravButton.UseVisualStyleBackColor = true;
            this.UpravButton.Click += new System.EventHandler(this.UpravButton_Click);
            // 
            // SmazButton
            // 
            this.SmazButton.Location = new System.Drawing.Point(397, 383);
            this.SmazButton.Name = "SmazButton";
            this.SmazButton.Size = new System.Drawing.Size(126, 38);
            this.SmazButton.TabIndex = 4;
            this.SmazButton.Text = "Smaz";
            this.SmazButton.UseVisualStyleBackColor = true;
            this.SmazButton.Click += new System.EventHandler(this.SmazButton_Click);
            // 
            // NastartujButton
            // 
            this.NastartujButton.Location = new System.Drawing.Point(685, 32);
            this.NastartujButton.Name = "NastartujButton";
            this.NastartujButton.Size = new System.Drawing.Size(90, 30);
            this.NastartujButton.TabIndex = 5;
            this.NastartujButton.Text = "Nastartuj";
            this.NastartujButton.UseVisualStyleBackColor = true;
            this.NastartujButton.Click += new System.EventHandler(this.NastartujButton_Click);
            // 
            // OpravButton
            // 
            this.OpravButton.Location = new System.Drawing.Point(685, 124);
            this.OpravButton.Name = "OpravButton";
            this.OpravButton.Size = new System.Drawing.Size(90, 30);
            this.OpravButton.TabIndex = 6;
            this.OpravButton.Text = "Oprav";
            this.OpravButton.UseVisualStyleBackColor = true;
            this.OpravButton.Click += new System.EventHandler(this.OpravButton_Click);
            // 
            // ZastavButton
            // 
            this.ZastavButton.Location = new System.Drawing.Point(685, 78);
            this.ZastavButton.Name = "ZastavButton";
            this.ZastavButton.Size = new System.Drawing.Size(90, 30);
            this.ZastavButton.TabIndex = 7;
            this.ZastavButton.Text = "Zastav";
            this.ZastavButton.UseVisualStyleBackColor = true;
            this.ZastavButton.Click += new System.EventHandler(this.ZastavButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZastavButton);
            this.Controls.Add(this.OpravButton);
            this.Controls.Add(this.NastartujButton);
            this.Controls.Add(this.SmazButton);
            this.Controls.Add(this.UpravButton);
            this.Controls.Add(this.SmazSeznamButton);
            this.Controls.Add(this.NactiButton);
            this.Controls.Add(this.AutaList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AutaList;
        private ColumnHeader Znacka;
        private ColumnHeader Palivo;
        private ColumnHeader JeSpravne;
        private ColumnHeader JeNastartovane;
        private Button NactiButton;
        private Button SmazSeznamButton;
        private Button UpravButton;
        private Button SmazButton;
        private ColumnHeader Id;
        private Button NastartujButton;
        private Button OpravButton;
        private Button ZastavButton;
    }
}

