namespace autoverhuur
{
    partial class klant_toevoegen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VoornaamTxb = new System.Windows.Forms.TextBox();
            this.AchternaamTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GeboortedtmBtn = new System.Windows.Forms.TextBox();
            this.MainmenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam :";
            // 
            // VoornaamTxb
            // 
            this.VoornaamTxb.Location = new System.Drawing.Point(208, 53);
            this.VoornaamTxb.Name = "VoornaamTxb";
            this.VoornaamTxb.Size = new System.Drawing.Size(100, 26);
            this.VoornaamTxb.TabIndex = 2;
            // 
            // AchternaamTxb
            // 
            this.AchternaamTxb.Location = new System.Drawing.Point(208, 95);
            this.AchternaamTxb.Name = "AchternaamTxb";
            this.AchternaamTxb.Size = new System.Drawing.Size(100, 26);
            this.AchternaamTxb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geboortedatum :";
            // 
            // GeboortedtmBtn
            // 
            this.GeboortedtmBtn.Location = new System.Drawing.Point(208, 137);
            this.GeboortedtmBtn.Name = "GeboortedtmBtn";
            this.GeboortedtmBtn.Size = new System.Drawing.Size(100, 26);
            this.GeboortedtmBtn.TabIndex = 5;
            // 
            // MainmenuBtn
            // 
            this.MainmenuBtn.Location = new System.Drawing.Point(0, 1);
            this.MainmenuBtn.Name = "MainmenuBtn";
            this.MainmenuBtn.Size = new System.Drawing.Size(120, 38);
            this.MainmenuBtn.TabIndex = 6;
            this.MainmenuBtn.Text = "Main Menu";
            this.MainmenuBtn.UseVisualStyleBackColor = true;
            this.MainmenuBtn.Click += new System.EventHandler(this.MainmenuBtn_Click);
            // 
            // klant_toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 338);
            this.Controls.Add(this.MainmenuBtn);
            this.Controls.Add(this.GeboortedtmBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AchternaamTxb);
            this.Controls.Add(this.VoornaamTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "klant_toevoegen";
            this.Text = "klant toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VoornaamTxb;
        private System.Windows.Forms.TextBox AchternaamTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GeboortedtmBtn;
        private System.Windows.Forms.Button MainmenuBtn;
    }
}