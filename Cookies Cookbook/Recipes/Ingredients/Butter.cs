public class Butter : Ingredient
{
    public Butter() : base(3, "Butter") { }
    public override string Prepare => $"Melt on low heat. {base.Prepare}";
}