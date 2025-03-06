using Vintagestory.API.Common;

namespace MoreAntlerMounts;

public class Core : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        Mod.Logger.Event("started '{0}' mod", Mod.Info.Name);
    }
}
