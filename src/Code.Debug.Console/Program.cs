using System.Collections.Generic;

namespace Code.Debug.Console
{
    public class Program
    {
        private static readonly string Joe = "hello";
        private readonly List<int> _list = new List<int>
        {
            1,
            2,
            3,
        };
        protected Complex _complex = new Complex();

        public static void Main(string[] args)
        {
            new Program().Public(42);
        }

        public string Hello { get; } = "hello";

        public void Public(int topLevel)
        {
            var joe = Joe;
            Internal(joe);
        }

        internal void Internal(string nextLevel)
        {
            Protected(nextLevel);
        }

        protected void Protected(string nextNextLevel)
        {
            Private(23);
        }

        private void Private(int bottomLevel)
        {
            var complex = new Complex();
        }

        protected class Complex
        {
            public string Hello { get; } = "hello";

            public Complex LessComplex { get; }
        }
    }
}
