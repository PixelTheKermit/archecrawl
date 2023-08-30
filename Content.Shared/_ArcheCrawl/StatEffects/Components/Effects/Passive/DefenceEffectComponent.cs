using Content.Shared.Damage;

namespace Content.Shared._ArcheCrawl.StatEffects.Components.Effects.Passive
{
    [RegisterComponent]
    public sealed partial class DefenceEffectComponent : Component
    {
        [DataField("modifiers", required: true)]
        public DamageModifierSet Modifiers = default!;
    }
}
