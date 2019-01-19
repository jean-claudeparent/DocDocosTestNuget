using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocDocos;
using System.IO;

namespace DocDocosTestNuget
{
    [TestClass]
    public class TestNetCore21
    {
        [TestMethod]
        public void GenererOK()
        {
            DocDocosDA Generateur  = 
                new DocDocosDA();
            //Vous n'avez pas besoin d'utiliser
            // ces fonctions si vousconaissez
            // déj;a vos noms de fichiers
            IO monUtilitaireIO = new IO();

            string NomFichierXML =
              "Ressources";
            string SiteWeb =
                monUtilitaireIO.AjouterCheminFichier(  
                  NomFichierXML,
                  "Site web généré");
            

            NomFichierXML =
               monUtilitaireIO.AjouterCheminFichier(
                   NomFichierXML,
                   "DocDocos.xml");
            Generateur.FichierXMLDoc = NomFichierXML;
            
            

            Generateur.RepertoireSortie = SiteWeb;

            // Effacer le résultat précédent
            if (Directory.Exists(Generateur.RepertoireSortie))
                Directory.Delete(
                    Generateur.RepertoireSortie,true );

            //Generer

            Generateur.GenererHTML(); 






        }
    }
}
