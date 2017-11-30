using AutoMapper;
using ODataWebApplication.Entities.Dal;

namespace ODataWebApplication.Entities.Dto
{
    /// <summary>
    /// Domain entity to dto mapping Profile
    /// </summary>
    public class DomainEntityToDtoMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainEntityToDtoMappingProfile"/> class.
        /// </summary>
        public DomainEntityToDtoMappingProfile()
        {

            CreateMap<ReviewQueue, ReviewQueueDto>();
            CreateMap<ReviewQueueItem, ReviewQueueItemDto>();
            //CreateMap<Interaction, InteractionDto>();
            CreateMap<Interaction, InteractionDto>()
                .ForMember(idto => idto.Id, conf => conf.MapFrom(i => i.InteractionId));
                //.ForMember(dest => dest.Participants, opt =>
                //{
                //    opt.MapFrom(x => x.Participants);
                //});
            CreateMap<Participant, ParticipantDto>();

        }

        /// <summary>
        /// Mappers the configuration.
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration GetConfiguration()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {                
                cfg.AddProfile<DomainEntityToDtoMappingProfile>();                
            });

            return mapperConfiguration;
        }
    }
}