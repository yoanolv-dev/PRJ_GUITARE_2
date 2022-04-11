using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IHM_GUITARE_CLIENT.C
{
   public  class C_NOTIFIABLE : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Signale_Changement([CallerMemberName] string P_Nom = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(P_Nom));
        }

        public void Signale_Changement(object P_Objet, [CallerMemberName] string P_Nom = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(P_Objet, new PropertyChangedEventArgs(P_Nom));
        }
    }
}
