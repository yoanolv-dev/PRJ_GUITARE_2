using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using LIB_BASE;



namespace TEST_LIB_CMD
{
    //--------------------------------------------
    internal class Program
    {
        static void Main(string[] args)
        {
            C_BASE La_Base;

            try {
               La_Base = new C_BASE();

            } catch(Exception P_Erreur) {
                Console.WriteLine(P_Erreur.Message);
                return;
            }

         //   La_Base.Delete_All_Guitares();

            Console.WriteLine("============== BOIS =============");
            //La_Base.Delete_All_Bois();

            //for (int Compteur = 0; Compteur < 10; Compteur++) {
            //    La_Base.Add_Bois($"BOIS {DateTime.Now.Millisecond.ToString()}", $"Origine {DateTime.Now.Second.ToString()}");
            //    Thread.Sleep(1);
            //}

            var Liste_Bois = La_Base.Get_Bois();
            Console.WriteLine(Liste_Bois.Count);
            foreach (C_BOIS Un_Bois in Liste_Bois) {
                Console.WriteLine(Un_Bois.To_String());
            }

            Console.WriteLine("=============  MICROS ==============");
            //La_Base.Delete_All_Micros();

            //for (int Compteur = 0; Compteur < 10; Compteur++) {
            //    La_Base.Add_Micro($"MICRO {DateTime.Now.Millisecond.ToString()}",
            //        $"REF {DateTime.Now.Second.ToString()}", $"MARQUE {DateTime.Now.Second.ToString()}");
            //    Thread.Sleep(1);
            //}


            var Liste_Micros = La_Base.Get_Micros();
            Console.WriteLine(Liste_Micros.Count);
            foreach (C_MICRO Un_Micro in Liste_Micros) {
                Console.WriteLine(Un_Micro.To_String());
            }

            Console.WriteLine("=============  VIBRATOS ==============");
        //   La_Base.Delete_All_Vibratos();

            //for (int Compteur = 0; Compteur < 10; Compteur++) {
            //    La_Base.Add_Vibrato($"VIB {DateTime.Now.Millisecond.ToString()}",
            //        $"REF {DateTime.Now.Second.ToString()}", $"MARQUE {DateTime.Now.Second.ToString()}");
            //    Thread.Sleep(1);
            //}


            var Liste_Vibrato = La_Base.Get_Vibratos();
            Console.WriteLine(Liste_Vibrato.Count);
            foreach (C_VIBRATO Un_Vibrato in Liste_Vibrato) {
                Console.WriteLine(Un_Vibrato.To_String());
            }



            Console.WriteLine("=============  CLIENTS ==============");
            //La_Base.Delete_All_Clients();

            //for (int Compteur = 0; Compteur < 5; Compteur++) {
            //    La_Base.Add_Client($"CLIENT {DateTime.Now.Millisecond.ToString()}",
            //        $"EMAIL {DateTime.Now.Millisecond.ToString()}");
            //    Thread.Sleep(1);
            //}


            var Liste_Clients = La_Base.Get_Clients();
            Console.WriteLine(Liste_Clients.Count);
            foreach (C_CLIENT Un_Client in Liste_Clients) {
                Console.WriteLine(Un_Client.To_String()) ;
            }

            Console.WriteLine("=============  GUITARES ==============");
            //     La_Base.Delete_All_Guitares();

            //for (int Compteur = 0; Compteur < 5; Compteur++) {
            //    C_GUITARE Nouvelle = new C_GUITARE();
            //    Nouvelle.Le_Proprietaire = Liste_Clients[0 + Compteur];
            //    Nouvelle.Le_Micro_Bridge = Liste_Micros[0 + Compteur];
            //    Nouvelle.Le_Micro_Central = Liste_Micros[1 + Compteur];
            //    Nouvelle.Le_Micro_Neck = Liste_Micros[2 + Compteur];
            //    Nouvelle.Le_Bois_Corps = Liste_Bois[0 + Compteur];
            //    Nouvelle.Le_Bois_Manche = Liste_Bois[1 + Compteur];
            //    Nouvelle.Le_Bois_Touche = Liste_Bois[2 + Compteur];
            //    Nouvelle.Le_Vibrato = Liste_Vibrato[0 + Compteur];
            //    La_Base.Add_Guitare(Nouvelle);
            //}


            var Liste_Guitares = La_Base.Get_Guitares();
            Console.WriteLine(Liste_Guitares.Count);
            foreach (C_GUITARE Une_guitare in Liste_Guitares) {
                //Console.WriteLine($"{Une_guitare.ID_GUITARE}\n" +
                //    $"\t{Une_guitare.Le_Proprietaire.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Bois_Corps.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Bois_Manche.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Bois_Touche.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Micro_Bridge.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Micro_Central.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Micro_Neck.To_String()} \n" +
                //    $"\t{Une_guitare.Le_Vibrato.To_String()}");
                Console.WriteLine(Une_guitare.To_String()); ;
            }
            Console.WriteLine("===========================");

            //La_Base.Delete_Bois(Liste_Bois[Liste_Bois.Count - 1]);

            //Liste_Bois = La_Base.Get_Bois();
            //Console.WriteLine(Liste_Bois.Count);
            //foreach (C_BOIS Un_Bois in Liste_Bois) {
            //    Console.WriteLine(Un_Bois.To_String());
            //}
        }
    }
}
