
namespace WindowsFormsApp4
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
            this.tMetin = new System.Windows.Forms.RichTextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btngetir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tMetin
            // 
            this.tMetin.Location = new System.Drawing.Point(12, 12);
            this.tMetin.Name = "tMetin";
            this.tMetin.Size = new System.Drawing.Size(458, 259);
            this.tMetin.TabIndex = 0;
            this.tMetin.Text = "";
            this.tMetin.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(394, 277);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click_1);
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(12, 277);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(75, 23);
            this.btngetir.TabIndex = 2;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SAciklama
            // 
            this.SAciklama.Name = "SAciklama";
            this.SAciklama.Size = new System.Drawing.Size(0, 17);
            this.SAciklama.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btngetir);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.tMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tMetin;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SAciklama;
    }
}

