using System.Collections.Generic;
using System;

namespace Tamagochi
{
    public class Tamagochi
    {
        //tamagochi values
        private int hunger;
        private int boredom;

        private List<string> words = new List<string>();

        private bool isAlive;

        private Random generator = new Random();

        public string name;


        //methods
        public void Feed()
        {
            hunger--;
        }

        public void Hi()
        {
            Console.WriteLine(words[generator.Next(words.Count)]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {

        }

        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {

        }

        /*public bool GetAlive()
        {

        }*/

        private void ReduceBoredom()
        {

        }


    }
}