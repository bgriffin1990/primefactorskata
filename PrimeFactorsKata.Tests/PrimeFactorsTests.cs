﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata.Tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        private PrimeFactorsCalculator generator;

        [SetUp]
        public void SetUp()
        {
            generator = new PrimeFactorsCalculator();
        }

        [Test]
        public void OneShouldReturnAnEmptyList()
        {
            var actual = generator.GeneratePrimes(1);

            Assert.That(actual, Is.EqualTo(new List<Int32>()));
        }

        [Test]
        public void TwoShouldReturnTwo()
        {
            var actual = generator.GeneratePrimes(2);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 2 }));
        }

        [Test]
        public void ThreeShouldReturnThree()
        {
            var actual = generator.GeneratePrimes(3);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 3 }));
        }

        [Test]
        public void FourShouldReturnTwoAndTwo()
        {
            var actual = generator.GeneratePrimes(4);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 2, 2 }));
        }

        [Test]
        public void FiveShouldReturnFive()
        {
            var actual = generator.GeneratePrimes(5);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 5 }));
        }

        [Test]
        public void SixShouldReturnThreeAndTwo()
        {
            var actual = generator.GeneratePrimes(6);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 2, 3 }));
        }

        [Test]
        public void SevenShouldReturnSeven()
        {
            var actual = generator.GeneratePrimes(7);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 7 }));
        }

        [Test]
        public void EightShouldReturnTwoTwoAndTwo()
        {
            var actual = generator.GeneratePrimes(8);

            Assert.That(actual, Is.EqualTo(new List<Int32> { 2, 2, 2 }));
        }
    }
}
