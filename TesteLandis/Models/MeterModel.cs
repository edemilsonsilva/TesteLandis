using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLandis.Models
{
    public class MeterModel : EndpointModel
    {
        private Model id;

        public enum Model
        {
            NSX1P2W = 16,
            NSX1P3W = 17,
            NSX2P3W = 18,
            NSX3P4W = 19,
        };

        public Model Id { get => id; set => id = value; }
        public int Number { get; set; }
        public string FirmwareVersion { get; set; }

    }
}
