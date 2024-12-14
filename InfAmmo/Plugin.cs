using Exiled.API.Features;
using System;

namespace InfAmmo
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "史蒂夫";
        public override string Name { get; } = "InfAmmo";
        public override Version Version { get; } = new Version(1, 1, 4, 5);
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.DroppingAmmo+= EventHandlers.OnDroppingAmmo;
            Exiled.Events.Handlers.Player.DroppingItem += EventHandlers.OnDroppingItem;
            Exiled.Events.Handlers.Player.Dying += EventHandlers.OnDying;
            Exiled.Events.Handlers.Player.ReloadingWeapon += EventHandlers.OnReloadingWeapon;
            Log.Info("加载无限子弹插件! By 史蒂夫 [已在GitHub上开源,版权史蒂夫]");
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.DroppingAmmo -= EventHandlers.OnDroppingAmmo;
            Exiled.Events.Handlers.Player.DroppingItem -= EventHandlers.OnDroppingItem;
            Exiled.Events.Handlers.Player.Dying -= EventHandlers.OnDying;
            Exiled.Events.Handlers.Player.ReloadingWeapon -= EventHandlers.OnReloadingWeapon;
            Log.Info("关闭无限子弹插件!");
            base.OnDisabled();
        }
    }
}
