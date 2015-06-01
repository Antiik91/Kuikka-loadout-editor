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

namespace KuikkaLoadoutEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoadoutList loadoutList;
        public MainWindow()
        {
            InitializeComponent();
            this.loadoutList = new LoadoutList();
        }

        private void arsenalLoadout_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void newLoadout_Click(object sender, RoutedEventArgs e)
        {
            this.loadoutList.add(new Loadout(role.Text, arsenalLoadout.Text));
            this.roleList.Items.Add(role.Text);
            this.arsenalLoadout.Text = "";
            this.role.Text = "";
            
            
        }

        private void ChangeToSqf_Click(object sender, RoutedEventArgs e)
        {
            loadoutList.createSqfFile();
            MessageBox.Show("loadout tiedostosi on luotu C:n juureen nimellä newLoadOut");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
