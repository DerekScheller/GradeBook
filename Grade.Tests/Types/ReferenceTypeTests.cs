using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "derek";
            name = name.ToUpper();
            Assert.AreEqual("DEREK", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2016, 9, 26);
            date = date.AddDays(1);

            Assert.AreEqual(27, date.Day);
        }
        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int x)
        {
            x += 1;
        }

        [TestMethod]
        public void RefTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Derek";
            string name2 = "derek";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVarHoldsValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void GradebookReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Derek's GradeBook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
