namespace Exercice_5_MDI
{
	partial class FrmRandom
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
			this.btnFermer2 = new System.Windows.Forms.Button();
			this.btnActualiser2 = new System.Windows.Forms.Button();
			this.TxtbxNombre2 = new System.Windows.Forms.TextBox();
			this.LblRandom = new System.Windows.Forms.Label();
			this.BtnFermer = new System.Windows.Forms.Button();
			this.BtnActualiser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFermer2
			// 
			this.btnFermer2.Location = new System.Drawing.Point(178, 61);
			this.btnFermer2.Name = "btnFermer2";
			this.btnFermer2.Size = new System.Drawing.Size(0, 0);
			this.btnFermer2.TabIndex = 7;
			this.btnFermer2.Text = "Fermer";
			this.btnFermer2.UseVisualStyleBackColor = true;
			// 
			// btnActualiser2
			// 
			this.btnActualiser2.Location = new System.Drawing.Point(70, 61);
			this.btnActualiser2.Name = "btnActualiser2";
			this.btnActualiser2.Size = new System.Drawing.Size(0, 0);
			this.btnActualiser2.TabIndex = 6;
			this.btnActualiser2.Text = "Actualiser";
			this.btnActualiser2.UseVisualStyleBackColor = true;
			// 
			// TxtbxNombre2
			// 
			this.TxtbxNombre2.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.TxtbxNombre2.Location = new System.Drawing.Point(106, 19);
			this.TxtbxNombre2.Name = "TxtbxNombre2";
			this.TxtbxNombre2.Size = new System.Drawing.Size(236, 20);
			this.TxtbxNombre2.TabIndex = 5;
			// 
			// LblRandom
			// 
			this.LblRandom.AutoSize = true;
			this.LblRandom.Location = new System.Drawing.Point(12, 22);
			this.LblRandom.Name = "LblRandom";
			this.LblRandom.Size = new System.Drawing.Size(88, 13);
			this.LblRandom.TabIndex = 4;
			this.LblRandom.Text = "Nombre Aléatoire";
			// 
			// BtnFermer
			// 
			this.BtnFermer.Location = new System.Drawing.Point(183, 61);
			this.BtnFermer.Name = "BtnFermer";
			this.BtnFermer.Size = new System.Drawing.Size(102, 25);
			this.BtnFermer.TabIndex = 9;
			this.BtnFermer.Text = "Fermer";
			this.BtnFermer.UseVisualStyleBackColor = true;
			this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
			// 
			// BtnActualiser
			// 
			this.BtnActualiser.Location = new System.Drawing.Point(75, 61);
			this.BtnActualiser.Name = "BtnActualiser";
			this.BtnActualiser.Size = new System.Drawing.Size(102, 25);
			this.BtnActualiser.TabIndex = 8;
			this.BtnActualiser.Text = "Actualiser";
			this.BtnActualiser.UseVisualStyleBackColor = true;
			this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
			// 
			// FrmRandom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 98);
			this.Controls.Add(this.BtnFermer);
			this.Controls.Add(this.BtnActualiser);
			this.Controls.Add(this.btnFermer2);
			this.Controls.Add(this.btnActualiser2);
			this.Controls.Add(this.TxtbxNombre2);
			this.Controls.Add(this.LblRandom);
			this.Name = "FrmRandom";
			this.Text = "FrmRandom";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRandom_FormClosing);
			this.Load += new System.EventHandler(this.FrmRandom_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFermer2;
		private System.Windows.Forms.Button btnActualiser2;
		internal System.Windows.Forms.TextBox TxtbxNombre2;
		private System.Windows.Forms.Label LblRandom;
		private System.Windows.Forms.Button BtnFermer;
		private System.Windows.Forms.Button BtnActualiser;
	}
}