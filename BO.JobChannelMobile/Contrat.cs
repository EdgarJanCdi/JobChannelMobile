using System;
using System.Runtime.Serialization;

namespace BO.JobChannelMobile
{
    /// <summary>
    /// Classe qui représente les différents contrats
    /// </summary>
    [DataContract]
    public class Contrat
    {

        #region "Propriétés et accesseurs"
        // Déclaration des propriétés

        private int _IdContrat; // L'identifiant du contrat
        /// <summary>
        /// L'identifiant du contrat
        /// </summary>
        [DataMember]
        public int IdContrat
        {
            get { return _IdContrat; }
            set { _IdContrat = value; }
        }

        private string _TypeContrat; // L'intitulé du contrat
        /// <summary>
        /// L'intitulé du contrat
        /// </summary>
        [DataMember]
        public string TypeContrat
        {
            get { return _TypeContrat; }
            set { _TypeContrat = value; }
        }

        #endregion

        #region "Constructeurs"
        // Déclaration des constructeurs

        /// <summary>
        /// Construit un poste
        /// </summary>
        /// <param name="idContrat">L'identifiant du contrat</param>
        /// <param name="typeContrat">L'intitulé du contrat</param>
        public Contrat(int idContrat, string typeContrat)
        {
            this.IdContrat = idContrat;
            this.TypeContrat = typeContrat;
        }

        /// <summary>
        /// Construit un poste
        /// </summary>
        public Contrat()
        {

        }

        #endregion

        #region "Methodes"
        #endregion

        #region "Methodes héritées et substituées"

        /// <summary>
        /// Représente le type du contrat sous forme d'une chaine de caractère
        /// </summary>
        /// <returns>Chaîne de caractères "TypeContrat"</returns>
        public override string ToString()
        {
            return TypeContrat;
        }

        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
