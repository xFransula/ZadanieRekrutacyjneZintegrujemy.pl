namespace Domain.Model
{
    public class Product : Entity
    {
        public string SKU { get; protected set; }
        public string Name { get; protected set; }
        public string EAN { get; protected set; }
        public string Supplier_name { get; protected set; }
        public string Category { get; protected set; }
        public bool Is_wire { get; protected set; }
        public bool Available { get; protected set; }
        public bool Is_vendor { get; protected set; }
        public string Default_image { get; protected set; }

        protected Product() { }

        public Product(
            int id,
            string sku,
            string name,
            string ean, 
            string supplier_name, 
            string category, 
            bool is_wire, 
            bool available, 
            bool is_vendor, 
            string default_image)
        {
            Id = id;
            SKU = sku;
            Name = name;
            EAN = ean;
            Supplier_name = supplier_name;
            Category = category;
            Is_wire = is_wire;
            Available = available;
            Is_vendor = is_vendor;
            Default_image = default_image;

        }
    }
}
