using Data;
using Data.Infrastructure;
using Services.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DonService : Service<Don>
    {
        private static DatabaseFactory df = new DatabaseFactory();
        private static UnitOfWork utwk = new UnitOfWork(df);
        public DonService() :base(utwk)
        {

       
        }
    }
}
