namespace VisitorManagementModel.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public Visitor? Visitor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public Conference Conference { get; set; }
        public Employee Employee { get; set; }
    }
}