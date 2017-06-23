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
            this.naamTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.achternaamTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adresTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postcodeTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.huisnummerTxb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naamTxb
            // 
            this.naamTxb.Location = new System.Drawing.Point(132, 12);
            this.naamTxb.Name = "naamTxb";
            this.naamTxb.Size = new System.Drawing.Size(137, 20);
            this.naamTxb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Achternaam";
            // 
            // achternaamTxb
            // 
            this.achternaamTxb.Location = new System.Drawing.Point(132, 38);
            this.achternaamTxb.Name = "achternaamTxb";
            this.achternaamTxb.Size = new System.Drawing.Size(137, 20);
            this.achternaamTxb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // adresTxb
            // 
            this.adresTxb.Location = new System.Drawing.Point(132, 64);
            this.adresTxb.Name = "adresTxb";
            this.adresTxb.Size = new System.Drawing.Size(137, 20);
            this.adresTxb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postcode";
            // 
            // postcodeTxb
            // 
            this.postcodeTxb.Location = new System.Drawing.Point(132, 90);
            this.postcodeTxb.Name = "postcodeTxb";
            this.postcodeTxb.Size = new System.Drawing.Size(137, 20);
            this.postcodeTxb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Huisnummer";
            // 
            // huisnummerTxb
            // 
            this.huisnummerTxb.Location = new System.Drawing.Point(132, 116);
            this.huisnummerTxb.Name = "huisnummerTxb";
            this.huisnummerTxb.Size = new System.Drawing.Size(137, 20);
            this.huisnummerTxb.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "sluiten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // klant_toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.huisnummerTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postcodeTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.achternaamTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naamTxb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "klant_toevoegen";
            this.Text = "klant toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naamTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox achternaamTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postcodeTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox huisnummerTxb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}