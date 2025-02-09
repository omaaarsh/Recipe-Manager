// Abstract Ingredient Class
public abstract class Ingredient
{
    public int Id { get; }
    public string Name { get; }

    protected Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public virtual string Prepare=>"Add to other ingredients.";
    public override string ToString()
    {
        return $"{Id}. {Name}";
    }
}