namespace WfaDS
{
    partial class Menu_Geren
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAeronaves = new System.Windows.Forms.Button();
            this.btnPilotos = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Vôos";
            // 
            // btnAeronaves
            // 
            this.btnAeronaves.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAeronaves.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeronaves.Location = new System.Drawing.Point(297, 205);
            this.btnAeronaves.Name = "btnAeronaves";
            this.btnAeronaves.Size = new System.Drawing.Size(280, 61);
            this.btnAeronaves.TabIndex = 5;
            this.btnAeronaves.Text = "Gerenciar Aeronaves";
            this.btnAeronaves.UseVisualStyleBackColor = false;
            this.btnAeronaves.Click += new System.EventHandler(this.btnAeronaves_Click);
            // 
            // btnPilotos
            // 
            this.btnPilotos.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPilotos.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPilotos.Location = new System.Drawing.Point(297, 288);
            this.btnPilotos.Name = "btnPilotos";
            this.btnPilotos.Size = new System.Drawing.Size(280, 61);
            this.btnPilotos.TabIndex = 6;
            this.btnPilotos.Text = "Gerenciar Pilotos";
            this.btnPilotos.UseVisualStyleBackColor = false;
            this.btnPilotos.Click += new System.EventHandler(this.btnPilotos_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // Menu_Geren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(864, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPilotos);
            this.Controls.Add(this.btnAeronaves);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Geren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Vôos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Geren_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Geren_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Geren_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAeronaves;
        private System.Windows.Forms.Button btnPilotos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timerHora;
    }
}

