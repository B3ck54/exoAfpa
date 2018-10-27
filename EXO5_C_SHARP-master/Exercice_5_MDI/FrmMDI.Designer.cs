namespace Exercice_5_MDI
{
	partial class FrmMDI
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.Tsm_fichier = new System.Windows.Forms.ToolStripMenuItem();
			this.QuitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Fsm_Fenetre = new System.Windows.Forms.ToolStripMenuItem();
			this.ChronoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAide = new System.Windows.Forms.ToolStripMenuItem();
			this.AproposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_fichier,
            this.Fsm_Fenetre,
            this.tsmAide});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.Fsm_Fenetre;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Tsm_fichier
			// 
			this.Tsm_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitterToolStripMenuItem});
			this.Tsm_fichier.Name = "Tsm_fichier";
			this.Tsm_fichier.Size = new System.Drawing.Size(54, 20);
			this.Tsm_fichier.Text = "Fichier";
			// 
			// QuitterToolStripMenuItem
			// 
			this.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem";
			this.QuitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.QuitterToolStripMenuItem.Text = "Quitter";
			this.QuitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
			// 
			// Fsm_Fenetre
			// 
			this.Fsm_Fenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChronoToolStripMenuItem,
            this.NombreToolStripMenuItem});
			this.Fsm_Fenetre.Name = "Fsm_Fenetre";
			this.Fsm_Fenetre.Size = new System.Drawing.Size(58, 20);
			this.Fsm_Fenetre.Text = "Fenêtre";
			// 
			// ChronoToolStripMenuItem
			// 
			this.ChronoToolStripMenuItem.Name = "ChronoToolStripMenuItem";
			this.ChronoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.ChronoToolStripMenuItem.Text = "Chrono";
			this.ChronoToolStripMenuItem.Click += new System.EventHandler(this.ChronoToolStripMenuItem_Click);
			// 
			// NombreToolStripMenuItem
			// 
			this.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem";
			this.NombreToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.NombreToolStripMenuItem.Text = "Nombre";
			this.NombreToolStripMenuItem.Click += new System.EventHandler(this.NombreToolStripMenuItem_Click);
			// 
			// tsmAide
			// 
			this.tsmAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AproposDeToolStripMenuItem});
			this.tsmAide.Name = "tsmAide";
			this.tsmAide.Size = new System.Drawing.Size(24, 20);
			this.tsmAide.Text = "?";
			// 
			// AproposDeToolStripMenuItem
			// 
			this.AproposDeToolStripMenuItem.Name = "AproposDeToolStripMenuItem";
			this.AproposDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.AproposDeToolStripMenuItem.Text = "A propos de";
			// 
			// FrmMDI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "FrmMDI";
			this.Text = "FrmMDI";
			this.Load += new System.EventHandler(this.FrmMDI_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem Tsm_fichier;
		private System.Windows.Forms.ToolStripMenuItem Fsm_Fenetre;
		private System.Windows.Forms.ToolStripMenuItem ChronoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NombreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmAide;
		private System.Windows.Forms.ToolStripMenuItem QuitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AproposDeToolStripMenuItem;
	}
}

