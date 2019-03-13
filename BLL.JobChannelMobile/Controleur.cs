using BO.JobChannelMobile;
using RestSharp;
using System.Collections.Generic;

namespace BLL.JobChannelMobile
{
    public class Controleur
    {
        //string URL_SERVICE = "http://localhost:5555/ServiceJob.svc";
        private static string URL_SERVICE = "http://user25.2isa.org/ServiceJob.svc";
        ExceptionDAO excep = new ExceptionDAO();
        int compteur = 0;

        // Le controleur utilise la librairy tierce RestSharp (package NuGet)
        RestClient client;
        public Controleur()
        {
            client = new RestClient(URL_SERVICE); // Crée le client
        }

        // Renvoie tous les offres d'emploi
        public List<Offre> FindAllOffreDAOXml()
        {
            List<Offre> listeOfAllOffre = new List<Offre>();

            var request = new RestRequest("Offre", Method.GET);
            var response = client.Execute<List<Offre>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfAllOffre = response.Data;
            }
            else
            {
                if (compteur == 0)
                {
                    //MessageBox.Show(excep.Message);
                    compteur++;
                }
            }

            return listeOfAllOffre;
        }

        // Renvoie tous les postes
        public List<Poste> FindAllPosteDAOXml()
        {
            List<Poste> listeOfAllPoste = new List<Poste>();

            var request = new RestRequest("Poste", Method.GET);
            var response = client.Execute<List<Poste>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfAllPoste = response.Data;
            }

            return listeOfAllPoste;
        }

        // Renvoie tous les contrats
        public List<Contrat> FindAllContratDAOXml()
        {
            List<Contrat> listeOfAllContrat = new List<Contrat>();

            var request = new RestRequest("Contrat", Method.GET);
            var response = client.Execute<List<Contrat>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfAllContrat = response.Data;
            }

            return listeOfAllContrat;
        }

        // Renvoie tous les régions
        public List<Region> FindAllRegionDAOXml()
        {
            List<Region> listeOfAllRegion = new List<Region>();

            var request = new RestRequest("Region", Method.GET);
            var response = client.Execute<List<Region>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfAllRegion = response.Data;
            }

            return listeOfAllRegion;
        }

        // Renvoie tous les offres par poste (IdPoste)
        public List<Offre> FindOffreByIdPosteDAOXml(int idPost)
        {
            List<Offre> listeOfOffre = new List<Offre>();

            var request = new RestRequest("OffreByPoste/{idPost}", Method.GET);
            request.AddParameter("idPost", idPost, ParameterType.UrlSegment);

            var response = client.Execute<List<Offre>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfOffre = response.Data;
            }

            return listeOfOffre;
        }

        // Renvoie tous les offres par contrat (IdContrat)
        public List<Offre> FindOffreByIdContratDAOXml(int IdContrat)
        {
            List<Offre> listeOfOffre = new List<Offre>();

            var request = new RestRequest("OffreByContrat/{idContrat}", Method.GET);
            request.AddParameter("idContrat", IdContrat, ParameterType.UrlSegment);

            var response = client.Execute<List<Offre>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfOffre = response.Data;
            }

            return listeOfOffre;
        }

        // Renvoie tous les offres par région (IdRegion)
        public List<Offre> FindOffreByIdRegionDAOXml(int idRegion)
        {
            List<Offre> listeOfOffre = new List<Offre>();

            var request = new RestRequest("OffreByRegion/{idRegion}", Method.GET);
            request.AddParameter("idRegion", idRegion, ParameterType.UrlSegment);

            var response = client.Execute<List<Offre>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfOffre = response.Data;
            }

            return listeOfOffre;
        }

        // Renvoie les dernières 10 ou 5 offres publiées
        public List<Offre> FindLast10Or5OffreDAOXml(int indexCbxDatePub)
        {
            List<Offre> listeOfLastPublishedOffre = new List<Offre>();

            var request = new RestRequest("Last10or5Offre/{indexOfCboPub}", Method.GET);
            request.AddParameter("indexOfCboPub", indexCbxDatePub, ParameterType.UrlSegment);

            var response = client.Execute<List<Offre>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                listeOfLastPublishedOffre = response.Data;
            }

            return listeOfLastPublishedOffre;
        }

    }
}
