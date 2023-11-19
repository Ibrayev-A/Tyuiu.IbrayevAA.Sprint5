using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IbrayevAA.Sprint5.Task3.V9.Lib;

namespace Tyuiu.IbrayevAA.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Quyzt\Source\Repos\Tyuiu.IbrayevAA.Sprint5\Tyuiu.IbrayevAA.Sprint5.Task3.V9\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
