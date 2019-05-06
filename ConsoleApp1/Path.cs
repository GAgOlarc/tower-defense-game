using System;
using System.Collections.Generic;
using System.Text;
using TreehouseDefense;

namespace TreeHouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLoactionAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
