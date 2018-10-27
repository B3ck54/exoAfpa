using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_5_MDI
{
	public partial class FrmMDI : Form
	{
		// Amélioration 1 : 3 variables de niveau classe (accessible dans toute la classe)
		private FrmExo5 frmPrinc ; // déclare une instance du form principal = FrmExo5
		private FrmChrono frmC ; // déclare une instance du form Chrono = FrmChrono
		private FrmRandom frmR ; // déclare une instance du forme Nombre = FrmRandom
		


		/// <summary>
		/// Constructeur du form MDI : ouverture de la fenêtre principale
		/// </summary>
		public FrmMDI()
		{
			InitializeComponent();
			//FrmExo5 frmPrinc;// déclare une instance du form principal
			frmPrinc = new FrmExo5(); // instancie le form principal
			frmPrinc.MdiParent = this; // précise le conteneur MDI du form principal
			frmPrinc.Show(); // Affiche le form (dans le form conteneur)

		
		}


		
		public void FermeChrono()
		{
	
			this.frmC = null; // libère la réf au from chrono
			this.frmR = null; // libère la réf au from Random

		}
		


		/***********************CHRONO TOOLSTRIPMENUITEM******************************/
		/// <summary>
		/// Menu fenêtres / Chrono ==> instancier un form frm Chrono ou le réactiver
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChronoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// instancie le form Chrono - amélioration 1
			if (this.frmC == null) // le form n'est pas/plus affiché
			{
				this.frmC = new FrmChrono(this.frmPrinc); // instancie le form
				this.frmC.MdiParent = this;
				this.frmC.Show(); // Affiche le form
			}
			else // le forme secondaire est affiché
			{
				this.frmC.Activate(); // réactive le form (lui donne le focus)
			}
			// recopie la valeur courante
			this.frmC.TxtbxChrono2.Text = this.frmPrinc.chrono.ToString();
			
		}
	
		/***********************NOMBRE TOOLSTRIPMENUITEM******************************/
		/// <summary>
		/// Menu fenêtres / Nombre ==> instancier un form frmNombre
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NombreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// instancie le form Random - amélioration 1
			if (this.frmR == null) // le form n'est pas/plus affiché
			{
				this.frmR = new FrmRandom(this.frmPrinc); // instancie le form
				this.frmR.MdiParent = this;
				this.frmR.Show(); // Affiche le form
			}
			else // le forme secondaire est affiché
			{
				this.frmR.Activate(); // réactive le form (lui donne le focus)
			}
			// recopie la valeur courante
			this.frmR.TxtbxNombre2.Text = this.frmPrinc.nombre.ToString();
			
		}

		private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Voulez-vous vraiment quitter cette application"
					, "Confirmation suppression"
					, MessageBoxButtons.OKCancel
					, MessageBoxIcon.Warning) == DialogResult.Cancel)
			{
				return;
			}
			else
			{
				Close();
			}

		}

		private void FrmMDI_Load(object sender, EventArgs e)
		{

		}



	}
}
