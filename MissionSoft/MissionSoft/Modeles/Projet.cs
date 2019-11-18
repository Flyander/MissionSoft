using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MissionSoft.Modeles
{
    class Projet
    {
        #region Attributs

        public static ArrayList CollClassProjet = new ArrayList();

        private string _nom;
        private DateTime _debut;
        private DateTime _fin;
        private float _prixFactureMO;

        #endregion

        #region Constructeurs

        public Projet(string nom, DateTime debut, DateTime fin, float prixFactureMO)
        {
            Nom = nom;
            Debut = debut;
            Fin = fin;
            PrixFactureMO = prixFactureMO;
            CollClassProjet.Add(this);
        }

        #endregion

        #region Getters/Setters

        public string Nom { get => _nom; set => _nom = value; }
        public DateTime Debut { get => _debut; set => _debut = value; }
        public DateTime Fin { get => _fin; set => _fin = value; }
        public float PrixFactureMO { get => _prixFactureMO; set => _prixFactureMO = value; }

        #endregion

        #region Méthodes

        #endregion

    }
}
