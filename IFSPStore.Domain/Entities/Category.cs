using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    internal class Category : BaseEntity<int>
    {
        public Category(int id, string name):base(id)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
