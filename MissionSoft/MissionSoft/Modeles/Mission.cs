using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MissionSoft.Modeles
{
    class Mission
    {
        #region Attributs
        public static ArrayList CollClassMission = new ArrayList();

        private string _nom;
        private string _description;
        private int _nbHeuresPrevues;
        private Dictionary<DateTime, int> _releveHoraire = new Dictionary<DateTime, int>();
        private Intervenant _executant;
        #endregion

        #region Constructeurs
        public Mission(string nom, string description, int nbHeuresPrevues, Dictionary<DateTime, int> releveHoraire, Intervenant executant)
        {
            _nom = nom;
            _description = description;
            _nbHeuresPrevues = nbHeuresPrevues;
            _releveHoraire = releveHoraire;
            _executant = executant;
            CollClassMission.Add(this);
        }
        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public int NbHeuresPrevues { get => _nbHeuresPrevues; set => _nbHeuresPrevues = value; }
        public Dictionary<DateTime, int> ReleveHoraire { get => _releveHoraire; set => _releveHoraire = value; }
        internal Intervenant Executant { get => _executant; set => _executant = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
