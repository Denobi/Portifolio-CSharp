namespace WindowsFormsApplication1
{
    partial class frmCaixa
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
            this.pnFrente = new System.Windows.Forms.Panel();
            this.pnProd = new System.Windows.Forms.Panel();
            this.pnVendas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnFrente.SuspendLayout();
            this.pnProd.SuspendLayout();
            this.pnVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFrente
            // 
            this.pnFrente.Controls.Add(this.pnProd);
            this.pnFrente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFrente.Location = new System.Drawing.Point(0, 0);
            this.pnFrente.Name = "pnFrente";
            this.pnFrente.Size = new System.Drawing.Size(833, 502);
            this.pnFrente.TabIndex = 0;
            // 
            // pnProd
            // 
            this.pnProd.Controls.Add(this.pnVendas);
            this.pnProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProd.Location = new System.Drawing.Point(0, 0);
            this.pnProd.Name = "pnProd";
            this.pnProd.Size = new System.Drawing.Size(833, 502);
            this.pnProd.TabIndex = 0;
            // 
            // pnVendas
            // 
            this.pnVendas.Controls.Add(this.button2);
            this.pnVendas.Controls.Add(this.button3);
            this.pnVendas.Controls.Add(this.button1);
            this.pnVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnVendas.Location = new System.Drawing.Point(0, 0);
            this.pnVendas.Name = "pnVendas";
            this.pnVendas.Size = new System.Drawing.Size(833, 502);
            this.pnVendas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 502);
            this.Controls.Add(this.pnFrente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.pnFrente.ResumeLayout(false);
            this.pnProd.ResumeLayout(false);
            this.pnVendas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFrente;
        private System.Windows.Forms.Panel pnProd;
        private System.Windows.Forms.Panel pnVendas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

