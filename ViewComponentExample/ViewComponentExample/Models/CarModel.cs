using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentExample.Models
{
    public class CarModel
    {
        private Guid _id = Guid.Empty;
        public Guid ID
        {
            get
            {
                if (_id == Guid.Empty)
                {
                    _id = new Guid();
                }
                return _id;
            }
        }
        [DisplayName("Overskrift")]
        public String Header { get; set; }
        [DisplayName("Mærke")]
        public String Brand { get; set; }
        [DisplayName("Model")]
        public String Model { get; set; }
        [DisplayName("Antal KM")]
        public int NrOfKM { get; set; }
        [DisplayName("Årgang")]
        public int Year { get; set; }
        [DisplayName("Pris")]
        public double Price { get; set; }
    }
}
