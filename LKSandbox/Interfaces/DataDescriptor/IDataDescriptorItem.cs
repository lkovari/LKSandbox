namespace LKSandbox.Interfaces.DataDescriptor
{
    internal interface IDataDescriptorItem<T> : IComparable<T>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public T Type { get; set; }
    }
}
