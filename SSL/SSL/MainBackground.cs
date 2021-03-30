using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSL
{
    public partial class MainBackground : Form
    {
        public MainBackground()
        {
            InitializeComponent();
            // empêche le background d'être montré sur la barre des tâches
            this.ShowInTaskbar = false;
        }

        private void MainBackground_Load(object sender, EventArgs e)
        {
            //ouvre une nouvelle forme menu au chargement du background
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
