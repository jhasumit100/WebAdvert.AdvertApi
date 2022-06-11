using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertApi.Models
{
    public class ConfirmedAdvertModel
    {
        public string Id { get; set; }
        public AdvertStatus Status { get; set; }
    }
}
