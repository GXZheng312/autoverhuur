namespace autoverhuur
{
    partial class main_menu
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
            this.KlantenoverzicchtBtn = new System.Windows.Forms.Button();
            this.Autooverzichtbtn = new System.Windows.Forms.Button();
            this.KlantToevoegenBtn = new System.Windows.Forms.Button();
            this.AutotoevoegBtn = new System.Windows.Forms.Button();
            this.ReserverenBtn = new System.Windows.Forms.Button();
            this.EindeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KlantenoverzicchtBtn
            // 
            this.KlantenoverzicchtBtn.Location = new System.Drawing.Point(32, 26);
            this.KlantenoverzicchtBtn.Name = "KlantenoverzicchtBtn";
            this.KlantenoverzicchtBtn.Size = new System.Drawing.Size(128, 65);
            this.KlantenoverzicchtBtn.TabIndex = 0;
            this.KlantenoverzicchtBtn.Text = "klanten overzicht";
            this.KlantenoverzicchtBtn.UseVisualStyleBackColor = true;
            this.KlantenoverzicchtBtn.Click += new System.EventHandler(this.KlantenoverzicchtBtn_Click);
            // 
            // Autooverzichtbtn
            // 
            this.Autooverzichtbtn.Location = new System.Drawing.Point(185, 26);
            this.Autooverzichtbtn.Name = "Autooverzichtbtn";
            this.Autooverzichtbtn.Size = new System.Drawing.Size(120, 71);
            this.Autooverzichtbtn.TabIndex = 1;
            this.Autooverzichtbtn.Text = "Auto overzicht";
            this.Autooverzichtbtn.UseVisualStyleBackColor = true;
            this.Autooverzichtbtn.Click += new System.EventHandler(this.Autooverzichtbtn_Click);
            // 
            // KlantToevoegenBtn
            // 
            this.KlantToevoegenBtn.Location = new System.Drawing.Point(32, 103);
            this.KlantToevoegenBtn.Name = "KlantToevoegenBtn";
            this.KlantToevoegenBtn.Size = new System.Drawing.Size(128, 65);
            this.KlantToevoegenBtn.TabIndex = 2;
            this.KlantToevoegenBtn.Text = "klant toevoegen";
            this.KlantToevoegenBtn.UseVisualStyleBackColor = true;
            this.KlantToevoegenBtn.Click += new System.EventHandler(this.KlantToevoegenBtn_Click);
            // 
            // AutotoevoegBtn
            // 
            this.AutotoevoegBtn.Location = new System.Drawing.Point(185, 113);
            this.AutotoevoegBtn.Name = "AutotoevoegBtn";
            this.AutotoevoegBtn.Size = new System.Drawing.Size(120, 55);
            this.AutotoevoegBtn.TabIndex = 3;
            this.AutotoevoegBtn.Text = "Auto toevoegen";
            this.AutotoevoegBtn.UseVisualStyleBackColor = true;
            this.AutotoevoegBtn.Click += new System.EventHandler(this.AutotoevoegBtn_Click);
            // 
            // ReserverenBtn
            // 
            this.ReserverenBtn.Location = new System.Drawing.Point(32, 200);
            this.ReserverenBtn.Name = "ReserverenBtn";
            this.ReserverenBtn.Size = new System.Drawing.Size(128, 41);
            this.ReserverenBtn.TabIndex = 4;
            this.ReserverenBtn.Text = "Reserveren";
            this.ReserverenBtn.UseVisualStyleBackColor = true;
            this.ReserverenBtn.Click += new System.EventHandler(this.ReserverenBtn_Click);
            // 
            // EindeBtn
            // 
            this.EindeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EindeBtn.Location = new System.Drawing.Point(185, 195);
            this.EindeBtn.Name = "EindeBtn";
            this.EindeBtn.Size = new System.Drawing.Size(126, 50);
            this.EindeBtn.TabIndex = 5;
            this.EindeBtn.Text = "einde";
            this.EindeBtn.UseVisualStyleBackColor = false;
            this.EindeBtn.Click += new System.EventHandler(this.EindeBtn_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 262);
            this.Controls.Add(this.EindeBtn);
            this.Controls.Add(this.ReserverenBtn);
            this.Controls.Add(this.AutotoevoegBtn);
            this.Controls.Add(this.KlantToevoegenBtn);
            this.Controls.Add(this.Autooverzichtbtn);
            this.Controls.Add(this.KlantenoverzicchtBtn);
            this.Name = "main_menu";
            this.Text = "main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KlantenoverzicchtBtn;
        private System.Windows.Forms.Button Autooverzichtbtn;
        private System.Windows.Forms.Button KlantToevoegenBtn;
        private System.Windows.Forms.Button AutotoevoegBtn;
        private System.Windows.Forms.Button ReserverenBtn;
        private System.Windows.Forms.Button EindeBtn;
    }
}