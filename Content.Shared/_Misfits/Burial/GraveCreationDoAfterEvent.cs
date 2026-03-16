using Content.Shared.DoAfter;
using Robust.Shared.Map;
using Robust.Shared.Serialization;

namespace Content.Shared._Misfits.Burial;

/// <summary>
/// Fired when the grave-digging doAfter completes for a <see cref="Components.GraveCreatorComponent"/>.
/// Carries the world coordinates at which the new grave should be spawned.
/// </summary>
[Serializable, NetSerializable]
public sealed partial class GraveCreationDoAfterEvent : SimpleDoAfterEvent
{
    [DataField]
    public EntityCoordinates SpawnCoordinates;

    public GraveCreationDoAfterEvent() { }

    public GraveCreationDoAfterEvent(EntityCoordinates coords)
    {
        SpawnCoordinates = coords;
    }
}
