namespace game
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.crono = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempo = new System.Windows.Forms.ToolStripMenuItem();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.adversario = new System.Windows.Forms.PictureBox();
            this.raquete = new System.Windows.Forms.PictureBox();
            this.bola = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adversario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).BeginInit();
            this.SuspendLayout();
            // 
            // crono
            // 
            this.crono.Enabled = true;
            this.crono.Interval = 10;
            this.crono.Tick += new System.EventHandler(this.Crono_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarJogoToolStripMenuItem,
            this.pausarJogoToolStripMenuItem,
            this.reiniciarJogoToolStripMenuItem,
            this.encerrarToolStripMenuItem,
            this.tempo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarJogoToolStripMenuItem
            // 
            this.iniciarJogoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.iniciarJogoToolStripMenuItem.Name = "iniciarJogoToolStripMenuItem";
            this.iniciarJogoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.iniciarJogoToolStripMenuItem.Text = "Iniciar Jogo";
            this.iniciarJogoToolStripMenuItem.Click += new System.EventHandler(this.iniciarJogoToolStripMenuItem_Click);
            // 
            // pausarJogoToolStripMenuItem
            // 
            this.pausarJogoToolStripMenuItem.Enabled = false;
            this.pausarJogoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pausarJogoToolStripMenuItem.Name = "pausarJogoToolStripMenuItem";
            this.pausarJogoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.pausarJogoToolStripMenuItem.Text = "Pausar Jogo";
            this.pausarJogoToolStripMenuItem.Click += new System.EventHandler(this.pausarJogoToolStripMenuItem_Click);
            // 
            // reiniciarJogoToolStripMenuItem
            // 
            this.reiniciarJogoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reiniciarJogoToolStripMenuItem.Name = "reiniciarJogoToolStripMenuItem";
            this.reiniciarJogoToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.reiniciarJogoToolStripMenuItem.Text = "Reiniciar Jogo";
            this.reiniciarJogoToolStripMenuItem.Visible = false;
            this.reiniciarJogoToolStripMenuItem.Click += new System.EventHandler(this.reiniciarJogoToolStripMenuItem_Click);
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // tempo
            // 
            this.tempo.Enabled = false;
            this.tempo.ForeColor = System.Drawing.Color.White;
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(46, 20);
            this.tempo.Text = "00:00";
            // 
            // relogio
            // 
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // adversario
            // 
            this.adversario.BackColor = System.Drawing.Color.White;
            this.adversario.Location = new System.Drawing.Point(0, 203);
            this.adversario.Name = "adversario";
            this.adversario.Size = new System.Drawing.Size(10, 200);
            this.adversario.TabIndex = 2;
            this.adversario.TabStop = false;
            // 
            // raquete
            // 
            this.raquete.BackColor = System.Drawing.Color.White;
            this.raquete.Location = new System.Drawing.Point(606, 107);
            this.raquete.Name = "raquete";
            this.raquete.Size = new System.Drawing.Size(10, 200);
            this.raquete.TabIndex = 1;
            this.raquete.TabStop = false;
            // 
            // bola
            // 
            this.bola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bola.BackgroundImage")));
            this.bola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bola.Location = new System.Drawing.Point(96, 137);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(28, 28);
            this.bola.TabIndex = 4;
            this.bola.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PingPongGame";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 405);
            this.Controls.Add(this.bola);
            this.Controls.Add(this.adversario);
            this.Controls.Add(this.raquete);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.Click += new System.EventHandler(this.Jogo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Jogo_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adversario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer crono;
        private System.Windows.Forms.PictureBox raquete;
        private System.Windows.Forms.PictureBox adversario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempo;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.ToolStripMenuItem reiniciarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox bola;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

