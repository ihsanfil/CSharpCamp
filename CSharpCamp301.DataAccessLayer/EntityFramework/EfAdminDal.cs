﻿using CSharpCamp301.DataAccessLayer.Abstract;
using CSharpCamp301.DataAccessLayer.Repositories;
using CSharpCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCamp301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>,IAdminDal
    {
    }
}
