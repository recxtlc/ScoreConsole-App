using System;
using Xunit;
using ScoreNamespace;

namespace ScoreNamespace.Test
{
    public class ScoreTest1
    {
        [Fact]
        public void Test4High()
        {

            // AAA 

            // Arrange 

            var score = new Score();
            score.AddScore(55);
            score.AddScore(12);
            score.AddScore(100);
            // Act 
            score.store();
            var highest = score.Highest;
                
           

            // Assert
            Assert.Equal(100f, highest);
        

            
        }


        [Fact]
        public void Test4Low()
        {

            // AAA 

            // Arrange 

            var score = new Score();
            score.AddScore(55);
            score.AddScore(12);
            score.AddScore(100);
            // Act 
            score.store();
            var highest = score.Highest;
            var lowest = score.Lowest;
            var average = score.Average;


            // Assert
           
            Assert.Equal(12f, lowest);
            


        }

        [Fact]
        public void Test4Average()
        {

            // AAA 

            // Arrange 

            var score = new Score();
            score.AddScore(55);
            score.AddScore(12);
            score.AddScore(100);
            // Act 
            score.store();
            var average = score.Average;


            // Assert
            
            Assert.Equal(55.78, average, 1);


        }
        [Fact]
        public void Test4All()
        {

            // AAA 

            // Arrange 

            var score = new Score();
            score.AddScore(55);
            score.AddScore(12);
            score.AddScore(100);
            // Act 
            score.store();
            var highest = score.Highest;
            var lowest = score.Lowest;
            var average = score.Average;


            // Assert
            Assert.Equal(100f, highest);
            Assert.Equal(12f, lowest);
            Assert.Equal(55.7, average, 1);


        }


    }
}
