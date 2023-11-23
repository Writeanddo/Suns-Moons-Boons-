using System.Collections.Generic;

public class AbilityPyroPeakaboo : BaseAbilityResolver
{
    public AbilityPyroPeakaboo()
    {
        Name = "Pyro Peakaboo";
        Description = "Resurrect self with half health";
        TargetScope = EligibleTargetScopeType.NONE;
        IsUltimate = false;
        // PortraitArt = Resources.Load<Sprite>("Sprites/Abilities/Blessing");
    }

    public override ExecutedAbility GetUncommitted(Character source, Character target, List<Character> AllCombatants)
    {
        var _e = new ExecutedAbility(source, source, this);

        _e.AddToRevivalList(new ReviveOrder(source, 50, this));

        return _e;
    }
}