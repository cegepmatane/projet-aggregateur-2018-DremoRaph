using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VueProjetAggregation.Controleurs;
using VueProjetAggregation.Elements;

namespace VueProjetAggregation
{
    /// <summary>
    /// Logique d'interaction pour FenêtreNouvelle.xaml
    /// </summary>
    public partial class FenêtreNouvelle : Window
    {
        public ControleurNouvelles controleur;
        public NouvelleDAO daoNouvelle;
        public FenêtreNouvelle()
        {
            daoNouvelle = new NouvelleDAO();
            InitializeComponent();
            controleur = new ControleurNouvelles(this);
        }

        private void actionProchaineNouvelle_Click(object sender, RoutedEventArgs e)
        {
            controleur.notifierActionProchaineNouvelle(daoNouvelle);
        }
    }
}
