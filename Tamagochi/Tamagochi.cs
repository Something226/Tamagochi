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
        public void Name()
        {

        }

        public void Feed()
        {
            hunger -= 3;
        }

        public void Hi()
        {
            Console.WriteLine(words[generator.Next(words.Count)]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
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
            Console.WriteLine(hunger);
            Console.WriteLine(boredom);

            if (isAlive == false)
            {
                Console.WriteLine(name + " is ded :(");
            }
            else if (isAlive == true)
            {
                Console.WriteLine(name + " is alive! :D");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom -= 3;
        }
    }
}