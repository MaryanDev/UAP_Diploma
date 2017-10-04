using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Entities.PFSC_DBContext;

namespace PFSC.Services.Abstract.Base
{
    public abstract class BaseService
    {
        protected PfscDbContext _context;

        protected BaseService(PfscDbContext context)
        {
            _context = context;
        }
    }
}
