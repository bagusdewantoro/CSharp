using System;
using System.Collections.Generic;
using System.Text;

namespace CardPickerFile
{
    class CardPicker
    {
        static Random random = new Random(); // generate random numbers

        // Method 1: PickSomeCards()
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i=0; i<numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        // Method 2: RandomSuit()
        private static string RandomSuit()
        {
            //throw new NotImplementedException();
            int value = random.Next(1, 5); // get a random number from 1 to 4
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds"; // 4 is not 1 or 2 or 3
        }

        // Method 3: RandomValue()
        private static string RandomValue()
        {
            //throw new NotImplementedException();
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
