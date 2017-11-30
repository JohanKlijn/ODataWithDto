using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using Microsoft.OData.Edm;
using ODataWebApplication.Entities.Dal;
using ODataWebApplication.Entities.Dto;

namespace ODataWebApplication
{
    public static class WebApiConfig
    {
        private static bool useDto = true;

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services            
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            
            

            if (useDto)
            {
                config.MapODataServiceRoute("ODataRoute", "odata", GetEdmModelDto());
                GetEdmModelDto();
            }
            else
            {
                config.MapODataServiceRoute("ODataRoute", "odata", GetEdmModel());                
            }

            config.EnsureInitialized();
        }


        private static IEdmModel GetEdmModelDto()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder
            {
                Namespace = "Supervision",
                ContainerName = "SupervisionContainer"
            };

            //Linked to Database
            builder.EntitySet<ReviewQueueDto>("ReviewQueues").
                EntityType.Name = "ReviewQueue";

            builder.EntitySet<InteractionDto>("Interactions").
                EntityType.Name = "Interaction";


            EntitySetConfiguration<ParticipantDto> participantEsc = builder.EntitySet<ParticipantDto>("Participants");
            participantEsc.EntityType.Name = "Participant";
            participantEsc.EntityType.HasKey(p => p.InteractionID);
            participantEsc.EntityType.HasKey(p => p.Value);

            builder.EntitySet<ReviewQueueItemDto>("ReviewQueueItems").
                EntityType.
                HasKey(rqidto => rqidto.ReviewQueueId).
                HasKey(rqidto => rqidto.InteractionId).
                Name = "ReviewQueueItem";            

            return builder.GetEdmModel();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder
            {
                Namespace = "Supervision",
                ContainerName = "SupervisionContainer"
            };            

            builder.EntitySet<ReviewQueue>("ReviewQueues").
                EntityType.Name = "ReviewQueue";

            builder.EntitySet<Interaction>("Interactions").
                EntityType.Name = "Interaction";


            EntitySetConfiguration<Participant> participantEsc = builder.EntitySet<Participant>("Participants");
            participantEsc.EntityType.Name = "Participant";
            participantEsc.EntityType.HasKey(p => p.InteractionID);
            participantEsc.EntityType.HasKey(p => p.Value);

            builder.EntitySet<ReviewQueueItem>("ReviewQueueItems").
                EntityType.
                HasKey(rqidto => rqidto.ReviewQueueId).
                HasKey(rqidto => rqidto.InteractionId).
                Name = "ReviewQueueItem";

            return builder.GetEdmModel();
        }
    }
}