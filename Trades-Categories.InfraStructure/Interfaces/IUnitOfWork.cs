﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trades_Categories.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();

        void Rollback();
    }
}
