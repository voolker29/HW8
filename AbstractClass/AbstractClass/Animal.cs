namespace AbstractClass
{
    abstract internal class Animal
    {
        string Name;
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name; }
        abstract public void Eat();
    }
}
