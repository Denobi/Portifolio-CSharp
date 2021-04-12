namespace WindowsFormsApplication1
{
    partial class frm_Report
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
            this.rpv_relatorios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.btn_gerador = new System.Windows.Forms.Button();
            this.txb_Dataname = new System.Windows.Forms.TextBox();
            this.txb_te = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_relatorios
            // 
            this.rpv_relatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.rpv_relatorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rpv_relatorios.Location = new System.Drawing.Point(6, 2);
            this.rpv_relatorios.Name = "rpv_relatorios";
            this.rpv_relatorios.Size = new System.Drawing.Size(509, 266);
            this.rpv_relatorios.TabIndex = 0;
            this.rpv_relatorios.Load += new System.EventHandler(this.rpv_relatorios_Load);
            // 
            // dtgDados
            // 
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(6, 268);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.Size = new System.Drawing.Size(509, 172);
            this.dtgDados.TabIndex = 1;
            this.dtgDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellClick);
            // 
            // btn_gerador
            // 
            this.btn_gerador.FlatAppearance.BorderSize = 0;
            this.btn_gerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerador.Font = new System.Drawing.Font("LEMON MILK Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerador.Location = new System.Drawing.Point(521, 12);
            this.btn_gerador.Name = "btn_gerador";
            this.btn_gerador.Size = new System.Drawing.Size(132, 179);
            this.btn_gerador.TabIndex = 0;
            this.btn_gerador.Text = "GERADOR";
            this.btn_gerador.UseVisualStyleBackColor = true;
            this.btn_gerador.Click += new System.EventHandler(this.btn_gerador_Click);
            // 
            // txb_Dataname
            // 
            this.txb_Dataname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Dataname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Dataname.Location = new System.Drawing.Point(544, 249);
            this.txb_Dataname.Name = "txb_Dataname";
            this.txb_Dataname.ReadOnly = true;
            this.txb_Dataname.Size = new System.Drawing.Size(100, 19);
            this.txb_Dataname.TabIndex = 2;
            // 
            // txb_te
            // 
            this.txb_te.Location = new System.Drawing.Point(522, 296);
            this.txb_te.Name = "txb_te";
            this.txb_te.Size = new System.Drawing.Size(100, 20);
            this.txb_te.TabIndex = 4;
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(656, 445);
            this.Controls.Add(this.txb_te);
            this.Controls.Add(this.txb_Dataname);
            this.Controls.Add(this.btn_gerador);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.rpv_relatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Report";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_relatorios;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button btn_gerador;
        private System.Windows.Forms.TextBox txb_Dataname;
        private System.Windows.Forms.TextBox txb_te;

    }
}