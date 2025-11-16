using System;
using Exiled.API.Features;

namespace SCP_207_X
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "SCP-207-X";
        public override string Prefix => Name;
        public override string Author => "Morkamo";
        public override Version RequiredExiledVersion => new Version(9, 1, 0);
        public override Version Version => new Version(0, 0, 1);

        public static Plugin Instance;

        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            base.OnDisabled();
        }
    }
}