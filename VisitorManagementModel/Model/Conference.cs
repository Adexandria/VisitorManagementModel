namespace VisitorManagementModel.Model
{
    public class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; } = false;

    }
}