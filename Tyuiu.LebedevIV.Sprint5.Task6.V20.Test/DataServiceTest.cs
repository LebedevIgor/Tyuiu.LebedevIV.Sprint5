using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint5.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint5.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint5\Tyuiu.LebedevIV.Sprint5.Task6.V20\bin\Debug\InPutDataFileTask6V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
