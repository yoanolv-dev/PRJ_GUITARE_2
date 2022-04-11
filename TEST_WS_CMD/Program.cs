// #define TEST_BOIS 
// #define TEST_CLIENT
// #define TEST_VIBRATO
//#define TEST_GUITARE
//#define TEST_CREATION_GUITARE_CLIENT

//--------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TEST_WS_CMD.NS_WS;


namespace TEST_WS_CMD
{

    internal class Program
    {

        const int NOMBRE_TEST = 10;

        static WSSoapClient Le_WS; 
        //=========================================

        static C_BOIS Nouveau_Bois;

        static void Test_Lecture_Bois()
        {
            Console.WriteLine("------ BOIS => Get_all() :");
            var Les_Bois = Le_WS.Get_All_Bois(); ;
            foreach (var element in Les_Bois) {
                Console.WriteLine(element.To_String());
            }
        }
        //----------------------
        static void Test_Ecriture_Lecture_Bois()
        {
            Console.WriteLine("------ BOIS => Add()");
            Nouveau_Bois = Le_WS.Add_Bois("Bois 1", "Origine 1");
            Console.WriteLine($" nouveau bois : {Nouveau_Bois.To_String()}");
        }
        //----------------------
        static void Test_Modification_Bois()
        {
            Console.WriteLine("------ BOIS => Update()");
            Nouveau_Bois.Origine = "Modif origine 1";
            var Nouveau = Le_WS.Update_Bois(Nouveau_Bois);
            Console.WriteLine($" bois modifié : {Nouveau.To_String()}");
        }
        //----------------------
        static void Test_Delete_Bois()
        {
            Console.WriteLine("------ BOIS => delete()");
            Le_WS.Delete_Bois(Nouveau_Bois.ID_BOIS);

        }
        //#############################################



        static C_CLIENT Nouveau_Client;

        static void Test_Lecture_Client()
        {
            Console.WriteLine("------ CLIENT => Get_all() :");
            var Les_Clients = Le_WS.Get_All_Clients(); ;
            foreach (var element in Les_Clients) {
                Console.WriteLine(element.To_String());
            }
        }
        //------------------------------------------------
        static void Test_Ecriture_Client()
        {
            Console.WriteLine("------ CLIENT => Add() :");
            Nouveau_Client = Le_WS.Add_Client("USER 1", "Email 1"); ;
            Console.WriteLine(Nouveau_Client.To_String());
        }
        //----------------------
        static void Test_Modification_Client()
        {
            Console.WriteLine("------ CLIENT => Update()");
            Nouveau_Client.Email = "Modif Email 1";
            var Nouveau = Le_WS.Update_Client(Nouveau_Client);
            Console.WriteLine($" client modifié : {Nouveau.To_String()}");
        }
        //------------------------------------------------ 
        static void Test_Delete_Client()
        {
            Console.WriteLine("------ CLIENT => delete()");
            Le_WS.Delete_Client(Nouveau_Client.ID_CLIENT);

        }
        //##############################################



        static C_MICRO Nouveau_Micro;

        static void Test_Lecture_Micro()
        {
            Console.WriteLine("------ MICRO => Get_all() :");
            var Les_Micros = Le_WS.Get_All_Micros(); ;
            foreach (var element in Les_Micros) {
                Console.WriteLine(element.To_String());
            }
        }
        //------------------------------------------------
        static void Test_Ecriture_Micro()
        {
            Console.WriteLine("------ MICRO => Add() :");
            Nouveau_Micro = Le_WS.Add_Micro("Micro 1", "reference 1", "Marque 1"); ;
            Console.WriteLine(Nouveau_Micro.To_String());
        }
        //----------------------
        static void Test_Modification_Micro()
        {
            Console.WriteLine("------ MICRO => Update()");
            Nouveau_Micro.Marque = "Modif Marque 1";
            var Nouveau = Le_WS.Update_Micro(Nouveau_Micro);
            Console.WriteLine($" Micro modifié : {Nouveau.To_String()}");
        }
        //------------------------------------------------ 
        static void Test_Delete_Micro()
        {
            Console.WriteLine("------ MICRO => delete()");
            Le_WS.Delete_Micro(Nouveau_Micro.ID_MICRO);

        }
        //########################################"



        static C_VIBRATO Nouveau_Vibrato;

        static void Test_Lecture_Vibrato()
        {
            Console.WriteLine("------ VIBRATO => Get_all() :");
            var Les_Vibratos = Le_WS.Get_All_Vibratos(); ;
            foreach (var element in Les_Vibratos) {
                Console.WriteLine(element.To_String());
            }
        }
        //------------------------------------------------
        static void Test_Ecriture_Vibrato()
        {
            Console.WriteLine("------ VIBRATO => Add() :");
            Nouveau_Vibrato = Le_WS.Add_Vibrato("Vibrato 1", "reference 1", "Marque 1"); ;
            Console.WriteLine(Nouveau_Vibrato.To_String());
        }
        //----------------------
        static void Test_Modification_Vibrato()
        {
            Console.WriteLine("------ VIBRATO => Update()");
            Nouveau_Vibrato.Marque = "Modif Marque 1";
            var Nouveau = Le_WS.Update_Vibrato(Nouveau_Vibrato);
            Console.WriteLine($" Vibrato modifié : {Nouveau.To_String()}");
        }
        //------------------------------------------------ 
        static void Test_Delete_Vibrato()
        {
            Console.WriteLine("------ VIBRATO => delete()");
            Le_WS.Delete_Vibrato(Nouveau_Vibrato.ID_VIBRATO);

        }
        //########################################"



        static C_GUITARE Nouvelle_Guitare;



        static void Test_Lecture_Guitare()
        {
            Console.WriteLine("------ GUITARE => Get_all() :");
            var Les_Guitares = Le_WS.Get_All_Guitares(); ;
            foreach (var element in Les_Guitares) {
                Console.WriteLine(element.To_String());
            }
        }
        //------------------------------------------------
        static void Test_Ecriture_Guitare()
        {
            Console.WriteLine("------ GUITARE => Add() :");


#if TEST_CREATION_GUITARE_CLIENT
            var Un_Client = Le_WS.Get_All_Clients().First();
            Nouvelle_Guitare = Le_WS.Create_Guitare(Un_Client);
#else
  C_GUITARE Nouvelle = new C_GUITARE() {
                Le_Bois_Corps = Le_WS.Get_All_Bois().First(),
                Le_Bois_Touche = Le_WS.Get_All_Bois().First(),
                Le_Bois_Manche = Le_WS.Get_All_Bois().First(),
                Le_Micro_Bridge = Le_WS.Get_All_Micros().First(),
                Le_Micro_Central = Le_WS.Get_All_Micros().First(),
                Le_Micro_Neck = Le_WS.Get_All_Micros().First(),
                Le_Vibrato = Le_WS.Get_All_Vibratos().First(),
                Le_Proprietaire = Le_WS.Get_All_Clients().First()
            };
            Nouvelle_Guitare = Le_WS.Add_Guitare_Object(Nouvelle);
#endif
            Console.WriteLine(Nouvelle_Guitare.To_String());
        }

        //------------------------------------------------

        static void Test_Modification_Guitare()
        {
            Console.WriteLine("------ GUITARE => Update()");
            Nouvelle_Guitare.Le_Bois_Corps = Le_WS.Get_All_Bois()[1];
            var Nouveau = Le_WS.Update_Guitare(Nouvelle_Guitare);
            Console.WriteLine($" Guitare modifiée : {Nouveau.To_String()}");
        }
        //------------------------------------------------ 
        static void Test_Delete_Guitare()
        {
            Console.WriteLine("------ GUITARE => delete()");
            Le_WS.Delete_Guitare(Nouvelle_Guitare.ID_GUITARE);

        }
        //------------------------------------------------

        static void Main(string[] args)
        {
            try {
                Le_WS = new WSSoapClient();
            } catch(Exception P_Erreur) {
                Console.WriteLine(P_Erreur.Message);
                return;
            }

            Console.WriteLine($"WS Bois :{Le_WS.InnerChannel.RemoteAddress}");

#if TEST_BOIS
            for (int Compteur = 0; Compteur < NOMBRE_TEST; Compteur++) {
                Test_Lecture_Bois();
                Test_Ecriture_Lecture_Bois();
                Test_Lecture_Bois();
                Test_Modification_Bois();
                 Test_Lecture_Bois();
                Test_Delete_Bois();
                Test_Lecture_Bois();
                Console.WriteLine("================");
            }
#endif

#if TEST_CLIENT
            for (int Compteur = 0; Compteur < NOMBRE_TEST; Compteur++) {
                Test_Lecture_Client();
                Test_Ecriture_Client();
                Test_Lecture_Client();
                Test_Modification_Client();
                 Test_Lecture_Client();
                Test_Delete_Client();
                Test_Lecture_Client();
                Console.WriteLine("================");
            }
#endif

#if TEST_MICRO
            for (int Compteur = 0; Compteur < NOMBRE_TEST; Compteur++) {
                Test_Lecture_Micro();
                Test_Ecriture_Micro();
                Test_Lecture_Micro();
                Test_Modification_Micro();
                Test_Lecture_Micro();
                Test_Delete_Micro();
                Test_Lecture_Micro();
                Console.WriteLine("================");
            }
#endif

#if TEST_VIBRATO
            for (int Compteur = 0; Compteur < NOMBRE_TEST; Compteur++) {
                Test_Lecture_Vibrato();
                Test_Ecriture_Vibrato();
                Test_Lecture_Vibrato();
                Test_Modification_Vibrato();
                Test_Lecture_Vibrato();
                Test_Delete_Vibrato();
                Test_Lecture_Vibrato();
                Console.WriteLine("================");
            }
#endif

#if TEST_GUITARE
            for (int Compteur = 0; Compteur < NOMBRE_TEST; Compteur++) {
                Test_Lecture_Guitare();
                Test_Ecriture_Guitare();
                Test_Lecture_Guitare();
                Test_Modification_Guitare();
                Test_Lecture_Guitare();
                Test_Delete_Guitare();
                Test_Lecture_Guitare();
                Console.WriteLine("================");
            }
#endif

            //var les_guitares = Le_WS.Get_All_Guitares();
            //foreach(var une_guitare in les_guitares) {
            //    if (une_guitare.ID_GUITARE > 3) Le_WS.Delete_Guitare(une_guitare.ID_GUITARE);
            //}

        }
    }
}
