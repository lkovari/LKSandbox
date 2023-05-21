namespace LKSandbox.Interfaces.DataDescriptor
{
    internal interface IDataDescriptor
    {
        public IEnumerable<IDataDescriptorItem<dynamic>> DataDescriptors { get; set; }
    }
}
