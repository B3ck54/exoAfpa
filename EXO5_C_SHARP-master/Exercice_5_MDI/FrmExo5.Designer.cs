namespace Exercice_5_MDI
{
	partial class FrmExo5
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
			this.TxtbxNombre = new System.Windows.Forms.TextBox();
			this.LblRandom = new System.Windows.Forms.Label();
			this.TxtbxChrono = new System.Windows.Forms.TextBox();
			this.LblChrono = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// TxtbxNombre
			// 
			this.TxtbxNombre.Location = new System.Drawing.Point(106, 54);
			this.TxtbxNombre.Name = "TxtbxNombre";
			this.TxtbxNombre.Size = new System.Drawing.Size(236, 20);
			this.TxtbxNombre.TabIndex = 7;
			// 
			// LblRandom
			// 
			this.LblRandom.AutoSize = true;
			this.LblRandom.Location = new System.Drawing.Point(12, 57);
			this.LblRandom.Name = "LblRandom";
			this.LblRandom.Size = new System.Drawing.Size(88, 13);
			this.LblRandom.TabIndex = 6;
			this.LblRandom.Text = "Nombre Aléatoire";
			// 
			// TxtbxChrono
			// 
			this.TxtbxChrono.Location = new System.Drawing.Point(106, 21);
			this.TxtbxChrono.Name = "TxtbxChrono";
			this.TxtbxChrono.Size = new System.Drawing.Size(236, 20);
			this.TxtbxChrono.TabIndex = 9;
			// 
			// LblChrono
			// 
			this.LblChrono.AutoSize = true;
			this.LblChrono.Location = new System.Drawing.Point(12, 24);
			this.LblChrono.Name = "LblChrono";
			this.LblChrono.Size = new System.Drawing.Size(41, 13);
			this.LblChrono.TabIndex = 8;
			this.LblChrono.Text = "Chrono";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			// 
			// FrmExo5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 98);
			this.Controls.Add(this.TxtbxChrono);
			this.Controls.Add(this.LblChrono);
			this.Controls.Add(this.TxtbxNombre);
			this.Controls.Add(this.LblRandom);
			this.Name = "FrmExo5";
			this.Text = "FrmExo5";
			this.Load += new System.EventHandler(this.FrmExo5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LblRandom;
		internal System.Windows.Forms.TextBox TxtbxChrono;
		private System.Windows.Forms.Label LblChrono;
		private System.Windows.Forms.Timer timer1;
		internal System.Windows.Forms.TextBox TxtbxNombre;
	}
}