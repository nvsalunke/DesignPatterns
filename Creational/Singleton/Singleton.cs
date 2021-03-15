using System;

namespace Creational.Singleton
{
    public sealed class SimpleSingleton
    {
        private SimpleSingleton()
        {
            Console.WriteLine("SimpleSingleton created");
        }
        public static readonly SimpleSingleton Instance = new SimpleSingleton();

    }
    public sealed class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            Console.WriteLine("ThreadSafeSingleton created");
        }

        private static ThreadSafeSingleton _instance;
        private static readonly object obj = new object();

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
                return _instance;
            }
        }
    }

    public sealed class LazySingleton
    {
        private LazySingleton()
        {
            Console.WriteLine("LazySingleton created");
        }

        public static readonly LazySingleton Instance = new Lazy<LazySingleton>(new LazySingleton()).Value;
    }

}
