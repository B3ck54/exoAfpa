namespace Exercice_5_MDI
{
	partial class FrmChrono
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
			this.LblChrono = new System.Windows.Forms.Label();
			this.TxtbxChrono2 = new System.Windows.Forms.TextBox();
			this.BtnActualiser = new System.Windows.Forms.Button();
			this.BtnFermer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblChrono
			// 
			this.LblChrono.AutoSize = true;
			this.LblChrono.Location = new System.Drawing.Point(13, 23);
			this.LblChrono.Name = "LblChrono";
			this.LblChrono.Size = new System.Drawing.Size(41, 13);
			this.LblChrono.TabIndex = 0;
			this.LblChrono.Text = "Chrono";
			// 
			// TxtbxChrono2
			// 
			this.TxtbxChrono2.Location = new System.Drawing.Point(66, 20);
			this.TxtbxChrono2.Name = "TxtbxChrono2";
			this.TxtbxChrono2.Size = new System.Drawing.Size(160, 20);
			this.TxtbxChrono2.TabIndex = 1;
			this.TxtbxChrono2.TextChanged += new System.EventHandler(this.TxtbxChrono_TextChanged);
			// 
			// BtnActualiser
			// 
			this.BtnActualiser.Location = new System.Drawing.Point(16, 57);
			this.BtnActualiser.Name = "BtnActualiser";
			this.BtnActualiser.Size = new System.Drawing.Size(102, 25);
			this.BtnActualiser.TabIndex = 2;
			this.BtnActualiser.Text = "Actualiser";
			this.BtnActualiser.UseVisualStyleBackColor = true;
			this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
			// 
			// BtnFermer
			// 
			this.BtnFermer.Location = new System.Drawing.Point(124, 57);
			this.BtnFermer.Name = "BtnFermer";
			this.BtnFermer.Size = new System.Drawing.Size(102, 25);
			this.BtnFermer.TabIndex = 3;
			this.BtnFermer.Text = "Fermer";
			this.BtnFermer.UseVisualStyleBackColor = true;
			this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
			// 
			// FrmChrono
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 98);
			this.Controls.Add(this.BtnFermer);
			this.Controls.Add(this.BtnActualiser);
			this.Controls.Add(this.TxtbxChrono2);
			this.Controls.Add(this.LblChrono);
			this.Name = "FrmChrono";
			this.Text = "FrmChrono";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChrono_FormClosing);
			this.Load += new System.EventHandler(this.FrmChrono_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblChrono;
		private System.Windows.Forms.Button BtnActualiser;
		private System.Windows.Forms.Button BtnFermer;
		internal System.Windows.Forms.TextBox TxtbxChrono2;
	}
}