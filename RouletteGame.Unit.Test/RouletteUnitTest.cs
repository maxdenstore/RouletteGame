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
    class RouletteUnitTest
    {
        [Test]
        void bla()
        {
            var uut = new Roulette();
            uut.GetResult();
        }
    }
}
