namespace DesignPattern.Composite.CompositePattern
{
    public interface IComponent
    {
        public int ComponentId { get; set; }
        public string ComponentName { get; set; }
        int TotalCount();
        string Display();
    }
}
