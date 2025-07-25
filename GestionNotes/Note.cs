using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    public class Note
    {
        public int Id { get; set; }
        public int EtudiantId { get; set; }
        public int MatiereId { get; set; }
        public double Valeur { get; set; }

        public string NomMatiere { get; set; } // Pour affichage
    }
}
