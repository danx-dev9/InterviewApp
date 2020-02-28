using NUnit.Framework;
using InterviewApp.Services;
using System.Collections.Generic;
using System.Linq;


namespace InterviewApp.Tests
{
    [TestFixture]
    public class Tests
    {
        private IDivisibleNumberService _service;

        [SetUp]
        public void Setup()
        {
            _service = new DivisibleNumberService();
        }

        [Test]
        public void CanAddMultiplePairings()
        {
            _service.AddPair(3, "fizz");
            _service.AddPair(5, "buzz");
            _service.AddPair(10, "decade");

            var result = _service.Pairings().Count;
            Assert.AreEqual(result, 3);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void IsDivisbleBy3(int number)
        {
            _service.AddPair(3, "fizz");
            var result = _service.IsDvisible(number);
            Assert.AreEqual(result, "fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void IsDivisbleBy5(int number)
        {
            _service.AddPair(5, "buzz");
            var result = _service.IsDvisible(number);
            Assert.AreEqual(result, "buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void IsDivisbleBy3And5(int number)
        {
            _service.AddPair(3, "fizz");
            _service.AddPair(5, "buzz");
            var result = _service.IsDvisible(number);
            Assert.AreEqual(result, "fizzbuzz");
        }

        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        public void IsDivisibleByOtherNumberWordPairs(int number)
        {
            _service.AddPair(4, "blazor");
            var result = _service.IsDvisible(number);
            Assert.AreEqual(result, "blazor");
        }

        [TestCase(12)]
        [TestCase(42)]
        [TestCase(120)]
        public void ReturnsCorrectMaxResults(int number)
        {
            var results = _service.GetAllValues(number);
            Assert.AreEqual(results.Count(), number);
        }
        
    }
}