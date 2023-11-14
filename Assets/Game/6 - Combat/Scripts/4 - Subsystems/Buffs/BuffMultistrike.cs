public class BuffMultistrike : Buff
{
    public BuffMultistrike(Character src, int duration) : base(src, duration)
    {
        Name = "Multistrike";
        Description = "Will take an additional turn after their next turn";
        AgingPhase = CombatPhase.CHARACTERTURN_CLEANUP;
        // PortraitArt = Resources.Load<Sprite>("Sprites/Icons/stunned");
    }
}
