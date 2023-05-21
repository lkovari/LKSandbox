using LKSandbox.Interfaces;

namespace LKSandbox.Models
{
    public class Created : ICreated
    {
        public DateOnly Create { get; set; }

        public Created(DateOnly create)
        {
            Create = create;
        }
    }
}
