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
         LoadoutList loadoutList;
         String oldWeapon;
        
        public MainWindow()
        {
            InitializeComponent();
            this.loadoutList = new LoadoutList();
            oldWeapon = "";
        }




        private void ChangeToSqf_Click(object sender, RoutedEventArgs e)
        {
            loadoutList.createSqfFile();
            MessageBox.Show("loadout tiedostosi on luotu työpöydälle nimellä newLoadOut");
        }



     

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int index = roleList.SelectedIndex;
            String roleClicked = roleList.Items[index].ToString();

            Box_Loadout.Text = this.loadoutList.getLoadout(roleClicked);
            role.Text = roleClicked;
            weaponBox.Text = this.loadoutList.returnLoadout(roleClicked).weapon;
            oldWeapon = this.loadoutList.returnLoadout(roleClicked).weapon;
            Box_Uniform.Text = this.loadoutList.returnLoadout(roleClicked).uniform;
            Box_Vest.Text = this.loadoutList.returnLoadout(roleClicked).vest;
            Box_bacpack.Text = this.loadoutList.returnLoadout(roleClicked).backpack;
            Box_HeadGear.Text = this.loadoutList.returnLoadout(roleClicked).headGear;


        }

        public void createRole_Click(object sender, RoutedEventArgs e)
        {
            Window luoRooli = new CreateRole(loadoutList, roleList);
            luoRooli.Show();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_Loadout_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void editLoadout_Click(object sender, RoutedEventArgs e)
        {
            if (loadoutList.roleExist(this.role.Text))
            {
                loadoutList.editLoadout(this.role.Text, this.Box_Loadout.Text);
            }
            else
            {
                MessageBox.Show("Roolia ei löytynyt");
            }

            
        }

        private void WeaponBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            // This doesn't work
            String[] items = Box_Loadout.Text.Split(' ');
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals("addWeapon"))
                {
                    items[i + 1] = weaponBox.Text;
                    oldWeapon = weaponBox.Text;
                }
            }
        }

        private void Box_Uniform_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_Vest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_bacpack_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Box_HeadGear_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
