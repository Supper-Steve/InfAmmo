using Exiled.Events.EventArgs.Player;

namespace InfAmmo
{
    public class EventHandlers
    {
        public static void OnReloadingWeapon(ReloadingWeaponEventArgs ev) 
        {
            if (ev.Firearm == null || ev.Firearm.Type == ItemType.ParticleDisruptor)
                return;
            ev.Player.ClearAmmo();
            ev.Player.SetAmmo(ev.Firearm.AmmoType, (ushort)(ev.Firearm.MaxAmmo + 2));
            if (ev.Firearm.Type == ItemType.GunCom45)
                ev.Player.SetAmmo(ev.Firearm.AmmoType, (ushort)(ev.Firearm.MaxAmmo + 2));
        }
        public static void OnDroppingAmmo(DroppingAmmoEventArgs ev)
        {
            if (ev.Player == null)
                return;
            ev.IsAllowed = false;
        }
        public static void OnDroppingItem(DroppingItemEventArgs ev)
        {
            if (ev.Player == null || ev.Item == null)
                return;
            if (ev.Item.IsAmmo)
            {
                ev.IsAllowed = false;
                ev.Item.Destroy();
            }
        }
        public static void OnDying(DyingEventArgs ev)
        {
            if (ev.Player == null)
                return;
            ev.Player.ClearAmmo();
        }
    }
}
