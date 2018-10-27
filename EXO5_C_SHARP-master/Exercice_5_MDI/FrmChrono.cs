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
	public partial class FrmChrono : Form
	{
		private FrmExo5 frmPrinc; // amélioration 2 - référence au form appelant 



		public FrmChrono (FrmExo5 f)
		{
			InitializeComponent();
			this.frmPrinc = f; // amélioration 2 - mémorise la ref au form appelant

		}



		private void BtnFermer_Click(object sender, EventArgs e)
		{
			((FrmMDI)(this.frmPrinc.MdiParent)).FermeChrono(); // libère la référence à ce form - nécessite de caster MdiParent

			this.Close();
		}

		private void FrmChrono_Load(object sender, EventArgs e)
		{

		}
		/// <summary>  
		/// bouton Actualiser : recopier chrono depuis form appelant
		/// </summary>
		private void BtnActualiser_Click(object sender, EventArgs e)
		{
			// recopie depuis le form appelant (le chemin est long...) 
			this.TxtbxChrono2.Text = this.frmPrinc.chrono.ToString();

		}


			private void TxtbxChrono_TextChanged(object sender, EventArgs e)
		{

		}



		private void FormChrono_FormClosing(object sender, FormClosingEventArgs e)
		{
			((FrmMDI)(this.frmPrinc.MdiParent)).FermeChrono();
			
			// libère la référence à ce form - nécessite de caster MdiParent
		}

		

	}
}

