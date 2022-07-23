using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorManagementModel.Model
{
    public class Notification
    {
        public int Id { get; set; }
        public Visitor Visitor { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
}
