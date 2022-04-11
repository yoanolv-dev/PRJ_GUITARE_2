using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;


namespace LIB_BASE
{

    //class C_CONFIGURATION : DbConfiguration
    //{
    //    //public C_CONFIGURATION()
    //    //{
    //    //    //  Console.WriteLine("Construction de C_CONFIGURATION");

    //    //    SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());

    //    //    // SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb"));

    //    //    // this.Configuration.ProxyCreationEnabled = false;

    //    //}
    //}
    //----------------------
    public class C_BASE
    {
        static C_BASE_AZURE La_Base_Azure = new C_BASE_AZURE();
        public C_BASE()
        {
            //     La_Base_Azure.Configuration.LazyLoadingEnabled = false;
            //    La_Base_Azure.Configuration.ProxyCreationEnabled = false;

            La_Base_Azure.Les_Bois.Load();
            La_Base_Azure.Les_Micros.Load();
            La_Base_Azure.Les_Vibratos.Load();
            La_Base_Azure.Les_Clients.Load();
            La_Base_Azure.Les_Guitares.Load();
        }


        //================== BOIS ========================

        //-------------------------------------
        public List<C_BOIS> Get_Bois()
        {
           // La_Base_Azure.Les_Bois.Load();
            return La_Base_Azure.Les_Bois.ToList();
        }
        //-------------------------------------
        public C_BOIS Get_Bois_By_Id(int P_Id)
        {
            var Requete = from un_bois in La_Base_Azure.Les_Bois 
                          where un_bois.ID_BOIS== P_Id select un_bois;
            return Requete.FirstOrDefault();
        }
        //-------------------------------------
        public List<C_BOIS> Get_Bois_By_Nom(string P_Nom)
        {
            var Requete = from un_bois in La_Base_Azure.Les_Bois 
                          where un_bois.Nom.Contains(P_Nom) select un_bois;
            return Requete.ToList();
        }

        //-------------------------------------
        public C_BOIS Add_Bois(string P_Nom, string P_Origine = "Non spécifié")
        {
            C_BOIS Nouveau_Bois = new C_BOIS() { Nom = P_Nom, Origine = P_Origine };
            La_Base_Azure.Les_Bois.Add(Nouveau_Bois);
            La_Base_Azure.SaveChanges();
            return Nouveau_Bois;
        }
        //-------------------------------------

        public C_BOIS Add_Bois(C_BOIS P_Bois)
        {
            C_BOIS Le_Bois = (from Un_Bois in La_Base_Azure.Les_Bois
                              where Un_Bois.ID_BOIS==P_Bois.ID_BOIS 
                              select Un_Bois).FirstOrDefault();
            C_BOIS Nouveau_Bois = null;
            if (Le_Bois == null) {
                Nouveau_Bois = new C_BOIS() { Nom = P_Bois.Nom, Origine = P_Bois.Origine };
                La_Base_Azure.Les_Bois.Add(Nouveau_Bois);
                La_Base_Azure.SaveChanges();
            }
            return Nouveau_Bois;
        }
        //-------------------------------------
        public void Delete_Bois(int P_Id)
        {
            C_BOIS Le_Bois = (from un_bois in La_Base_Azure.Les_Bois 
                              where un_bois.ID_BOIS == P_Id select un_bois).FirstOrDefault();
            if (Le_Bois != null) {
                La_Base_Azure.Entry(Le_Bois).State = EntityState.Unchanged;
                La_Base_Azure.Les_Bois.Remove(Le_Bois);
                La_Base_Azure.SaveChanges();
            }

        }

        //-------------------------------------
        public C_BOIS Update_Bois(C_BOIS P_Bois)
        {
            C_BOIS Le_Bois = (from un_bois in La_Base_Azure.Les_Bois 
                              where un_bois.ID_BOIS == P_Bois.ID_BOIS 
                              select un_bois).FirstOrDefault();

            if (Le_Bois != null) {
                Le_Bois.Nom = P_Bois.Nom;
                Le_Bois.Origine = P_Bois.Origine;
                La_Base_Azure.SaveChanges();
            }
            return Le_Bois;
           
        }
        //-------------------------------------
        public void Delete_All_Bois()
        {
            La_Base_Azure.DELETE_ALL_BOIS();
        }

        //================== MICROS ========================
        public List<C_MICRO> Get_Micros()
        {
            return La_Base_Azure.Les_Micros.ToList();
        }
        //-------------------------------------
        public List<C_MICRO> Get_Micro_By_Nom(string P_Nom)
        {
            var Requete = from Un_Micro in La_Base_Azure.Les_Micros
                          where Un_Micro.Nom.Contains(P_Nom) select Un_Micro;
            return Requete.ToList();
        }
        //-------------------------------------
        public C_MICRO Get_Micro_By_Id(int P_Id)
        {
            var Requete = from Un_Micro in La_Base_Azure.Les_Micros
                          where Un_Micro.ID_MICRO==P_Id select Un_Micro;
            return Requete.FirstOrDefault();
        }
        //-------------------------------------
        public C_MICRO Add_Micro(string P_Nom, string P_Reference, string P_Marque)
        {
            C_MICRO Nouveau_Micro = new C_MICRO() { Nom = P_Nom, Reference = P_Reference,
                                         Marque = P_Marque };
            La_Base_Azure.Les_Micros.Add(Nouveau_Micro);
            La_Base_Azure.SaveChanges();
            return Nouveau_Micro;
        }
        //-------------------------------------
        public C_MICRO Add_Micro(C_MICRO P_Micro)
        {
            C_MICRO Le_Micro = (from Un_Micro in La_Base_Azure.Les_Micros
                              where Un_Micro.ID_MICRO == P_Micro.ID_MICRO select Un_Micro).FirstOrDefault();
            C_MICRO Nouveau = null;
            if (Le_Micro == null) {
                Nouveau = new C_MICRO() { Nom = P_Micro.Nom, Marque = P_Micro.Marque,
                                         Reference = P_Micro.Reference };
                La_Base_Azure.Les_Micros.Add(Nouveau);
                La_Base_Azure.SaveChanges();
            }
            return Nouveau;
        }
        //-------------------------------------
        public void Delete_Micro(int P_Id)
        {
            C_MICRO Le_Micro = (from un_micro in La_Base_Azure.Les_Micros 
                                where un_micro.ID_MICRO == P_Id select un_micro).FirstOrDefault();
            if (Le_Micro != null) {
                La_Base_Azure.Entry(Le_Micro).State = EntityState.Unchanged;
                La_Base_Azure.Les_Micros.Remove(Le_Micro);
                La_Base_Azure.SaveChanges();
            }
        }
        //-------------------------------------
        public C_MICRO Update_Micro(C_MICRO P_Micro)
        {
            C_MICRO Le_Micro = (from Un_Micro in La_Base_Azure.Les_Micros
                                where Un_Micro.ID_MICRO == P_Micro.ID_MICRO select Un_Micro).FirstOrDefault();
            if (Le_Micro != null) {
                Le_Micro.Nom = P_Micro.Nom;
                Le_Micro.Reference = P_Micro.Reference;
                Le_Micro.Marque = P_Micro.Marque;
                La_Base_Azure.SaveChanges();
            }
            return Le_Micro;
        }
        //-------------------------------------
        public void Delete_All_Micros()
        {
            La_Base_Azure.DELETE_ALL_MICRO();
        }
        //================== VIBRATOS ========================
        public List<C_VIBRATO> Get_Vibratos()
        {
            return La_Base_Azure.Les_Vibratos.ToList();
        }
        //-------------------------------------
        public List<C_VIBRATO> Get_Vibrato_By_Nom(string P_Nom)
        {
            var Requete = from Un_Vibrato in La_Base_Azure.Les_Vibratos
                          where Un_Vibrato.Nom.Contains(P_Nom) select Un_Vibrato;
            return Requete.ToList();
        }
        //-------------------------------------
        public C_VIBRATO Get_Vibrato_By_Id(int P_Id)
        {
            var Requete = from Un_Vibrato in La_Base_Azure.Les_Vibratos
                          where Un_Vibrato.ID_VIBRATO == P_Id select Un_Vibrato;
            return Requete.FirstOrDefault();
        }
        //-------------------------------------
        public C_VIBRATO Add_Vibrato(string P_Nom, string P_Modele, string P_Marque)
        {
            C_VIBRATO Nouveau_Vibrato = new C_VIBRATO() { Nom = P_Nom, Modele = P_Modele, Marque = P_Marque };
            La_Base_Azure.Les_Vibratos.Add(Nouveau_Vibrato);
            La_Base_Azure.SaveChanges();
            return Nouveau_Vibrato;
        }
        //-------------------------------------
        public C_VIBRATO Add_Vibrato(C_VIBRATO P_Vibrato)
        {
            C_VIBRATO le_Vibrato = (from Un_Vibrato in La_Base_Azure.Les_Vibratos
                                  where Un_Vibrato.ID_VIBRATO == P_Vibrato.ID_VIBRATO select Un_Vibrato).FirstOrDefault();
            C_VIBRATO Nouveau = null;
            if (le_Vibrato == null) {
                Nouveau = new C_VIBRATO() {
                    Nom = P_Vibrato.Nom, Marque = P_Vibrato.Marque,
                    Modele = P_Vibrato.Modele
                };
                La_Base_Azure.Les_Vibratos.Add(Nouveau);
                La_Base_Azure.SaveChanges();
            }
            return Nouveau;
        }
        //-------------------------------------
        public void Delete_Vibrato(int P_Id)
        {
            C_VIBRATO Le_Vibrato = (from un_vibrato in La_Base_Azure.Les_Vibratos
                                where un_vibrato.ID_VIBRATO == P_Id select un_vibrato).FirstOrDefault();
            if (Le_Vibrato != null) {
                La_Base_Azure.Entry(Le_Vibrato).State = EntityState.Unchanged;
                La_Base_Azure.Les_Vibratos.Remove(Le_Vibrato);
                La_Base_Azure.SaveChanges();
            }
        }
        //-------------------------------------
        public C_VIBRATO Update_Vibrato(C_VIBRATO P_Vibrato)
        {
            C_VIBRATO Le_Vibrato = (from Un_Vibrato in La_Base_Azure.Les_Vibratos
                                    where Un_Vibrato.ID_VIBRATO == Un_Vibrato.ID_VIBRATO select Un_Vibrato).FirstOrDefault();
            if (Le_Vibrato != null) {
                Le_Vibrato.Nom = P_Vibrato.Nom;
                Le_Vibrato.Modele = P_Vibrato.Modele;
                Le_Vibrato.Marque = P_Vibrato.Marque;
                La_Base_Azure.SaveChanges();
            }
         
            return Le_Vibrato;
        }
        //-------------------------------------
        public void Delete_All_Vibratos()
        {
            La_Base_Azure.DELETE_ALL_VIBRATO();
        }


        //================== CLIENTS ========================
        public List<C_CLIENT> Get_Clients()
        {
            return La_Base_Azure.Les_Clients.ToList();
        }
        //-------------------------------------
        public List<C_CLIENT> Get_Client_By_Nom(string P_Nom)
        {
            var Requete = from Un_Client in La_Base_Azure.Les_Clients
                          where Un_Client.Nom.Contains(P_Nom) select Un_Client;
            return Requete.ToList();
        }
        //-------------------------------------
        public C_CLIENT Get_Client_By_Id(int P_Id)
        {
            var Requete = from Un_Client in La_Base_Azure.Les_Clients
                          where Un_Client.ID_CLIENT==P_Id select Un_Client;
            return Requete.FirstOrDefault();
        }
        //-------------------------------------
        public C_CLIENT Add_Client(string P_Nom, string P_Email)
        {
            C_CLIENT Le_Client = (from Un_Client in La_Base_Azure.Les_Clients
                          where Un_Client.Nom==P_Nom select Un_Client).FirstOrDefault();
            C_CLIENT Nouveau_Client = null;
            if (Le_Client == null) {
                Nouveau_Client = new C_CLIENT() { Nom = P_Nom, Email = P_Email };
                La_Base_Azure.Les_Clients.Add(Nouveau_Client);
                La_Base_Azure.SaveChanges();
            }
            return Nouveau_Client;
        }
        //-------------------------------------
        public C_CLIENT Add_Client(C_CLIENT P_Client)
        {
            C_CLIENT Le_Client = (from Un_Client in La_Base_Azure.Les_Clients
                                  where Un_Client.ID_CLIENT==P_Client.ID_CLIENT select Un_Client).FirstOrDefault();
            C_CLIENT Nouveau_Client = null;
            if (Le_Client == null) {
                Nouveau_Client = new C_CLIENT() { Nom = P_Client.Nom, Email = P_Client.Email };
                La_Base_Azure.Les_Clients.Add(Nouveau_Client);
                La_Base_Azure.SaveChanges();
            }
            return Nouveau_Client;
        }
        //-------------------------------------
        public void Delete_Client(int P_Id)
        {
            C_CLIENT Le_Client = (from Un_Client in La_Base_Azure.Les_Clients
                                  where Un_Client.ID_CLIENT==P_Id select Un_Client).FirstOrDefault();

            if (Le_Client != null) {
                La_Base_Azure.Entry(Le_Client).State = EntityState.Unchanged;
                La_Base_Azure.Les_Clients.Remove(Le_Client);
                La_Base_Azure.SaveChanges();
            }
        }
        //-------------------------------------
        public C_CLIENT Update_Client(C_CLIENT P_Client)
        {
            C_CLIENT Le_Client = (from Un_Client in La_Base_Azure.Les_Clients
                                  where Un_Client.ID_CLIENT == P_Client.ID_CLIENT select Un_Client).FirstOrDefault();
            if (Le_Client != null) {
                Le_Client.Nom = P_Client.Nom;
                Le_Client.Email = P_Client.Email;
                La_Base_Azure.SaveChanges();
            }
            return Le_Client;
       
        }
        //-------------------------------------
        public void Delete_All_Clients()
        {
            La_Base_Azure.DELETE_ALL_CLIENT();
        }

        //================== GUITARES ========================
        public List<C_GUITARE> Get_Guitares()
        {
          //  La_Base_Azure.Les_Guitares.Load();
            return La_Base_Azure.Les_Guitares.ToList();
        }
        //-------------------------------------

        public C_GUITARE Get_Guitare_By_Id(int P_Id)
        {
            C_GUITARE Guitare = (from Une_Guitare in La_Base_Azure.Les_Guitares
                          where Une_Guitare.ID_GUITARE == P_Id select Une_Guitare).FirstOrDefault();
            return Guitare;
        }
        //-------------------------------------
        public List<C_GUITARE> Get_Guitares_By_Client(C_CLIENT P_Client)
        {
            var Requete = from Une_Guitare in La_Base_Azure.Les_Guitares
                          where Une_Guitare.IdClient == P_Client.ID_CLIENT select Une_Guitare;
            return Requete.ToList();
        }
        //-------------------------------------
        public C_GUITARE Create_Guitare(C_CLIENT P_Client)
        {
            C_GUITARE Nouvelle_Guitare=null;
            try {

                var Le_Client = (from un_client in La_Base_Azure.Les_Clients
                                 where un_client.ID_CLIENT == P_Client.ID_CLIENT select un_client).FirstOrDefault();
                if (Le_Client != null) {
                    Nouvelle_Guitare = new C_GUITARE() { Le_Proprietaire = Le_Client };
                    La_Base_Azure.Les_Guitares.Add(Nouvelle_Guitare);
                    La_Base_Azure.SaveChanges();
                }
            }
            catch (Exception) {
                Nouvelle_Guitare = null;
            }
            return Nouvelle_Guitare;
        }


        //-------------------------------------
        public C_GUITARE Add_Guitare(C_GUITARE P_Guitare)
        {
            C_GUITARE La_Guitare= (from une_guitare in La_Base_Azure.Les_Guitares
                                    where une_guitare.ID_GUITARE== P_Guitare.ID_GUITARE select une_guitare).FirstOrDefault();
            C_GUITARE Nouveau = null;
            if (La_Guitare == null) {
                Nouveau = new C_GUITARE() {
                IdBois_Corps = P_Guitare.Le_Bois_Corps?.ID_BOIS,
                IdBois_Touche = P_Guitare.Le_Bois_Touche?.ID_BOIS,
                IdBois_Manche = P_Guitare.Le_Bois_Manche?.ID_BOIS,
                IdMicro_Bridge = P_Guitare.Le_Micro_Bridge?.ID_MICRO,
                IdMicro_Central = P_Guitare.Le_Micro_Central?.ID_MICRO,
                IdMicro_Neck = P_Guitare.Le_Micro_Neck?.ID_MICRO,
                IdVibrato = P_Guitare.Le_Vibrato?.ID_VIBRATO,
                IdClient = P_Guitare.Le_Proprietaire?.ID_CLIENT,
                };
                La_Base_Azure.Les_Guitares.Add(Nouveau);
                La_Base_Azure.SaveChanges();
            }
            return Nouveau;
        }
        //-------------------------------------
        public void Delete_Guitare(int P_Id)
        {
            C_GUITARE La_Guitare = (from Une_Guitare in La_Base_Azure.Les_Guitares
                                    where Une_Guitare.ID_GUITARE == P_Id select Une_Guitare).FirstOrDefault();

            if (La_Guitare != null) {
                La_Base_Azure.Entry(La_Guitare).State = System.Data.Entity.EntityState.Unchanged;
                La_Base_Azure.Les_Guitares.Remove(La_Guitare);
                La_Base_Azure.SaveChanges();
            }
        }
        //-------------------------------------
        public C_GUITARE Update_Guitare(C_GUITARE P_Guitare)
        {
            C_GUITARE La_Guitare = (from Une_Guitare in La_Base_Azure.Les_Guitares
                                    where Une_Guitare.ID_GUITARE == P_Guitare.ID_GUITARE select Une_Guitare).FirstOrDefault();
            if (La_Guitare != null) {
                La_Guitare.IdBois_Corps = P_Guitare.Le_Bois_Corps?.ID_BOIS;
                La_Guitare.IdBois_Touche = P_Guitare.Le_Bois_Touche?.ID_BOIS;
                La_Guitare.IdBois_Manche = P_Guitare.Le_Bois_Manche?.ID_BOIS;
                La_Guitare.IdMicro_Bridge = P_Guitare.Le_Micro_Bridge?.ID_MICRO;
                La_Guitare.IdMicro_Central = P_Guitare.Le_Micro_Central?.ID_MICRO;
                La_Guitare.IdMicro_Neck = P_Guitare.Le_Micro_Neck?.ID_MICRO;
                La_Guitare.IdVibrato = P_Guitare.Le_Vibrato?.ID_VIBRATO;
                La_Guitare.IdClient = P_Guitare.Le_Proprietaire?.ID_CLIENT;

                La_Base_Azure.Entry(La_Guitare).State = System.Data.Entity.EntityState.Modified;
                La_Base_Azure.SaveChanges();
            }
     
            return La_Guitare;
        }
        //-------------------------------------
        public void Delete_All_Guitares()
        {
            La_Base_Azure.DELETE_ALL_GUITARE();
        }



        //=============================
    }
}
