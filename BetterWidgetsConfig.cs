using Terraria.ModLoader.Config;

namespace BetterWidgets
{
    [Label("Better Widgets Config")]
    public class BetterWidgetsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        internal BetterWidgetsConfig Instance;
    }
}
