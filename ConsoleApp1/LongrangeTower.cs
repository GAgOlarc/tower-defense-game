using TreehouseDefense;

namespace TreeHouseDefense
{
    class LongrangeTower : Tower
    {
        protected override int Range { get; } = 2;
        public LongrangeTower(MapLocation location) : base(location)
        { }
    }
}
