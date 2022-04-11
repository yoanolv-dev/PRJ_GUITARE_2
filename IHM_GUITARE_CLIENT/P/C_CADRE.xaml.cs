using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using IHM_GUITARE_CLIENT.C;

namespace IHM_GUITARE_CLIENT
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class C_CADRE : Window
    {
        C_COORDINATION La_Coordination = C_COORDINATION.Instance;
        public C_CADRE()
        {
            InitializeComponent();
            DataContext = La_Coordination;
        }

   

        private void Bouton_New_Click(object sender, RoutedEventArgs e)
        {
            La_Coordination.Creation_Guitare();
        }

        private void Bouton_Update_Click(object sender, RoutedEventArgs e)
        {
            La_Coordination.Valider_Guitare();
        }

        private void Bouton_Actualiser_Liste_Guitares_Click(object sender, RoutedEventArgs e)
        {
            La_Coordination.Actualiser_Liste_Guitares();
        }
    }
}
