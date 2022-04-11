using LIB_BASE;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_GUITARE
{
    /// <summary>
    /// Description résumée de WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        C_BASE La_Base = new C_BASE();


        //================== BOIS =================================
        [WebMethod]
        public List<C_BOIS> Get_All_Bois()
        {
            var Resultat = La_Base.Get_Bois();

            return Resultat;
        }
        //---------------------------------------
        [WebMethod]
        public C_BOIS Get_Bois_By_Id(int P_Id)
        {
            return La_Base.Get_Bois_By_Id(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public List<C_BOIS> Get_Bois_By_Nom(string P_Nom)
        {
            return La_Base.Get_Bois_By_Nom(P_Nom);
        }
        //---------------------------------------
        [WebMethod]
        public void Delete_Bois(int P_Id)
        {
            La_Base.Delete_Bois(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public C_BOIS Add_Bois(string P_Nom, string P_Origine)
        {
            return La_Base.Add_Bois(P_Nom, P_Origine);
        }
        //---------------------------------------
        [WebMethod]
        public C_BOIS Add_Bois_Object(C_BOIS P_Bois)
        {
            return La_Base.Add_Bois(P_Bois);
        }
        //---------------------------------------
        [WebMethod]
        public C_BOIS Update_Bois(C_BOIS P_Bois)
        {
            return La_Base.Update_Bois(P_Bois);
        }
        //===========================================================



        //================== CLIENT =================================


        [WebMethod]
        public List<C_CLIENT> Get_All_Clients()
        {
            var Resultat = La_Base.Get_Clients();
            return Resultat;
        }
        //---------------------------------------
        [WebMethod]
        public C_CLIENT Get_Client_By_Id(int P_Id)
        {
            return La_Base.Get_Client_By_Id(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public List<C_CLIENT> Get_Clients_By_Nom(string P_Nom)
        {
            return La_Base.Get_Client_By_Nom(P_Nom);
        }
        //---------------------------------------
        [WebMethod]
        public void Delete_Client(int P_Id)
        {
            La_Base.Delete_Client(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public C_CLIENT Add_Client(string P_Nom, string P_Email)
        {
            return La_Base.Add_Client(P_Nom, P_Email);
        }
        //---------------------------------------
        [WebMethod]
        public C_CLIENT Add_Client_Object(C_CLIENT P_Client)
        {
            return La_Base.Add_Client(P_Client);
        }
        //---------------------------------------
        [WebMethod]
        public C_CLIENT Update_Client(C_CLIENT P_Client)
        {
            return La_Base.Update_Client(P_Client);
        }
        //===========================================================



        //================== MICRO =================================
        [WebMethod]
        public List<C_MICRO> Get_All_Micros()
        {
            var Resultat = La_Base.Get_Micros();
            return Resultat;
        }
        //---------------------------------------
        [WebMethod]
        public C_MICRO Get_Micro_By_Id(int P_Id)
        {
            return La_Base.Get_Micro_By_Id(P_Id);
        }
        //---------------------------------------

        //---------------------------------------
        [WebMethod]
        public void Delete_Micro(int P_Id)
        {
            La_Base.Delete_Micro(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public C_MICRO Add_Micro(string P_Nom, string P_Reference, string P_Marque)
        {
            return La_Base.Add_Micro(P_Nom, P_Reference, P_Marque);
        }
        //---------------------------------------
        [WebMethod]
        public C_MICRO Add_Micro_Object(C_MICRO P_Micro)
        {
            return La_Base.Add_Micro(P_Micro);
        }
        //---------------------------------------
        [WebMethod]
        public C_MICRO Update_Micro(C_MICRO P_Micro)
        {
            return La_Base.Update_Micro(P_Micro);
        }

        //===========================================================



        //================== VIBRATO =================================

        [WebMethod]
        public List<C_VIBRATO> Get_All_Vibratos()
        {
            var Resultat = La_Base.Get_Vibratos();
            return Resultat;
        }
        //---------------------------------------
        [WebMethod]
        public C_VIBRATO Get_Vibrato_By_Id(int P_Id)
        {
            return La_Base.Get_Vibrato_By_Id(P_Id);
        }
        //---------------------------------------

        //---------------------------------------
        [WebMethod]
        public void Delete_Vibrato(int P_Id)
        {
            La_Base.Delete_Vibrato(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public C_VIBRATO Add_Vibrato(string P_Nom, string P_Modele, string P_Marque)
        {
            return La_Base.Add_Vibrato(P_Nom, P_Modele, P_Marque);
        }
        //---------------------------------------
        [WebMethod]
        public C_VIBRATO Add_Vibrato_Object(C_VIBRATO P_Vibrato)
        {
            return La_Base.Add_Vibrato(P_Vibrato);
        }
        //---------------------------------------
        [WebMethod]
        public C_VIBRATO Update_Vibrato(C_VIBRATO P_Vibrato)
        {
            return La_Base.Update_Vibrato(P_Vibrato);
        }


        //===========================================================



        //================== GUITARE =================================
        [WebMethod]
        public List<C_GUITARE> Get_All_Guitares()
        {
            var Resultat = La_Base.Get_Guitares();
            return Resultat;
        }
        //---------------------------------------
        [WebMethod]
        public C_GUITARE Get_Guitare_By_Id(int P_Id)
        {
            return La_Base.Get_Guitare_By_Id(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public List<C_GUITARE> Get_Guitares_By_Client(C_CLIENT P_Client)
        {
            return La_Base.Get_Guitares_By_Client(P_Client);
        }
        //---------------------------------------
        [WebMethod]
        public void Delete_Guitare(int P_Id)
        {
            La_Base.Delete_Guitare(P_Id);
        }
        //---------------------------------------
        [WebMethod]
        public C_GUITARE Create_Guitare(C_CLIENT P_Client)
        {
            return La_Base.Create_Guitare(P_Client);
        }
        //---------------------------------------
        [WebMethod]
        public C_GUITARE Add_Guitare_Object(C_GUITARE P_Guitare)
        {
            return La_Base.Add_Guitare(P_Guitare);
        }
        //---------------------------------------
        [WebMethod]
        public C_GUITARE Update_Guitare(C_GUITARE P_Guitare)
        {
            return La_Base.Update_Guitare(P_Guitare);
        }
    }
}
