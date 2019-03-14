using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CodeWarsProblems._8kyuProblems
{
    //https://www.codewars.com/kata/total-amount-of-points
    [TestClass]
    public class TotalAmountOfPoints
    {
        public static int TotalPoints(string[] games)
        {
            int totalPoints = 0;

            foreach (var result in games)
            {
                var score1 = Convert.ToInt32(result[0]);
                var score2 = Convert.ToInt32(result[2]);

               
                if (score1 > score2)        //totalPoints = score1 > score2 ? 3 : 0;
                {
                    totalPoints += 3;
                }
                else if (score1 < score2)
                {
                    totalPoints += 0;       // We could remove this logic.
                }
                else if (score1 == score2)
                {
                    totalPoints += 1;
                }
            }

            return totalPoints;
        }


        //Code Wars Solutions From Others
        public static int TotalPoints2(string[] games)
        {
            return games.Select(x => CalculatePoints(x)).Sum();
        }

        public static int CalculatePoints(string game)
        {
            var scores = game.Split(":");
            if (int.Parse(scores[0]) > int.Parse(scores[1])) return 3;
            if (int.Parse(scores[0]) < int.Parse(scores[1])) return 0;
            return 1;
        }

        /* Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:
           if x>y - 3 points
           if x<y - 0 point
           if x=y - 1 point 
           */
        [TestMethod]
        public void TotalAmountOfPointsTests()
        {
            Assert.AreEqual(TotalPoints(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }), 10);
            Assert.AreEqual(TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }), 30);
            Assert.AreEqual(TotalPoints(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }), 0);
        }
    }
}
