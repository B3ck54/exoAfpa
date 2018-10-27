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
	
	public partial class FrmExo5 : Form
	{
		/// <summary>
		/// Générateur de nombre aléatoire
		/// </summary>
		private System.Random aleat; // variable de niveau classe
									
		/// <summary>							
		/// Constructeur par défaut : Génère un nombre aléatoire
		/// et Affiche les valeurs courantes (stockées dans les données)
		/// </summary>
		

		public Int32 chrono;
		public Double nombre;

		public FrmExo5()
		{
			InitializeComponent();
			this.aleat = new System.Random(); // instancie un objet générateur aléatoire
			this.Affiche(); //calcul de nouvelles valeurs et affichages
							/// Appel la procédure quand l'application commence
			timer1.Interval = 1000;
			timer1.Tick += new EventHandler(Timer_Tick);
			timer1.Enabled = true;
		}

		/// <summary>
		/// Déclenchement timer : Affiche les valeurs courantes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void Timer_Tick(object sender, EventArgs e)

		{


			this.Affiche(); //calcul de nouvelles valeurs et affichages

		}





		/// <summary>
		/// Calcul nouvelles valeurs
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// 
		
		private void Affiche()
		{
			// génére un nombre entre 0 et 1 et l'Affiche en textbox
			this.nombre = this.aleat.NextDouble();
			this.TxtbxNombre.Text = this.nombre.ToString();
			// incrémente chrone à l'affichage en textebox
			this.chrono++;
			this.TxtbxChrono.Text = this.chrono.ToString();


		}

	
		private void FrmExo5_Load(object sender, EventArgs e)
		{

		}
	}
}
