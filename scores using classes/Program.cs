using System;
using ScoreNamespace;

namespace scores_using_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Score scoresObj = new Score();
            
            scoresObj.Display();
            scoresObj.prompt();
            scoresObj.store();
            scoresObj.Message();



        }
    }
}
