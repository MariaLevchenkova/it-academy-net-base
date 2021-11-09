namespace Task2
{
    public class ItemData
    {
        private string name;
        private string code;
        private string category;
        private int size;

        public ItemData(string name, string code, string category, int size)
        {
            this.name = name;
            this.code = code;
            this.category = category;
            this.size = size;
        }

        public override string ToString()
        {
            return " name: " + name + "code: " + code + "category: " + category + "size: " + size; 
        }
    }
}
