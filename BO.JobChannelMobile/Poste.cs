using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BO.JobChannelMobile
{
    /// <summary>
    /// Classe qui représente les différents postes
    /// </summary>
    [DataContract]
    public class Poste
    {
        #region "Propriétés et accesseurs"
        // Déclaration des propriétés

        private int _IdPost; // L'identifiant du poste
        /// <summary>
        /// L'identifiant du poste
        /// </summary>
        [DataMember]
        public int IdPost
        {
            get { return _IdPost; }
            set { _IdPost = value; }
        }

        private string _TypePoste; // L'intitulé du poste
        /// <summary>
        /// L'intitulé du poste
        /// </summary>
        [DataMember]
        public string TypePoste
        {
            get { return _TypePoste; }
            set { _TypePoste = value; }
        }

        #endregion

        #region "Constructeurs"
        // Déclaration des constructeurs

        /// <summary>
        /// Construit un poste
        /// </summary>
        /// <param name="idPost">L'identifiant du poste</param>
        /// <param name="typePoste">Le type du poste</param>
        public Poste(int idPost, string typePoste)
        {
            this.IdPost = idPost;
            this.TypePoste = typePoste;
        }

        /// <summary>
        /// Construit un poste
        /// </summary>
        public Poste()
        {

        }

        #endregion

        #region "Methodes"
        #endregion

        #region "Methodes héritées et substituées"

        /// <summary>
        /// Représente le type du poste sous forme d'une chaine de caractère
        /// </summary>
        /// <returns>Chaîne de caractères "TypePoste"</returns>
        public override string ToString()
        {
            return TypePoste;
        }

        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
