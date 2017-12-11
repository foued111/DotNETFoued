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
    class ContractService : Service<contract>, IContractService
    {
        static DatabaseFactory Dbf = new DatabaseFactory();
        static UnitOfWork utw = new UnitOfWork(Dbf);
        public ContractService() : base(utw)
        {
        }

        public void createContract(contract c, int id_user)
        {
            c.confirmation = "pending";
            c.id_user = id_user;
           // utw.GetRepository<contract>().Add(c);
            utw.Commit();
        }

        public void acceptContract(int id_contract)
        {
          //  contract c = utw.GetRepository<contract>().GetById(id_contract);
          //  c.confirmation = "confirmed";
          //  utw.GetRepository<contract>().Update(c);
        }



    }
}
