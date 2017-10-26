using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Model
{
  public  class Event
    {
        //The model by which each event is created
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
