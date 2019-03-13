using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BO.JobChannelMobile
{
    /// <summary>
    /// Classe qui représente les différents offres d'emplois
    /// </summary>
    [DataContract]
    public class Offre
    {
        #region "Propriétés et accesseurs"
        // Déclaration des propriétés

        private string _Titre; // Le titre de l'offre
        /// <summary>
        /// Le titre de l'offre
        /// </summary>
        [DataMember]
        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        /// <summary>
        /// L'ensemble des informations du poste de l’offre
        /// </summary>
        [DataMember]
        public Poste Poste { get; set; } // L'ensemble des informations du poste de l’offre

        /// <summary>
        /// L'ensemble des informations du contrat de l’offre
        /// </summary>
        [DataMember]
        public Contrat Contrat { get; set; } // L'ensemble des informations du contrat de l’offre


        private DateTime _DtPublication; // La date de publication
        /// <summary>
        /// La date de publication de l'offre
        /// </summary>
        [DataMember]
        public DateTime DtPublication
        {
            get { return _DtPublication; }
            set { _DtPublication = value; }
        }

        /// <summary>
        /// L'ensemble des informations de la région de l’offre
        /// </summary>
        [DataMember]
        public Region Region { get; set; } // L'ensemble des informations de la région de l’offre


        private int _IdOffre; // L'identifiant de l'offre
        /// <summary>
        /// L'identifiant de l'offre
        /// </summary>
        [DataMember]
        public int IdOffre
        {
            get { return _IdOffre; }
            set { _IdOffre = value; }
        }

        private string _Desctiption; // La description de l'offre
        /// <summary>
        /// La description de l'offre
        /// </summary>
        [DataMember]
        public string Desctiption
        {
            get { return _Desctiption; }
            set { _Desctiption = value; }
        }

        private string _Lien; // Le lien de l'offre
        /// <summary>
        /// Le lien de l'offre
        /// </summary>
        [DataMember]
        public string Lien
        {
            get { return _Lien; }
            set { _Lien = value; }
        }

        #endregion

        #region "Constructeurs"
        // Déclaration des constructeurs

        /// <summary>
        /// Construit une offre 
        /// </summary>
        /// <param name="idRegion">L'identifiant de la région</param>
        /// <param name="nomRegion">Le nom de la région</param>
        /// <param name="idContrat">L'identifiant du contrat</param>
        /// <param name="typeContrat">L'intitulé du contrat</param>
        /// <param name="idPoste">L'identifiant du poste</param>
        /// <param name="typePoste">L'intitulé du poste</param>
        /// <param name="idOffre">L'identifiant de l'offre</param>
        /// <param name="titre">Le titre de l'offre</param>
        /// <param name="desctiption">La description de l'offre</param>
        /// <param name="dtPublication">La date de publication de l'offre</param>
        /// <param name="lien">Le lien de l'offre</param>
        public Offre(int idRegion, string nomRegion, int idContrat, string typeContrat, int idPoste, string typePoste, int idOffre, string titre, string desctiption, DateTime dtPublication, string lien)
        {
            Region = new Region();
            Contrat = new Contrat();
            Poste = new Poste();
            this.Region.IdRegion = idRegion;
            this.Region.NomRegion = nomRegion;
            this.Contrat.IdContrat = idContrat;
            this.Contrat.TypeContrat = typeContrat;
            this.Poste.IdPost = idPoste;
            this.Poste.TypePoste = typePoste;

            this.IdOffre = idOffre;
            this.Titre = titre;
            this.Desctiption = desctiption;
            this.DtPublication = dtPublication;
            this.Lien = lien;
        }

        /// <summary>
        /// Construit une offre
        /// </summary>
        public Offre()
        {
            Region = new Region();
            Contrat = new Contrat();
            Poste = new Poste();
        }

        #endregion

        #region "Methodes"
        #endregion

        #region "Methodes héritées et substituées"

        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
