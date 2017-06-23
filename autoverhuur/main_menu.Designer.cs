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
            this.klantenOverzichtBtn = new System.Windows.Forms.Button();
            this.autoOverzichtBtn = new System.Windows.Forms.Button();
            this.reseveerBtn = new System.Windows.Forms.Button();
            this.EindeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // klantenOverzichtBtn
            // 
            this.klantenOverzichtBtn.Location = new System.Drawing.Point(408, 63);
            this.klantenOverzichtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.klantenOverzichtBtn.Name = "klantenOverzichtBtn";
            this.klantenOverzichtBtn.Size = new System.Drawing.Size(97, 46);
            this.klantenOverzichtBtn.TabIndex = 0;
            this.klantenOverzichtBtn.Text = "klanten overzicht";
            this.klantenOverzichtBtn.UseVisualStyleBackColor = true;
            this.klantenOverzichtBtn.Click += new System.EventHandler(this.KlantenoverzicchtBtn_Click);
            // 
            // autoOverzichtBtn
            // 
            this.autoOverzichtBtn.Location = new System.Drawing.Point(407, 13);
            this.autoOverzichtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.autoOverzichtBtn.Name = "autoOverzichtBtn";
            this.autoOverzichtBtn.Size = new System.Drawing.Size(98, 46);
            this.autoOverzichtBtn.TabIndex = 1;
            this.autoOverzichtBtn.Text = "Auto overzicht";
            this.autoOverzichtBtn.UseVisualStyleBackColor = true;
            this.autoOverzichtBtn.Click += new System.EventHandler(this.Autooverzichtbtn_Click);
            // 
            // reseveerBtn
            // 
            this.reseveerBtn.Location = new System.Drawing.Point(407, 113);
            this.reseveerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reseveerBtn.Name = "reseveerBtn";
            this.reseveerBtn.Size = new System.Drawing.Size(98, 46);
            this.reseveerBtn.TabIndex = 4;
            this.reseveerBtn.Text = "Reserveren";
            this.reseveerBtn.UseVisualStyleBackColor = true;
            this.reseveerBtn.Click += new System.EventHandler(this.ReserverenBtn_Click);
            // 
            // EindeBtn
            // 
            this.EindeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EindeBtn.Location = new System.Drawing.Point(407, 284);
            this.EindeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EindeBtn.Name = "EindeBtn";
            this.EindeBtn.Size = new System.Drawing.Size(97, 46);
            this.EindeBtn.TabIndex = 5;
            this.EindeBtn.Text = "einde";
            this.EindeBtn.UseVisualStyleBackColor = false;
            this.EindeBtn.Click += new System.EventHandler(this.EindeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 315);
            this.dataGridView1.TabIndex = 6;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EindeBtn);
            this.Controls.Add(this.reseveerBtn);
            this.Controls.Add(this.autoOverzichtBtn);
            this.Controls.Add(this.klantenOverzichtBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(532, 378);
            this.MinimumSize = new System.Drawing.Size(532, 378);
            this.Name = "main_menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "main menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button klantenOverzichtBtn;
        private System.Windows.Forms.Button autoOverzichtBtn;
        private System.Windows.Forms.Button reseveerBtn;
        private System.Windows.Forms.Button EindeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}