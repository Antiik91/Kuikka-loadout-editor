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
using System.Windows.Shapes;

namespace KuikkaLoadoutEditor
{
    /// <summary>
    /// Interaction logic for CreateRole.xaml
    /// </summary>
    public partial class CreateRole : Window
    {
        LoadoutList loadoutList;
        ComboBox roleList;

        public CreateRole(LoadoutList loadoutList,ComboBox roleList)
        {
            this.loadoutList = loadoutList;
            this.roleList = roleList;

            InitializeComponent();
        }

        private void arsenalLoadout_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void newLoadout_Click(object sender, RoutedEventArgs e)
        {
                       
            this.loadoutList.add(new Loadout(role.Text, arsenalLoadout.Text));
            roleList.Items.Add(role.Text);
            this.arsenalLoadout.Text = "";
            this.role.Text = "";

        }

        private void role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
