using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MissionSoft.Modeles
{
    class Intervenant
    {
        #region Attributs

        public static ArrayList CollClasseIntervenant = new ArrayList();

        private string _nom;
        private float _tauxHoraire;

        #endregion

        #region Constructeur

        public Intervenant(string nom, float tauxHoraire)
        {
            this.Nom = nom;
            this.TauxHoraire = tauxHoraire;

            Intervenant.CollClasseIntervenant.Add(this);
        }

        #endregion

        #region Getters/Setters

        public string Nom { get => _nom; set => _nom = value; }
        public float TauxHoraire { get => _tauxHoraire; set => _tauxHoraire = value; }

        #endregion


        #region Méthodes

        public float getTauxHoraire()
        {
            return TauxHoraire;
        }

        #endregion
    }
}
