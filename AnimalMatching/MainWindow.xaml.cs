using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace AnimalMatching
{
    
    public partial class MainWindow : Window
    {
        //Create a Timer:
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound; // check how many matches the player has found

        public MainWindow()
        {
            InitializeComponent();
            //Timer
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s"); 
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text = $"{timeTextBlock.Text} - Play again?";
            }
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
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;     
                    int index = random.Next(animalEmoji.Count); // pick random int between 0-15
                    string nextEmoji = animalEmoji[index]; // get string emoji from the List[index]
                    textBlock.Text = nextEmoji; // update textBlock Text with nextEmoji
                    animalEmoji.RemoveAt(index); // remove the List[index]
                }
                //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToString()); // System.Linq.Enumerable+<OfTypeIterator>d_95`1[System.Windows.Controls.TextBlock]
                //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToList().ToString()); //System.Collections.Generic.List`1[System.Windows.Controls.TextBlock]
                //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToList().Count.ToString()); // 16
                //MessageBox.Show(mainGrid.Children.OfType<TextBlock>().ToList()[3].ToString()); // System.Windows.Controls.TextBlock

                timer.Start();
                tenthsOfSecondsElapsed = 0;
                matchesFound = 0;
            }
        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false; // check whether this is first click or second click. 
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            //1. Player click first emoji, so it will be invisible, keep track of its textBlock, & switch findingMatch to true
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            //2. If player found a match at the 2nd click (same text), switch findingMatch to false
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            //3. 2nd click but not the same emoji as the 1st click
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }


        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8) // reset the game if 8 matches
            {
                SetUpGame();
            }
        }
    }
}
