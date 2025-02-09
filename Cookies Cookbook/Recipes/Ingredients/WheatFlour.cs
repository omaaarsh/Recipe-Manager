public class WheatFlour : Ingredient
{
    public WheatFlour() : base(1, "Wheat Flour") { }
    public override string Prepare => $"Sieve.{base.Prepare}";
}