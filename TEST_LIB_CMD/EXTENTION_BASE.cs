
using LIB_BASE;



namespace TEST_LIB_CMD
{
    static class EXTENTION_BASE
    {

        public static string To_String(this C_CLIENT P_Client)
        {
            if (P_Client!=null) return $"{ P_Client.ID_CLIENT} { P_Client.Nom}{ P_Client.Email}";
            return "null";
        }

        public static string To_String(this C_VIBRATO P_Vibrato)
        {
            if (P_Vibrato != null) return $"{P_Vibrato.ID_VIBRATO} {P_Vibrato.Nom} {P_Vibrato.Modele} {P_Vibrato.Marque}";
            else return "null";
        }
        public static string To_String(this C_BOIS P_Bois)
        {
            if (P_Bois!=null)  return $"{P_Bois.ID_BOIS} {P_Bois.Nom} {P_Bois.Origine}";
            return "null";
        }

        public static string To_String(this C_MICRO P_Micro)
        {
            if (P_Micro != null) return $"ID :{P_Micro.ID_MICRO}   Nom :{P_Micro.Nom}  Ref :{P_Micro.Reference} Marque :{P_Micro.Marque}";
            else return "null";
        }

   
        public static string To_String(this C_GUITARE P_Guitare)
        {
            if (P_Guitare != null) return $"ID : {P_Guitare.ID_GUITARE}\n" +
                      $"\tClient        : {P_Guitare.Le_Proprietaire.To_String()} \n" +
                      $"\tBois Corps    : {P_Guitare.Le_Bois_Corps.To_String()} \n" +
                      $"\tBois Manche   : {P_Guitare.Le_Bois_Manche.To_String()} \n" +
                      $"\tBois Touche   : {P_Guitare.Le_Bois_Touche.To_String()} \n" +
                      $"\tMicro Bridge  : {P_Guitare.Le_Micro_Bridge.To_String()} \n" +
                      $"\tMicro Central : {P_Guitare.Le_Micro_Central.To_String()} \n" +
                      $"\tMicro Neck    : {P_Guitare.Le_Micro_Neck.To_String()} \n" +
                      $"\tVibrato       : {P_Guitare.Le_Vibrato.To_String()}";
            else return "null";

        }
 

    }
}
