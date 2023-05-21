using LKSandbox.Interfaces.DataDescriptor;

namespace LKSandbox.Models.DataDescriptor
{
    internal class DataDescriptorItem<T> : IDataDescriptorItem<T>
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareTo(T? other)
        {
            throw new NotImplementedException();
        }
    }
}
