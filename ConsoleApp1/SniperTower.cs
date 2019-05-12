using TreehouseDefense;

namespace TreeHouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 2;
        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
