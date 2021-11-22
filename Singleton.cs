using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class DatabaseSingleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        DatabaseSingleton()
        {
        }

        public static DatabaseSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}
