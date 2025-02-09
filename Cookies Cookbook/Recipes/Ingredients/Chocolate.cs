public class Chocolate : Ingredient
{
    public Chocolate() : base(4, "Chocolate") { }
    public override string Prepare=> $"Melt in a water bath. {base.Prepare}";
}
