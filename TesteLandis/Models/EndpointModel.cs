using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLandis.Models
{
    public class EndpointModel
    {
        public enum State
        {
            Disconnected = 0,
            Connected = 1,
            Armed = 2
        };

        public string SerialNumber { get; set; }
        public State SwitchState { get; set; }

    }
}
