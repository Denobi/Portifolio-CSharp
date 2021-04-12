namespace Tcc_Menu
{
    partial class FrmEstoque
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
            this.components = new System.ComponentModel.Container();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValUni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExclud = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMensag = new System.Windows.Forms.Label();
            this.tbprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGC = new System.Windows.Forms.Button();
            this.pnBarras = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesq
            // 
            this.txtPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesq.Location = new System.Drawing.Point(230, 52);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(236, 23);
            this.txtPesq.TabIndex = 0;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.Location = new System.Drawing.Point(151, 92);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(220, 26);
            this.txtNomeProd.TabIndex = 2;
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(151, 147);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(220, 26);
            this.txtQtd.TabIndex = 3;
            // 
            // txtValUni
            // 
            this.txtValUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValUni.Location = new System.Drawing.Point(151, 190);
            this.txtValUni.Name = "txtValUni";
            this.txtValUni.Size = new System.Drawing.Size(220, 26);
            this.txtValUni.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PESQUISAR POR NOME \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Unitario";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(498, 48);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(95, 27);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "PESQUISAR";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 505);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 43);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "NOVO";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExclud
            // 
            this.btnExclud.Location = new System.Drawing.Point(276, 505);
            this.btnExclud.Name = "btnExclud";
            this.btnExclud.Size = new System.Drawing.Size(107, 43);
            this.btnExclud.TabIndex = 10;
            this.btnExclud.Text = "EXCLUIR";
            this.btnExclud.UseVisualStyleBackColor = true;
            this.btnExclud.Click += new System.EventHandler(this.btnExclud_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 505);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 43);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(536, 505);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(107, 43);
            this.btnCad.TabIndex = 12;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(146, 505);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(107, 43);
            this.btnAlt.TabIndex = 9;
            this.btnAlt.Text = "ALTERAR";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 343);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(646, 130);
            this.dgvEstoque.TabIndex = 7;
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo de Barra";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.Location = new System.Drawing.Point(16, 45);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(226, 53);
            this.txtCodBarra.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodBarra);
            this.groupBox1.Location = new System.Drawing.Point(402, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblMensag
            // 
            this.lblMensag.AutoSize = true;
            this.lblMensag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensag.Location = new System.Drawing.Point(29, 477);
            this.lblMensag.Name = "lblMensag";
            this.lblMensag.Size = new System.Drawing.Size(0, 25);
            this.lblMensag.TabIndex = 17;
            // 
            // tbprodBindingSource
            // 
            this.tbprodBindingSource.DataMember = "tb_prod";
            // 
            // btnGC
            // 
            this.btnGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGC.Location = new System.Drawing.Point(460, 244);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(198, 75);
            this.btnGC.TabIndex = 6;
            this.btnGC.Text = "GERAR CODIGO";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnBarras
            // 
            this.pnBarras.Location = new System.Drawing.Point(12, 222);
            this.pnBarras.Name = "pnBarras";
            this.pnBarras.Size = new System.Drawing.Size(442, 115);
            this.pnBarras.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Tcc_Menu.Properties.Resources.x_button;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(634, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 32);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 574);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnBarras);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.lblMensag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExclud);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValUni);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtPesq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstoque";
            this.Text = "0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEstoque_FormClosed);
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmEstoque_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtValUni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExclud;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMensag;
        private System.Windows.Forms.BindingSource tbprodBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn @CodBarra;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Panel pnBarras;
        private System.Windows.Forms.Button btnClose;
    }
}