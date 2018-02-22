using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGame.Legacy;

namespace RouletteGame.Unit.Test
{
    [TestFixture]
    public class RouletteUnitTest
    {
        [Test]
        public void FieldColor()
        {
            var uut = new Roulette(new FakeRandomizerReturn0(), new FakeFieldFactoryGRB());
            Field expected = new Field(0,2);
            Assert.That(uut.GetResult().Color, Is.EqualTo(expected.Color));
        }
        [Test]
        public void FieldEven()
        {
            var uut = new Roulette(new FakeRandomizerReturn0(), new FakeFieldFactoryGRB());
            Field expected = new Field(0, 2);
            Assert.That(uut.GetResult().Even, Is.EqualTo(expected.Even));
        }
        [Test]
        public void FieldNumer()
        {
            var uut = new Roulette(new FakeRandomizerReturn0(), new FakeFieldFactoryGRB());
            Field expected = new Field(0, 2);
            Assert.That(uut.GetResult().Number, Is.EqualTo(expected.Number));
        }
    }
}
