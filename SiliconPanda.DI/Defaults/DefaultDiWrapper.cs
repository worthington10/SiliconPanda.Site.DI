using SiliconPanda.DI.Wrappers;

namespace SiliconPanda.DI.Defaults
{
    internal class DefaultDiWrapper : DiWrapper
    {
        internal static IWindsorContainer Container { get; private set; }

    }
}
