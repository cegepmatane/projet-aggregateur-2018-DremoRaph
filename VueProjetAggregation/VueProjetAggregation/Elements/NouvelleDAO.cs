using System.Net;
using System.IO;
using System;
using System.Text;
using System.Xml.XPath;
using System.Collections.Generic;

namespace VueProjetAggregation.Elements
{
    public class NouvelleDAO
    {
        public static string URL_CBC = "https://www.cbc.ca/cmlink/rss-technology";
        public NouvelleDAO()
        {

        }

        public List<NouvelleTechnologique> listerNouvelles()
        {
            List<NouvelleTechnologique> listeNouvelles = new List<NouvelleTechnologique>();
            WebRequest requeteSeismes = WebRequest.Create(URL_CBC);
            WebResponse reponse = requeteSeismes.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            string xml = lecteur.ReadToEnd();
            MemoryStream flux = new MemoryStream(Encoding.ASCII.GetBytes(xml));
            XPathDocument document = new XPathDocument(flux);
            XPathNavigator navigateurXPath = document.CreateNavigator();

            XPathNodeIterator visiteurNouvelles = navigateurXPath.Select("/rss/channel/item");
            while(visiteurNouvelles.MoveNext())
            {
                XPathNavigator navigateurSeisme = visiteurNouvelles.Current;
                string titre = navigateurSeisme.Select("/title").Current.ToString();
                
                string date = navigateurSeisme.Select("/pubDate").Current.ToString();
                
                string contenu = navigateurSeisme.Select("/description").Current.ToString();

                NouvelleTechnologique nouvelle = new NouvelleTechnologique();
                nouvelle.titre = titre;
                nouvelle.date = date;
                nouvelle.contenu = contenu;

                listeNouvelles.Add(nouvelle);

            }

            return listeNouvelles;
        }

    }
}
