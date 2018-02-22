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
    class FieldUnitTest
    {
        [Test]
        public void FieldColor()
        {
            var uut = new Roulette(new FakeRandomizerReturn0(), new FakeFieldFactoryGRB());
            Assert.That(uut.GetResult().Color, Is.EqualTo(2));
        }
        [Test]
        public void FieldEven()
        {
            var uut = new Roulette(new FakeRandomizerReturn0(), new FakeFieldFactoryGRB());
            Assert.That(uut.GetResult().Even, Is.EqualTo(true));
        }
        [Test]
        public void FieldNumer()
        {
            var uut = new Roulette(new FakeRandomizerReturn0(), new FakeFieldFactoryGRB());
            Assert.That(uut.GetResult().Number, Is.EqualTo(0));
        }

        [Test]
        public void ToStringGreen()
        {
            var uut = new Field(0, 2);
            Assert.That(uut.ToString(), Is.EqualTo("[0, green]"));
        }
    }
}
