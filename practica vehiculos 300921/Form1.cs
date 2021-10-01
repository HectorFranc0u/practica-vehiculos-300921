using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//HECTOR ALEJANDRO FRANCO BERRIOS
//GEOVANY MAURICIO ALVAREZ VELASQUEZ
namespace practica_vehiculos_300921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                comprobartaxi();
            }
            else
            {
                comprobarautobus();
            }
        }

        private void comprobartaxi()
        {
            Taxi taxi = new Taxi();
            taxi.VehMatr = txbmatricula.Text;
            taxi.VehModelo = txbmodelo.Text;
            taxi.VehPotCV = txbpotencia.Text;
            taxi.numLicencia = txblicencia.Text;

            listbox.Items.Add(taxi.VehMatr + ", " + taxi.VehModelo + ", " + taxi.VehPotCV + ", " + taxi.numLicencia);
        }

        private void comprobarautobus()
        {
            Autobus autobus = new Autobus();
            autobus.VehMatr = txbmatricula.Text;
            autobus.VehModelo = txbmodelo.Text;
            autobus.VehPotCV = txbpotencia.Text;
            autobus.AutNumPlazas = txbplazas.Text;

            listbox.Items.Add(autobus.VehMatr + ", " + autobus.VehModelo + ", " + autobus.VehPotCV + ", " + autobus.AutNumPlazas);
        }
    }
}
