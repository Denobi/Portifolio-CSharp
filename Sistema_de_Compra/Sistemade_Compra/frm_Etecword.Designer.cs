namespace Sistemade_Compra
{
    partial class frm_Etecword
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
            this.btnLer = new System.Windows.Forms.Button();
            this.btnGrav = new System.Windows.Forms.Button();
            this.txtNomeArq = new System.Windows.Forms.TextBox();
            this.btnFonte = new System.Windows.Forms.Button();
            this.btnCor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.rtbetecWord = new System.Windows.Forms.RichTextBox();
            this.txtER = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(12, 12);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(93, 23);
            this.btnLer.TabIndex = 0;
            this.btnLer.Text = "Ler arquivo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnGrav
            // 
            this.btnGrav.Location = new System.Drawing.Point(113, 12);
            this.btnGrav.Name = "btnGrav";
            this.btnGrav.Size = new System.Drawing.Size(93, 23);
            this.btnGrav.TabIndex = 1;
            this.btnGrav.Text = "Gravar arquivo";
            this.btnGrav.UseVisualStyleBackColor = true;
            this.btnGrav.Click += new System.EventHandler(this.btnGrav_Click);
            // 
            // txtNomeArq
            // 
            this.txtNomeArq.Location = new System.Drawing.Point(84, 51);
            this.txtNomeArq.Name = "txtNomeArq";
            this.txtNomeArq.Size = new System.Drawing.Size(311, 20);
            this.txtNomeArq.TabIndex = 3;
            // 
            // btnFonte
            // 
            this.btnFonte.Location = new System.Drawing.Point(311, 12);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(93, 23);
            this.btnFonte.TabIndex = 1;
            this.btnFonte.Text = "Fonte";
            this.btnFonte.UseVisualStyleBackColor = true;
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(212, 12);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(93, 23);
            this.btnCor.TabIndex = 0;
            this.btnCor.Text = "Cor";
            this.btnCor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arquivo :";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // rtbetecWord
            // 
            this.rtbetecWord.Location = new System.Drawing.Point(12, 94);
            this.rtbetecWord.Name = "rtbetecWord";
            this.rtbetecWord.Size = new System.Drawing.Size(514, 388);
            this.rtbetecWord.TabIndex = 4;
            this.rtbetecWord.Text = "";
            // 
            // txtER
            // 
            this.txtER.Location = new System.Drawing.Point(415, 15);
            this.txtER.Name = "txtER";
            this.txtER.Size = new System.Drawing.Size(111, 20);
            this.txtER.TabIndex = 3;
            // 
            // frm_Etecword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 494);
            this.Controls.Add(this.rtbetecWord);
            this.Controls.Add(this.txtER);
            this.Controls.Add(this.txtNomeArq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFonte);
            this.Controls.Add(this.btnGrav);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.btnLer);
            this.Name = "frm_Etecword";
            this.Text = "frm_Etecword";
            this.Load += new System.EventHandler(this.frm_Etecword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnGrav;
        private System.Windows.Forms.TextBox txtNomeArq;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.RichTextBox rtbetecWord;
        private System.Windows.Forms.TextBox txtER;
    }
}