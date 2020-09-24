namespace game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoFacilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoDifícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.jogoToolStripMenuItem,
            this.rankingToolStripMenuItem,
            this.referênciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoFacilToolStripMenuItem,
            this.modoNormalToolStripMenuItem,
            this.modoDifícilToolStripMenuItem});
            this.jogoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // modoFacilToolStripMenuItem
            // 
            this.modoFacilToolStripMenuItem.Name = "modoFacilToolStripMenuItem";
            this.modoFacilToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modoFacilToolStripMenuItem.Text = "Modo Facil";
            this.modoFacilToolStripMenuItem.Click += new System.EventHandler(this.modoFacilToolStripMenuItem_Click);
            // 
            // modoNormalToolStripMenuItem
            // 
            this.modoNormalToolStripMenuItem.Name = "modoNormalToolStripMenuItem";
            this.modoNormalToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modoNormalToolStripMenuItem.Text = "Modo Normal";
            this.modoNormalToolStripMenuItem.Click += new System.EventHandler(this.modoNormalToolStripMenuItem_Click);
            // 
            // modoDifícilToolStripMenuItem
            // 
            this.modoDifícilToolStripMenuItem.Name = "modoDifícilToolStripMenuItem";
            this.modoDifícilToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modoDifícilToolStripMenuItem.Text = "Modo Difícil";
            this.modoDifícilToolStripMenuItem.Click += new System.EventHandler(this.modoDifícilToolStripMenuItem_Click);
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rankingToolStripMenuItem.Text = "Ranking";
            this.rankingToolStripMenuItem.Click += new System.EventHandler(this.rankingToolStripMenuItem_Click);
            // 
            // referênciasToolStripMenuItem
            // 
            this.referênciasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.referênciasToolStripMenuItem.Name = "referênciasToolStripMenuItem";
            this.referênciasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.referênciasToolStripMenuItem.Text = "Referências";
            this.referênciasToolStripMenuItem.Click += new System.EventHandler(this.referênciasToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PingPongGame";
            this.notifyIcon1.Visible = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(573, 425);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoFacilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoDifícilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referênciasToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}