using AutoMapper;

namespace LegacyConsole.Utilities.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Mapper.Initialize(cfg =>
            {

            });
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
