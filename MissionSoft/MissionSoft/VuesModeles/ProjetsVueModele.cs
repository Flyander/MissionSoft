using MissionSoft.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MissionSoft.VuesModeles
{
    class ProjetsVueModele : INotifyPropertyChanged
    {
        #region Attributs

        private string _nomProjet;
        private ObservableCollection<Projet> _maListeProjets;

        #endregion

        #region Constructeur

        public ProjetsVueModele()
        {
            _maListeProjets = new ObservableCollection<Projet>();

            DateTime dateDebut = new DateTime(01 / 02 / 2000);
            DateTime dateFin = new DateTime(01 / 02 / 2019);

            Projet Argo = new Projet("Argo", dateDebut, dateFin, 1000);

            _maListeProjets.Add(Argo);

            _nomProjet = "test";
        }
        #endregion

        #region Getters/Setters

        public ObservableCollection<Projet> MaListeProjets
        {
            get
            {
                return _maListeProjets;
            }

            set
            {
                _maListeProjets = value;
                OnPropertyChanged(nameof(MaListeProjets));
            }
        }

        public string NomProjet
        {
            get
            {
                return _nomProjet;
            }

            set
            {
                _nomProjet = value;
                OnPropertyChanged(nameof(NomProjet));
            }
        }

        #endregion

        #region INotify

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Méthodes



        #endregion
    }
}
