using System;

namespace Javelin.Repositories
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance = new Singleton();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return Instance;
        }

        public long GetTemp()
        {
            return 75;
        }
    }
}