using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Types.Test
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(9);
            diary.AddRating(8);
            diary.AddRating(7);
            diary.AddRating(5.3f);
            diary.AddRating(10);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(10, stats.maxGrade);
        }

        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Icek";

            SetName(diary);

            Assert.AreEqual("Zbylu", diary.Name);

        }

        private void SetName(Diary diary)
        {
            diary.Name = "Zbylu";
        }

        [TestMethod]
        public void PassByValueInt()
        {
            int x1 = 5;

            IncreamentNumber(x1);

            Assert.AreEqual(15, x1);

        }

        private void IncreamentNumber(int number)
        {
            number = 15;
        }

        [TestMethod]
        public void PassByValueRefInt()
        {
            int x1 = 5;

            IncreamentNumber(ref x1);

            Assert.AreEqual(15, x1);
        }

        private void IncreamentNumber(ref int number)
        {
            number = 15;
        }
    }
}
