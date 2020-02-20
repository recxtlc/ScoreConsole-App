using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreNamespace
{
   public class Score
    {
        private float[] scores = new float[0];
        private float highest = 0.0f;
        private float lowest=0.0f;
        private float average;
        int count = 0;
        
        public float Highest { get; set; }
        public float Lowest { get; set; }
        public int totalScores { get; set; }

        public float Average { get; set; }

        public Score()
        {
            count = 0;
        }

        private float CalcHighest()
        {

            highest = scores[0];
            foreach (var score in scores)

            {
                if (score > highest)
                {
                    highest = score;

                }

            }
            return highest;
        }

        private float CalcLowest()
        {
            lowest = float.MaxValue;
            foreach (var score in scores)
            {
                lowest = Math.Min(score, lowest);

            }


            return lowest;

        }
        private float CalcAverage()
        {
            var total = 0.0f;

            foreach (var totScore in scores)
            {
                total += totScore;
                
            }
            return total / scores.Length;
        }

        public void store()
        {

            Highest = CalcHighest();
            Lowest = CalcLowest();
            Average = CalcAverage();

           
        }

    
        public void prompt ()
        {
            float givenScore = 0;
            string strScore = "";
         
            do
            {


                Console.Write("enter score: ");
                strScore = Console.ReadLine();
             
                givenScore = convertStrToFloat(ref strScore);

                AddScore(givenScore);

            } while (givenScore != 999);

            this.totalScores = this.scores.Length;

        }

        public void AddScore(float givenScore )
        {
            Array.Resize(ref this.scores, this.scores.Length + 1);


            if (givenScore != 999)
            {
                scores[count] = givenScore;
                count++;
            }
            else
            {
                Array.Resize(ref this.scores, this.scores.Length - 1);


            }
        }

        

        private static float convertStrToFloat(ref string strScore)
        {
            float givenScore;
            while (!float.TryParse(strScore, out givenScore))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.Write("please enter float numbers only\nenter score: ");
                strScore = Console.ReadLine();
            }
            Console.ResetColor();
            givenScore = float.Parse(strScore);
            return givenScore;
        }


     
        public  void Message()
        {
            Console.WriteLine("lowest: " + Lowest);
            Console.WriteLine("highest: " + Highest);

            Console.WriteLine("Average: " + Average);


        }

    
        public void print()
        {
            var i = 0;
            foreach (var score in scores)
            {

                Console.WriteLine("scores in index\t" +   i   +  "\nscores: "  + score);
                i++;
            }
        }

       

    }
}
