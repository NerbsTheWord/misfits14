// #Misfits Add: Examine flavor text for Critical/SoftCritical mob states.
// Lets bystanders know someone is down and needs medical attention.
using Content.Shared.Examine;
using Content.Shared.IdentityManagement;
using Content.Shared.Mobs.Components;
using Content.Shared.Mobs.Systems;
using MobState = Content.Shared.Mobs.MobState; // #Misfits Fix: alias to avoid namespace collision with this file's own namespace

namespace Content.Shared._Misfits.MobState;

/// <summary>
///     Pushes human-readable flavor text onto the examine panel when a mob is
///     in Critical or SoftCritical state, so nearby players know to intervene.
/// </summary>
public sealed class CritExamineSystem : EntitySystem
{
    [Dependency] private readonly MobStateSystem _mobState = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<MobStateComponent, ExaminedEvent>(OnExamined);
    }

    private void OnExamined(Entity<MobStateComponent> ent, ref ExaminedEvent args)
    {
        if (!args.IsInDetailsRange)
            return;

        var state = ent.Comp.CurrentState;

        if (state == MobState.Critical)
        {
            args.PushMarkup(Loc.GetString("misfits-crit-examine-critical",
                ("target", Identity.Entity(ent, EntityManager))));
        }
        else if (state == MobState.SoftCritical)
        {
            args.PushMarkup(Loc.GetString("misfits-crit-examine-softcritical",
                ("target", Identity.Entity(ent, EntityManager))));
        }
    }
}
