using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Services
{
    public class ClienteImpl : ICliente
    {
        private ModelCon db;
        private ILogger _ilogger;

        public AppLotesService(ILogger<ReplicacionService> ilogger,
                                      pergaminoContext dbContext)
        { }
    }
}