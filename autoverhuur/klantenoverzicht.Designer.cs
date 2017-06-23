namespace autoverhuur
{
    partial class klanteen_overzicht
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klantToevoegenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // klantToevoegenBtn
            // 
            this.klantToevoegenBtn.Location = new System.Drawing.Point(12, 61);
            this.klantToevoegenBtn.Name = "klantToevoegenBtn";
            this.klantToevoegenBtn.Size = new System.Drawing.Size(121, 23);
            this.klantToevoegenBtn.TabIndex = 1;
            this.klantToevoegenBtn.Text = "Klanten Toevoegen";
            this.klantToevoegenBtn.UseVisualStyleBackColor = true;
            this.klantToevoegenBtn.Click += new System.EventHandler(this.klantToevoegenBtn_Click);
            // 
            // klanteen_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 334);
            this.Controls.Add(this.klantToevoegenBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 373);
            this.MinimumSize = new System.Drawing.Size(706, 373);
            this.Name = "klanteen_overzicht";
            this.Text = "klanteen_overzicht";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button klantToevoegenBtn;
    }
}