public class CoconutFlour : Ingredient
{
    public CoconutFlour() : base(2, "Coconut Flour") { }
    public override string Prepare=> $"Sieve. {base.Prepare}";
}