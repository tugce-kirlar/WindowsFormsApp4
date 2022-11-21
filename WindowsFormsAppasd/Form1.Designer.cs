
namespace WindowsFormsAppasd
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.btngetir = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.tMetin = new System.Windows.Forms.RichTextBox();
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SAciklama
            // 
            this.SAciklama.Name = "SAciklama";
            this.SAciklama.Size = new System.Drawing.Size(0, 17);
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(12, 271);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(75, 23);
            this.btngetir.TabIndex = 6;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(12, 300);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 5;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            // 
            // tMetin
            // 
            this.tMetin.Location = new System.Drawing.Point(12, 6);
            this.tMetin.Name = "tMetin";
            this.tMetin.Size = new System.Drawing.Size(458, 259);
            this.tMetin.TabIndex = 4;
            this.tMetin.Text = "";
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(393, 271);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 23);
            this.btnkapat.TabIndex = 9;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(393, 300);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 368);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btngetir);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.tMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SAciklama;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.RichTextBox tMetin;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnsil;
    }
}

