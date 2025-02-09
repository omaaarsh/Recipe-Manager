public class Sugar : Ingredient
{
    public Sugar() : base(5, "Sugar") { }
    public override string Prepare=> $"{base.Prepare}.";
}