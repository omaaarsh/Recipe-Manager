public class CocoaPowder : Ingredient
{
    public CocoaPowder() : base(8, "Cocoa Powder") { }
    public override string Prepare => $"{base.Prepare}";
}
