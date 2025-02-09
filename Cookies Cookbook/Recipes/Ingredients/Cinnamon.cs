public class Cinnamon : Ingredient
{
    public Cinnamon() : base(7, "Cinnamon") { }
    public override string Prepare => $"Take half a teaspoon. {base.Prepare}";
}
