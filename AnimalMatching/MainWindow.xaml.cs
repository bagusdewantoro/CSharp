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

namespace AnimalMatching
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            // throw new NotImplementedException();
            List<string> animalEmoji = new List<string>()
            {
                "😊", "😊",
                "🤣", "😂",
                "😫", "🤣",
                "😎", "😫",
                "😂", "😎",
                "😍", "😍",
                "😛", "😛",
                "😴", "😴",
            };
            // MessageBox.Show(animalEmoji[1]); // "😊"

            Random random = new Random();
            //MessageBox.Show(random.ToString()); // System.Random
            //MessageBox.Show(random.Next(5).ToString()); // 'random number between 0-4'
            //MessageBox.Show(random.Next(animalEmoji.Count).ToString()); // 'random number between 0-15'

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) // find every TextBlock in the mainGrid
            {
                int index = random.Next(animalEmoji.Count); // pick random int between 0-15
                string nextEmoji = animalEmoji[index]; // get string emoji from the List[index]
                textBlock.Text = nextEmoji; // update textBlock Text with nextEmoji
                animalEmoji.RemoveAt(index); // remove the List[index]
            }
            //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToString()); // System.Linq.Enumerable+<OfTypeIterator>d_95`1[System.Windows.Controls.TextBlock]
            //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToList().ToString()); //System.Collections.Generic.List`1[System.Windows.Controls.TextBlock]
            //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToList().Count.ToString()); // 16
            //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToList()[3].ToString()); // System.Windows.Controls.TextBlock
        }
    }
}
