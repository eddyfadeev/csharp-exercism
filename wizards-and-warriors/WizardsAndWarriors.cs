using System;
abstract class Character
{
    private string CharacterType { get; }
    protected virtual bool IsVulnerable { get; set; } = false;
    protected Character(string characterType)
    {
        CharacterType = characterType;
    }
    public abstract int DamagePoints(Character target);
    public virtual bool Vulnerable() => IsVulnerable;
    public override string ToString() => $"Character is a {CharacterType}";
}
class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
        
    }
    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}
class Wizard : Character
{
    protected override bool IsVulnerable { get; set; }
    private bool IsSpellPrepared { get; set; }
    public Wizard() : base("Wizard")
    {
        IsVulnerable = true;
        IsSpellPrepared = false;
    }
    public override int DamagePoints(Character target) => IsSpellPrepared ? 12 : 3;
    public void PrepareSpell()
    {
        IsVulnerable = false;
        IsSpellPrepared = true;
    }
}