namespace ODEV_1__V1_
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
            this.btn_oncelikli = new System.Windows.Forms.Button();
            this.txt_sonra = new System.Windows.Forms.TextBox();
            this.txt_once = new System.Windows.Forms.TextBox();
            this.btn_dizigetir = new System.Windows.Forms.Button();
            this.btn_karsila = new System.Windows.Forms.Button();
            this.txt_karsila = new System.Windows.Forms.TextBox();
            this.btnKazanc = new System.Windows.Forms.Button();
            this.txt_kazanc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_oncelikli
            // 
            this.btn_oncelikli.Location = new System.Drawing.Point(240, 609);
            this.btn_oncelikli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_oncelikli.Name = "btn_oncelikli";
            this.btn_oncelikli.Size = new System.Drawing.Size(204, 28);
            this.btn_oncelikli.TabIndex = 9;
            this.btn_oncelikli.Text = "Öncelikli Kuyruk Sıralaması";
            this.btn_oncelikli.UseVisualStyleBackColor = true;
            this.btn_oncelikli.Click += new System.EventHandler(this.btn_oncelikli_Click);
            // 
            // txt_sonra
            // 
            this.txt_sonra.Location = new System.Drawing.Point(16, 199);
            this.txt_sonra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sonra.Multiline = true;
            this.txt_sonra.Name = "txt_sonra";
            this.txt_sonra.Size = new System.Drawing.Size(845, 196);
            this.txt_sonra.TabIndex = 7;
            // 
            // txt_once
            // 
            this.txt_once.AcceptsReturn = true;
            this.txt_once.Location = new System.Drawing.Point(16, 2);
            this.txt_once.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_once.Multiline = true;
            this.txt_once.Name = "txt_once";
            this.txt_once.Size = new System.Drawing.Size(845, 189);
            this.txt_once.TabIndex = 8;
            // 
            // btn_dizigetir
            // 
            this.btn_dizigetir.Location = new System.Drawing.Point(16, 609);
            this.btn_dizigetir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dizigetir.Name = "btn_dizigetir";
            this.btn_dizigetir.Size = new System.Drawing.Size(196, 28);
            this.btn_dizigetir.TabIndex = 6;
            this.btn_dizigetir.Text = "Kuyruk Sıralama";
            this.btn_dizigetir.UseVisualStyleBackColor = true;
            this.btn_dizigetir.Click += new System.EventHandler(this.btn_dizigetir_Click);
            // 
            // btn_karsila
            // 
            this.btn_karsila.Location = new System.Drawing.Point(464, 609);
            this.btn_karsila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_karsila.Name = "btn_karsila";
            this.btn_karsila.Size = new System.Drawing.Size(196, 28);
            this.btn_karsila.TabIndex = 10;
            this.btn_karsila.Text = "Karşılaştır";
            this.btn_karsila.UseVisualStyleBackColor = true;
            this.btn_karsila.Click += new System.EventHandler(this.btn_karsila_Click);
            // 
            // txt_karsila
            // 
            this.txt_karsila.Location = new System.Drawing.Point(16, 404);
            this.txt_karsila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_karsila.Multiline = true;
            this.txt_karsila.Name = "txt_karsila";
            this.txt_karsila.Size = new System.Drawing.Size(845, 117);
            this.txt_karsila.TabIndex = 11;
            // 
            // btnKazanc
            // 
            this.btnKazanc.Location = new System.Drawing.Point(695, 609);
            this.btnKazanc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKazanc.Name = "btnKazanc";
            this.btnKazanc.Size = new System.Drawing.Size(168, 28);
            this.btnKazanc.TabIndex = 12;
            this.btnKazanc.Text = "Kazanç";
            this.btnKazanc.UseVisualStyleBackColor = true;
            this.btnKazanc.Click += new System.EventHandler(this.btnKazanc_Click);
            // 
            // txt_kazanc
            // 
            this.txt_kazanc.Location = new System.Drawing.Point(16, 529);
            this.txt_kazanc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kazanc.Multiline = true;
            this.txt_kazanc.Name = "txt_kazanc";
            this.txt_kazanc.Size = new System.Drawing.Size(845, 64);
            this.txt_kazanc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 652);
            this.Controls.Add(this.txt_kazanc);
            this.Controls.Add(this.btnKazanc);
            this.Controls.Add(this.txt_karsila);
            this.Controls.Add(this.btn_karsila);
            this.Controls.Add(this.btn_oncelikli);
            this.Controls.Add(this.txt_sonra);
            this.Controls.Add(this.txt_once);
            this.Controls.Add(this.btn_dizigetir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Otopark Bilgi Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_oncelikli;
        private System.Windows.Forms.TextBox txt_sonra;
        private System.Windows.Forms.TextBox txt_once;
        private System.Windows.Forms.Button btn_dizigetir;
        private System.Windows.Forms.Button btn_karsila;
        private System.Windows.Forms.TextBox txt_karsila;
        private System.Windows.Forms.Button btnKazanc;
        private System.Windows.Forms.TextBox txt_kazanc;
    }
}

