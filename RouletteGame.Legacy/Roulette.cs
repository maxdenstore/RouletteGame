﻿using System;
using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public class Roulette
    {
        private readonly IRandomizer _random;
        private readonly IFieldFactory _fieldFactory;
        private readonly List<Field> _fields;
        private Field _result;

        public Roulette(IRandomizer randompar, IFieldFactory FieldFactorypar)
        {
            _random = randompar;
            _fieldFactory = FieldFactorypar;

            _fields = _fieldFactory.getFields();
            _result = _fields[0];
        }

        public void Spin()
        {
            var n = _random.next();
            _result = _fields[(int) n];
        }

        public Field GetResult()
        {
            return _result;
        }
    }

    public interface IRandomizer // make for game and test
    {
        uint next();
    }

    public class Randomzier : IRandomizer
    {
        public uint next()
        {
            return (uint)new Random().Next(0, 37);
        }
    }

    public class FakeRandomizerReturn0 : IRandomizer
    {
        public uint next()
        {
            return 0;
        }
    }

    public interface IFieldFactory //make factories for games and tests
    {
        List<Field> getFields();
    }

    public class FakeFieldFactoryGRB : IFieldFactory
    {
        public List<Field> getFields()
        {
            var _fields = new List<Field>
            {
                new Field(0, Field.Green),
                new Field(1, Field.Red),
                new Field(2, Field.Black)
            };
            return _fields;
        }
    }

    public class FieldFactory : IFieldFactory //the standard amount of fields
    {
        public List<Field> getFields()
        {
            var _fields = new List<Field>
            {
                new Field(0, Field.Green),
                new Field(1, Field.Red),
                new Field(2, Field.Black),
                new Field(3, Field.Red),
                new Field(4, Field.Black),
                new Field(5, Field.Red),
                new Field(6, Field.Black),
                new Field(7, Field.Red),
                new Field(8, Field.Black),
                new Field(9, Field.Red),
                new Field(10, Field.Black),
                new Field(11, Field.Black),
                new Field(12, Field.Red),
                new Field(13, Field.Black),
                new Field(14, Field.Red),
                new Field(15, Field.Black),
                new Field(16, Field.Red),
                new Field(17, Field.Black),
                new Field(18, Field.Red),
                new Field(19, Field.Red),
                new Field(20, Field.Black),
                new Field(21, Field.Red),
                new Field(22, Field.Black),
                new Field(23, Field.Red),
                new Field(24, Field.Black),
                new Field(25, Field.Red),
                new Field(26, Field.Black),
                new Field(27, Field.Red),
                new Field(28, Field.Black),
                new Field(29, Field.Black),
                new Field(30, Field.Red),
                new Field(31, Field.Black),
                new Field(32, Field.Red),
                new Field(33, Field.Black),
                new Field(34, Field.Red),
                new Field(35, Field.Black),
                new Field(36, Field.Red)
            };

            return _fields;
        }
    }
}