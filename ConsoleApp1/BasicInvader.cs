using System;
using System.Collections.Generic;
using System.Text;

namespace TreeHouseDefense
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 1;
        public BasicInvader(Path path) : base(path)
        { }
    }
}
