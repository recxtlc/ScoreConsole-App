using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreNamespace
{
   public class Score
    {
        private float[] scores = new float[0];
        private float highest ;
        private float lowest;
        //private float average;
        private int count ;
        
        public float Highest { get; set; }
        public float Lowest { get; set; }
        public int totalScores { get; set; }

        public float Average { get; set; }

        public Score()
        {
            count = 0;
            highest = 0.0f;
            lowest = 0.0f;
          //  average = 0.0f;
           
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
        
        private  float ConvertStrToFloat(string strScore)
        {
            float givenScore;

            while (!float.TryParse(strScore, out givenScore)|| givenScore >100 || givenScore <0)
            {
                    if (givenScore == 999)
                          break;
                if(givenScore > 100 && givenScore !=999)
                {
                    Display();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\t\t\t\t\tNumbers must be between{0-100}\n\t\t\t\t\t\tenter score: ");
                    Console.ResetColor();
                }else
                {
                    Display();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\t\t\t\t\t\tplease enter float numbers only\n\t\t\t\t\t\tenter score: ");
                    Console.ResetColor();

                }

                strScore = Console.ReadLine();
            }
            Console.ResetColor();
            givenScore = float.Parse(strScore);
            return givenScore;
        }


        public void store()
        {
            
            Highest = CalcHighest();
            Lowest = CalcLowest();
            Average = CalcAverage();

           
        }

        public void Display ()
        {
            Console.Clear();
            
            Console.Write("******************************************************************************************************");
            Console.WriteLine("\n\t\t\t\t\t\tSCORE CONSOLE APP\n\t\t\t\t\t\t-{USE 999 TO EXIT}-");
            Console.WriteLine("************************************************************************************************");
          

        }

        public void prompt ()
        {
            float givenScore = 0;
            string strScore = "";
            var addedCount = 1;
            do
            {

                Console.WriteLine("\t\t\t\t\t\t");
                Console.Write("\t\t\t\t\t\tenter score: ");
                strScore = Console.ReadLine();
             
                givenScore = ConvertStrToFloat(strScore);
                if(givenScore == 999)
                {
                    Console.WriteLine("\n\t\t\t\t\t\t    GOOD BYE\n\t\t\t\t\t\tResults Are");
                    Environment.Exit(0);
                }else
                {
                  
                    AddScore(givenScore);
                    
                    Display();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t\t\t\tscore added{"+ addedCount + "}");
                    Console.ResetColor();
                    addedCount++;
                }
              

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

        



        public void Message()
        {
            Console.WriteLine($"\t\t\t\t\t\tLowest:  {Lowest:N2}");
            Console.WriteLine($"\t\t\t\t\t\tHighest:  {Highest:N2}");

            Console.WriteLine($"\t\t\t\t\t\tAverage: {Average:N2}");


        }

    
    
       

    }
}
