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

namespace ShareStuff {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //Superhero batMan = new Superhero("Bat","Man","Black");
            //batMan.Identity = new Citizen("Bruce", "Wayne");

            //Citizen wasBatMan = batMan.Identity;

            //batMan = null;

            //batMan = new Superhero("Bat","Man","Black");
            //batMan.Identity = new Citizen("Terry","McGuiness");


            ////MessageBox.Show(sup.FirstName);
            //MessageBox.Show(batMan.Identity.FirstName);

            //Lair batCave = new Lair();
            //batCave.Add(batMan);
            ////batCave.Members = new List<Person>();

            //Lair hallOfDoom = new Lair();
            //hallOfDoom.Add(new Villian("Lex", "Luther"));

            //Lair treeHouse = new Lair();
            //treeHouse.Add(new Citizen("Billy", "Waldron"));
            //treeHouse.Members.Add(new Citizen("Lucy", "Hargraves"));

            Witch matty = new Witch("Matilda", "Something");
            Broom stick = new Broom(matty, "Brown");
            //stick.Owner = matty;

            MessageBox.Show(stick.Owner.FirstName);
            MessageBox.Show(matty.Broom.Owner.FirstName);
            MessageBox.Show(matty.Broom.Owner.Broom.Owner.Broom.Owner.Broom.Owner.FirstName);


            Node a = new Node() { Text = "apple" };
            Node b = new Node() { Text = "banana" };
            a.Next = b;
            b.Next = new Node() { Text = "cucumber" };
            b.Next.Next = new Node() { Text = "dragon fruit" };

            Node newNode = new Node() { Text = "apricot" };
            Node temp = a.Next; // b
            newNode.Next = temp; // b
            a.Next = newNode; // apr

        }
    }
}
