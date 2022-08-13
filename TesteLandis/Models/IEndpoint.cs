using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLandis.Models
{
    internal interface IEndpoint
    {
        void Insert(EndpointModel endpoint);

        EndpointModel Find(EndpointModel endpoint);

        void Delete(EndpointModel endpoint);

        void Edit(EndpointModel endpoint);

        List<EndpointModel> ListAll();

    }
}
