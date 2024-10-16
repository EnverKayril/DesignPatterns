namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public int ComponentId { get; set; }
        public string ComponentName { get; set; }

        public ProductComponent(int componentId, string componentName)
        {
            ComponentId = componentId;
            ComponentName = componentName;
        }

        public string Display()
        {
            return $"<li class='list-group-item'>{ComponentName}<li>";
        }

        public int TotalCount()
        {
            return 1;
        }
    }
}
