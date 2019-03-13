using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BO.JobChannelMobile
{
    /// <summary>
    /// Classe qui représente les différents régions
    /// </summary>
    [DataContract]
    public class Region
    {
        #region "Propriétés et accesseurs"
        // Déclaration des propriétés

        private int _IdRegion; // L'identifiant de la région
        /// <summary>
        /// L'identifiant de la région
        /// </summary>
        [DataMember]
        public int IdRegion
        {
            get { return _IdRegion; }
            set { _IdRegion = value; }
        }

        private string _NomRegion; // Le nom de la région
        /// <summary>
        /// Le nom de la région
        /// </summary>
        [DataMember]
        public string NomRegion
        {
            get { return _NomRegion; }
            set { _NomRegion = value; }
        }

        private int _CodeINSEE; //Le code INSEE de la région
        /// <summary>
        /// Le code INSEE de la région
        /// </summary>
        [DataMember]
        public int CodeINSEE
        {
            get { return _CodeINSEE; }
            set { _CodeINSEE = value; }
        }

        #endregion

        #region "Constructeurs"
        // Déclaration des constructeurs

        /// <summary>
        /// Construit une région
        /// </summary>
        /// <param name="idRegion">L'identifiant de la région</param>
        /// <param name="nomRegion">Le nom de la région</param>
        /// <param name="codeINSEE">Le code INSEE de la région</param>
        public Region(int idRegion, string nomRegion, int codeINSEE)
        {
            this.IdRegion = idRegion;
            this.NomRegion = nomRegion;
            this.CodeINSEE = codeINSEE;
        }

        /// <summary>
        /// Construit une région
        /// </summary>
        public Region()
        {

        }

        #endregion

        #region "Methodes"
        #endregion

        #region "Methodes héritées et substituées"

        /// <summary>
        /// Représente le type du poste sous forme d'une chaine de caractère
        /// </summary>
        /// <returns>Chaîne de caractères "NomRegion"</returns>
        public override string ToString()
        {
            return NomRegion;
        }

        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
