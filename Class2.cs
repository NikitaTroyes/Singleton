﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Class2
    {
        public DatabaseSingleton Database = DatabaseSingleton.Instance;
    }
}
