namespace autoverhuur
{
    partial class autoverhuurForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.autoToevoegenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "autoverhuur 2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(405, 232);
            this.dataGridView2.TabIndex = 0;
            // 
            // autoToevoegenBtn
            // 
            this.autoToevoegenBtn.Location = new System.Drawing.Point(12, 75);
            this.autoToevoegenBtn.Name = "autoToevoegenBtn";
            this.autoToevoegenBtn.Size = new System.Drawing.Size(101, 24);
            this.autoToevoegenBtn.TabIndex = 1;
            this.autoToevoegenBtn.Text = "Auto Toevoegen";
            this.autoToevoegenBtn.UseVisualStyleBackColor = true;
            this.autoToevoegenBtn.Click += new System.EventHandler(this.autoToevoegenBtn_Click);
            // 
            // autoverhuurForm
            // 
            this.ClientSize = new System.Drawing.Size(425, 349);
            this.Controls.Add(this.autoToevoegenBtn);
            this.Controls.Add(this.dataGridView2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 388);
            this.MinimumSize = new System.Drawing.Size(441, 388);
            this.Name = "autoverhuurForm";
            this.Text = "autoverhuur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button autoToevoegenBtn;
    }
}

