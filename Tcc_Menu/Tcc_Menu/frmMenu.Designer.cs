namespace Tcc_Menu
{
    partial class frmMenu
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
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnDinh = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Tcc_Menu.Properties.Resources.x_button;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(756, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 54);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Funcionário";
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackgroundImage = global::Tcc_Menu.Properties.Resources.CAIXA;
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Location = new System.Drawing.Point(40, 103);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(244, 157);
            this.btnCaixa.TabIndex = 8;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnConta
            // 
            this.btnConta.BackgroundImage = global::Tcc_Menu.Properties.Resources.CONTAS;
            this.btnConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConta.FlatAppearance.BorderSize = 0;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.Location = new System.Drawing.Point(40, 347);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(244, 157);
            this.btnConta.TabIndex = 9;
            this.btnConta.UseVisualStyleBackColor = true;
            // 
            // btnDinh
            // 
            this.btnDinh.BackgroundImage = global::Tcc_Menu.Properties.Resources.DINHEIRO;
            this.btnDinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDinh.FlatAppearance.BorderSize = 0;
            this.btnDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinh.Location = new System.Drawing.Point(517, 116);
            this.btnDinh.Name = "btnDinh";
            this.btnDinh.Size = new System.Drawing.Size(244, 157);
            this.btnDinh.TabIndex = 10;
            this.btnDinh.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackgroundImage = global::Tcc_Menu.Properties.Resources.ESTOQUE;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Location = new System.Drawing.Point(517, 347);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(244, 157);
            this.btnEstoque.TabIndex = 11;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tcc_Menu.Properties.Resources._002_info;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(756, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 54);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnDinh);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //    private System.Windows.Forms.PictureBox pbContas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnDinh;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button button1;


    }
}

