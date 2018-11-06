using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueProjetAggregation.Elements;

namespace VueProjetAggregation.Controleurs
{

    public class ControleurNouvelles
    {
        public FenêtreNouvelle fenetre;
        public int numeroNouvelle = 0;
        public ControleurNouvelles(FenêtreNouvelle fenetre)
        {
            this.fenetre = fenetre;
        }

        public void notifierActionProchaineNouvelle(NouvelleDAO dao)
        {
            List<NouvelleTechnologique> listeNouvelle = dao.listerNouvelles();
            string titre, date, contenu;

            if (listeNouvelle.ElementAt(numeroNouvelle) == null)
            {
                titre = "Aucune nouvelle restante!";
                date = "";
                contenu = "";
            }



                
            else
            {
                titre = listeNouvelle.ElementAt(numeroNouvelle).titre;
                date = listeNouvelle.ElementAt(numeroNouvelle).date;
                contenu = listeNouvelle.ElementAt(numeroNouvelle).contenu;
            }
             
            
            
            fenetre.champTitre.Text = "Titre :" + titre;
            fenetre.champDate.Text = "Date :" + date;
            fenetre.champContenu.Text = "Contenu :" + contenu;



            numeroNouvelle++;

        }
    }
}
