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

        private ObservableCollection<Projet> _maListeProjets;

        #endregion

        #region Constructeur

        public ProjetsVueModele()
        {
            _maListeProjets = new ObservableCollection<Projet>();

            DateTime dateDebut = new DateTime(01 / 02 / 2000);
            DateTime dateFin = new DateTime(01 / 02 / 2019);

            Projet Argo = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo1 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo2 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo3 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo4 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo5 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo6 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo7 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo8 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo9 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo10 = new Projet("Argo", dateDebut, dateFin, 1000);
            Projet Argo11 = new Projet("Argo", dateDebut, dateFin, 1000);

            MaListeProjets.Add(Argo);
            MaListeProjets.Add(Argo1);
            MaListeProjets.Add(Argo2);
            MaListeProjets.Add(Argo3);
            MaListeProjets.Add(Argo4);
            MaListeProjets.Add(Argo5);
            MaListeProjets.Add(Argo6);
            MaListeProjets.Add(Argo7);
            MaListeProjets.Add(Argo8);
            MaListeProjets.Add(Argo9);
            MaListeProjets.Add(Argo10);
            MaListeProjets.Add(Argo11);

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
