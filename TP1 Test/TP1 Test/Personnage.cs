using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Test
{
    public class Personnage:ElementDeJeu
    {
        //Attributs
        int charisma, constitution, dexterity, intelligence, strenght, wisdom;
        Random rand;

        //Propriété
        int Experience { get; set; }
        string Nom { get; set; }
        int Poid { get; set; }
        string Sexe { get; set; }
        int Taille { get; set; }

        //Méthodes
        public override void AfficherCoucou()
        {

        }
        public virtual void AfficherStat()
        {

        }
        public override void AfficherToto()
        {

        }
    }
}
