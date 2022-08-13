using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TesteLandis.Models
{
    public class EndpointRespository: IEndpoint
    {
        private List<EndpointModel> listaEndpoints = new List<EndpointModel>();


        public void Insert(EndpointModel endpoint)
        {
            listaEndpoints.Add(endpoint);
        }

        public EndpointModel Find(EndpointModel endpoint)
        {
            return listaEndpoints.FirstOrDefault(x => x.SerialNumber == endpoint.SerialNumber);
        }

        public void Delete(EndpointModel endpoint)
        {
            listaEndpoints.Remove(endpoint);
        }

        public void Edit(EndpointModel endpoint)
        {
            EndpointModel endpointFind = Find(endpoint);
            Delete(endpointFind);
            Insert(endpoint);
            
        }

        public List<EndpointModel> ListAll()
            { return listaEndpoints; }

    }
}
