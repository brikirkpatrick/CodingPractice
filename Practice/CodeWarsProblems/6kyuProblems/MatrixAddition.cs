using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.CodeWarsProblems._6kyuProblems
{
    //https://www.codewars.com/kata/matrix-addition/train/csharp
    [TestClass]
    public class MatrixAddition
    {
        public static int[][] Execute(int[][] a, int[][] b)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    Console.WriteLine(a[i][j]);
                }
            }

            return null;
        }

        [TestCategory("6kyu")]
        [TestMethod]
        public void MatrixAdditionTest()
        {
            int[][] a = new int[][] {new int[] {3, 5},
                                     new int[] {3, 5}};

            int[][] b = new int[][] {new int[] {1, 2},
                                     new int[] {1, 2}};

            int[][] expected = new int[][] {new int[] {3, 5},
                                            new int[] {3, 5}};

            MatrixAddition.Execute(a, b);
            //Assert.AreEqual(expected, MatrixAddition.Execute(a, b));
        }
    }
}
