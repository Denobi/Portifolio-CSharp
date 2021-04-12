namespace WindowsFormsApplication1
{
    partial class FrmPesq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesq));
            this.txbPesq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.pnlComp = new System.Windows.Forms.Panel();
            this.lblComp = new System.Windows.Forms.Label();
            this.pnlComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPesq
            // 
            this.txbPesq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPesq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesq.Location = new System.Drawing.Point(177, 147);
            this.txbPesq.Name = "txbPesq";
            this.txbPesq.Size = new System.Drawing.Size(314, 19);
            this.txbPesq.TabIndex = 0;
            this.txbPesq.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbPesq_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOTO FACIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "PESQUISAR:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(46, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(496, 56);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADICIONAR NOVO NÚMERO";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(12, 243);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(101, 36);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.x_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(515, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search;
            this.btnPesq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesq.FlatAppearance.BorderSize = 0;
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Location = new System.Drawing.Point(498, 147);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(44, 41);
            this.btnPesq.TabIndex = 2;
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // btnComp
            // 
            this.btnComp.FlatAppearance.BorderSize = 0;
            this.btnComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComp.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.ForeColor = System.Drawing.Color.White;
            this.btnComp.Location = new System.Drawing.Point(46, 345);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(496, 56);
            this.btnComp.TabIndex = 6;
            this.btnComp.Text = "COMPARAR";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // pnlComp
            // 
            this.pnlComp.BackColor = System.Drawing.Color.Honeydew;
            this.pnlComp.Controls.Add(this.lblComp);
            this.pnlComp.Location = new System.Drawing.Point(162, 199);
            this.pnlComp.Name = "pnlComp";
            this.pnlComp.Size = new System.Drawing.Size(379, 146);
            this.pnlComp.TabIndex = 7;
            this.pnlComp.Visible = false;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(12, 15);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(51, 20);
            this.lblComp.TabIndex = 0;
            this.lblComp.Text = "label3";
            // 
            // FrmPesq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(606, 490);
            this.Controls.Add(this.pnlComp);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPesq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesq";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmPesq_Load);
            this.pnlComp.ResumeLayout(false);
            this.pnlComp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Panel pnlComp;
        private System.Windows.Forms.Label lblComp;
    }
}

