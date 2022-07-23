namespace VisitorManagementModel.Model
{
    public class Visitor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }   
        public string Company { get; set; }
        public string Address { get; set; }
        public ICollection<Log>? Logs { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        
    }
}