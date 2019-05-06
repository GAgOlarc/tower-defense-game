namespace TreeHouseDefense
{
    class TreeHouseDefenseException : System.Exception
    {
        public TreeHouseDefenseException()
        {

        }
        public TreeHouseDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TreeHouseDefenseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
