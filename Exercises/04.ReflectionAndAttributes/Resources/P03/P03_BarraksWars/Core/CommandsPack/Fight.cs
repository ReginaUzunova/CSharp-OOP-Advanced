﻿namespace _03BarracksFactory.Core.CommandsPack
{
    using _03BarracksFactory.Contracts;
    using System;

    public class Fight : Command
    {
        public Fight(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
