using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IbrayevAA.Sprint5.Task2.V10.Lib;

namespace Tyuiu.IbrayevAA.Sprint5.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Quyzt\Source\Repos\Tyuiu.IbrayevAA.Sprint5\Tyuiu.IbrayevAA.Sprint5.Task2.V10\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
