public class Cardamom : Ingredient
{
    public Cardamom() : base(6, "Cardamom") { }
    public override string Prepare => $"Take half a teaspoon. {base.Prepare}";
}

