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
            this._nom = nom;
            this.TauxHoraire = tauxHoraire;

            Intervenant.CollClasseIntervenant.Add(this);
        }

        #endregion

        #region Getters/Setters

        public float TauxHoraire { get => _tauxHoraire; set => _tauxHoraire = value; }

        #endregion


        #region Méthodes



        #endregion
    }
}
