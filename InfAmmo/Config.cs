using Exiled.API.Interfaces;
using System.ComponentModel;

namespace InfAmmo
{
    public class Config : IConfig
    {
        [Description("启动无限子弹插件")]
        public bool IsEnabled { get; set; } = true;
        [Description("启动无限子弹插件-Debug")]
        public bool Debug { get; set; } = false;
    }
}
