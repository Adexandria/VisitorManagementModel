

namespace VisitorManagementModel.Model
{
    public class Log
    {
        public int Id { get; set; }
        public Visitor Visitor { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
    }
}
