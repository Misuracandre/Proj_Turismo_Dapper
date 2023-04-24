﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public interface IPackagesRepository
    {
        bool Insert(Package package);
        List<Package> GetAll();
    }
}
