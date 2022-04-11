using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IHM_GUITARE_CLIENT.A;



namespace IHM_GUITARE_CLIENT.C
{
    
    public class C_COORDINATION : C_NOTIFIABLE
    {
        WSSoapClient Le_WS = new WSSoapClient();
       
        //................
        public ObservableCollection<C_BOIS> Les_Bois { get; set; }


        private ObservableCollection<C_GUITARE> _Les_Guitares;

        public ObservableCollection<C_GUITARE> Les_Guitares {
            get { return _Les_Guitares; }
            set { _Les_Guitares = value;
                Signale_Changement();
            }
        }

        public ObservableCollection<C_CLIENT> Les_Clients { get; set; }
        //................
        private C_GUITARE _Nouvelle_Guitare = new C_GUITARE() { ID_GUITARE = 0 };
        public C_GUITARE Nouvelle_Guitare {
            get { return _Nouvelle_Guitare; }
            set {
                _Nouvelle_Guitare = value;
                Signale_Changement();
            }
        }
        //................

        ////................
        private C_GUITARE _Guitare_Actelle = new C_GUITARE() { ID_GUITARE = 0 };
        public C_GUITARE Guitare_Actelle {
            get { return _Guitare_Actelle; }
            set {
                _Guitare_Actelle = value;
                Signale_Changement();
        //        Signale_Changement(_Guitare_Actelle, nameof(Guitare_Actelle.Le_Bois_Corps));
            }
        }
        ////................

        private C_CLIENT _Client_Actuel;

        public C_CLIENT Client_Actuel {
            get { return _Client_Actuel; }
            set { _Client_Actuel = value; Signale_Changement(); }
        }

        ////--------------------------------------------
        private C_COORDINATION()
        {
            Les_Bois = new ObservableCollection<C_BOIS>(Le_WS.Get_All_Bois());
            Les_Guitares = new ObservableCollection<C_GUITARE>(Le_WS.Get_All_Guitares());
            Les_Clients = new ObservableCollection<C_CLIENT>(Le_WS.Get_All_Clients());
            //simulation
            Client_Actuel = Le_WS.Get_Clients_By_Nom("JLV").First();
            Guitare_Actelle = Le_WS.Get_Guitares_By_Client(Client_Actuel).First();

        }
        //------------------------------------

        static private C_COORDINATION _Instance=null;

        static public C_COORDINATION Instance {
            get { 
                if (_Instance == null) _Instance = new C_COORDINATION();
                return _Instance; 
                }        
        }
        //##############################################################

        public void Valider_Guitare()
        {
            if (_Nouvelle_Guitare.ID_GUITARE != 0) {
                Nouvelle_Guitare = Le_WS.Update_Guitare(_Nouvelle_Guitare);
            } 
            //else {
            //    Nouvelle_Guitare = Le_WS.Create_Guitare(Client_Actuel);
            //}
           
        }

        public void Creation_Guitare()
        {
            Nouvelle_Guitare = Le_WS.Create_Guitare(Client_Actuel);
           
        }

        public void Actualiser_Liste_Guitares()
        {
            Les_Guitares = new ObservableCollection<C_GUITARE>(Le_WS.Get_All_Guitares());
        }
    }
}
