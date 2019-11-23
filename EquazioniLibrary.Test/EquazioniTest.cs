using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void IsDeterminedTest()
        {
            double a = 3;
            double b = 4;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotDeterminedTest()
        {
            double a = 0;
            double b = 4;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsInconsistedTest()
        {
            double a = 0;
            double b = 3;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotInconsistedTest()
        {
            double a = 3;
            double b = 1;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsDegree2Test()
        {
            double a = 2;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotDegree2Test()
        {
            double a = 0;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void DeltaTest()
        {
            double a = 4;
            double b = 3;
            double c = 2;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(-23, delta);
        }
        [TestMethod]
        public void DeltaTest1()
        {
            double a = 0;
            double b = 3;
            double c = 2;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(double.NaN, delta);
        }
        [TestMethod]
        public void DeltaTest2()
        {
            double a = 4;
            double b = 0;
            double c = 2;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(-32, delta);
        }
        [TestMethod]
        public void DeltaTest3()
        {
            double a = 4;
            double b = 3;
            double c = 0;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(9, delta);
        }
        [TestMethod]
        public void EquationDegree1()
        {
            double a = 3;
            double b = 3;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("-1", risposta);
        }
        [TestMethod]
        public void EquationDegree1_1()
        {
            double a = 0;
            double b = 3;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("Impossibile", risposta);
        }
        [TestMethod]
        public void EquationDegree1_2()
        {
            double a = 2;
            double b = 0;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("0", risposta);
        }
        [TestMethod]
        public void EquationDegree1_3()
        {
            double a = 0;
            double b = 0;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("Indeterminata", risposta);
        }
    }
}
