namespace Task_02
{
    public abstract class Item
    {
        protected string Name;
        protected string Code;
        protected string Category;
        protected int Size;

        protected Item(string name, string code, string category, int size)
        {
            this.Name = name;
            this.Code = code;
            this.Category = category;
            this.Size = size;
        }

        public override string ToString()
        {
            return " name: " + Name + "code: " + Code + "category: " + Category + "size: " + Size;
        }

        public abstract void Play();
    }
}
