﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint5.Task4.V30.Lib;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint5.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Quyzt\Source\Repos\Tyuiu.IbrayevAA.Sprint5\Tyuiu.IbrayevAA.Sprint5.Task4.V30\bin\Debug\DataSprint5\InPutDataFileTask4V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
