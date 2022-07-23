

namespace VisitorManagementModel.Model
{
    public class Log
    {
        public int Id { get; set; }
        public Visitor Visitor { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
