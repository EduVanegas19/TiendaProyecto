using System;
using System.Windows.Forms;

namespace TIENDA.GUI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            Cronometro.Stop();
            Close();
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            Cronometro.Start();
        }

        
    }
}
