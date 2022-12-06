
namespace MiniSqlDerleyici
{
    partial class frmDerleyici
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
            this.btnCalıstır = new System.Windows.Forms.Button();
            this.rchtxtSorgu = new System.Windows.Forms.RichTextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCalıstır
            // 
            this.btnCalıstır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalıstır.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCalıstır.Location = new System.Drawing.Point(710, 11);
            this.btnCalıstır.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalıstır.Name = "btnCalıstır";
            this.btnCalıstır.Size = new System.Drawing.Size(184, 74);
            this.btnCalıstır.TabIndex = 1;
            this.btnCalıstır.Text = "Çalıştır";
            this.btnCalıstır.UseVisualStyleBackColor = false;
            this.btnCalıstır.Click += new System.EventHandler(this.btnCalıstır_Click);
            // 
            // rchtxtSorgu
            // 
            this.rchtxtSorgu.Location = new System.Drawing.Point(2, 0);
            this.rchtxtSorgu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchtxtSorgu.Name = "rchtxtSorgu";
            this.rchtxtSorgu.Size = new System.Drawing.Size(702, 190);
            this.rchtxtSorgu.TabIndex = 2;
            this.rchtxtSorgu.Text = "";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnDuzenle.Location = new System.Drawing.Point(711, 99);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(183, 73);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Ekle-Sil-Güncelle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // frmDerleyici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(896, 485);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.rchtxtSorgu);
            this.Controls.Add(this.btnCalıstır);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDerleyici";
            this.Text = "frmDerleyici";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalıstır;
        private System.Windows.Forms.RichTextBox rchtxtSorgu;
        private System.Windows.Forms.Button btnDuzenle;
    }
}