using AutoMapper;


namespace Legacy.API.APIServer.Utilities.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MapProfile>();
            });
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
