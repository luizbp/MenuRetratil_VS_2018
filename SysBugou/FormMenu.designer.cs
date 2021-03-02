namespace SysBugou
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.btSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btCadCliente
            // 
            this.btCadCliente.BackColor = System.Drawing.Color.Transparent;
            this.btCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadCliente.Enabled = false;
            this.btCadCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btCadCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btCadCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btCadCliente.Margin = new System.Windows.Forms.Padding(1, 25, 0, 15);
            this.btCadCliente.Name = "btCadCliente";
            this.btCadCliente.Size = new System.Drawing.Size(236, 4);
            this.btCadCliente.Click += new System.EventHandler(this.btCadCliente_Click_1);
            // 
            // btCadProdutos
            // 
            this.btCadProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btCadProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadProdutos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btCadProdutos.ForeColor = System.Drawing.Color.Black;
            this.btCadProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btCadProdutos.Name = "btCadProdutos";
            this.btCadProdutos.Size = new System.Drawing.Size(237, 41);
            this.btCadProdutos.Text = "Agenda";
            this.btCadProdutos.Click += new System.EventHandler(this.btCadProdutos_Click_1);
            // 
            // btServicos
            // 
            this.btServicos.BackColor = System.Drawing.Color.White;
            this.btServicos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btServicos.ForeColor = System.Drawing.Color.Black;
            this.btServicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btServicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btServicos.Name = "btServicos";
            this.btServicos.Size = new System.Drawing.Size(237, 41);
            this.btServicos.Text = "Caixa";
            this.btServicos.Click += new System.EventHandler(this.btServicos_Click);
            // 
            // btSair
            // 
            this.btSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btSair.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.Black;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSair.Margin = new System.Windows.Forms.Padding(0, 0, 0, 150);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(237, 41);
            this.btSair.Text = "Sair";
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCadCliente,
            this.btCadProdutos,
            this.btServicos,
            this.btSair,
            this.btSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 502);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // btSobre
            // 
            this.btSobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btSobre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btSobre.ForeColor = System.Drawing.Color.Black;
            this.btSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSobre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(237, 41);
            this.btSobre.Text = "Sobre";
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(247, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.MouseLeave += new System.EventHandler(this.FormMenu_MouseLeave);
            this.MouseHover += new System.EventHandler(this.FormMenu_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btCadCliente;
        private System.Windows.Forms.ToolStripMenuItem btCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem btServicos;
        private System.Windows.Forms.ToolStripMenuItem btSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btSobre;
    }
}