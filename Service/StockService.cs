using Data;
using Data.Infrastructure;
using Domain;
using Newtonsoft.Json;

using Services.Pattern;
using System.Threading.Tasks;

namespace Service
{
 public   class stockService : Service<stock>
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
    private static UnitOfWork utw = new UnitOfWork(Dbf);
    public stockService() : base(utw)
        {
    }
      
       





    }
}
