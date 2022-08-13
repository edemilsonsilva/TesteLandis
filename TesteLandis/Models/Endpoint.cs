using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLandis.Models
{
    public class Endpoint:IEndpoint
    {
        private EndpointRespository endpointRepository = new EndpointRespository();
        public void Insert(EndpointModel endpoint)
        {
            if (endpointRepository.Find(endpoint) != null)
                throw new InvalidOperationException("Endpoint alread exists");
            if (!Enum.IsDefined(typeof(EndpointModel.State),endpoint.SwitchState))
                throw new ArgumentException($"Invalid Switch State: {endpoint.SwitchState}");
            endpointRepository.Insert(endpoint);
        }

        public EndpointModel Find(EndpointModel endpoint)
        {
            if (endpointRepository.Find(endpoint) == null)
                throw new InvalidOperationException("Endpoint cannot be found");

            return endpointRepository.Find(endpoint);
        }

        public void Delete(EndpointModel endpoint)
        {
            EndpointModel ep = endpointRepository.Find(endpoint);
            if (ep == null)
                throw new InvalidOperationException("Endpoint cannot be found");

            endpointRepository.Delete(ep);
        }

        public void Edit(EndpointModel endpoint)
        {
            EndpointModel endpointFind = Find(endpoint);

            if (endpointRepository.Find(endpoint) == null)
                throw new InvalidOperationException("Endpoint cannot be found");

            Delete(endpointFind);
            Insert(endpoint);

        }

        public List<EndpointModel> ListAll()
        { return endpointRepository.ListAll(); }

    }
}
