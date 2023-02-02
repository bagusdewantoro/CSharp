using System;

namespace CardPickerFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cards to pick: ");
            string inputNumber = Console.ReadLine(); // user input

            // // ===== CARA PERTAMA: (sukses kalo input type: int, tapi kalo input non int, gagal) =====
            // int valueFromUser = int.Parse(inputNumber); // parse input from string to int
            // foreach (string card in CardPicker.PickSomeCards(valueFromUser))
            //   {
            //     Console.WriteLine(card);
            //   }
            // // ==========

            // ===== CARA KEDUA: (ada handling jika input type: non int) =====
            if (int.TryParse(inputNumber, out int valueFromUser))  // parse string input to int, but, check first the type of input
            {
                foreach (string card in CardPicker.PickSomeCards(valueFromUser))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            // ==========
        }
    }
}
