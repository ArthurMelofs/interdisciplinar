
namespace interdisciplinar
{
    partial class Telainicia
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
            this.dgvTelainicial = new System.Windows.Forms.DataGridView();
            this.bntAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelainicial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelainicial
            // 
            this.dgvTelainicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelainicial.Location = new System.Drawing.Point(12, 12);
            this.dgvTelainicial.Name = "dgvTelainicial";
            this.dgvTelainicial.Size = new System.Drawing.Size(776, 383);
            this.dgvTelainicial.TabIndex = 0;
            this.dgvTelainicial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(142, 415);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(75, 23);
            this.bntAlterar.TabIndex = 1;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            // 
            // Telainicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.dgvTelainicial);
            this.Name = "Telainicia";
            this.Text = "Telainicia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelainicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelainicial;
        private System.Windows.Forms.Button bntAlterar;
    }
}