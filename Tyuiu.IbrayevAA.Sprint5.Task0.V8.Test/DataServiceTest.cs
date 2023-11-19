﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint5.Task0.V8.Lib;

using System.IO;

namespace Tyuiu.IbrayevAA.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Quyzt\Source\Repos\Tyuiu.IbrayevAA.Sprint5\Tyuiu.IbrayevAA.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
