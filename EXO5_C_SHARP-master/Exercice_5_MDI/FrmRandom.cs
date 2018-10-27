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

/// <summary>
/// Génère un nombre aléatoire
/// </summary>

{
	public partial class FrmRandom : Form
	{
		private FrmExo5 frmPrinc; // amélioration 2 - référence au form appelant

		public FrmRandom(FrmExo5 f2)
		{
			InitializeComponent();
			this.frmPrinc = f2; // amélioration 2 - mémorise la ref au form appelant
		}
		
		private void BtnFermer_Click(object sender, EventArgs e)
		{
			((FrmMDI)(this.frmPrinc.MdiParent)).FermeChrono(); // libère la référence à ce form - nécessite de caster MdiParent
			Close();
		}

		private void FormRandom_FormClosing(object sender, FormClosingEventArgs e)
		{
			((FrmMDI)(this.frmPrinc.MdiParent)).FermeChrono();

			// libère la référence à ce form - nécessite de caster MdiParent
		}


		private void FrmRandom_Load(object sender, EventArgs e)
		{

		}

		private void BtnActualiser_Click(object sender, EventArgs e)
		{
			// recopie depuis le form appelant (le chemin est long...) 
			this.TxtbxNombre2.Text = this.frmPrinc.nombre.ToString();
		}
	}
	
}
