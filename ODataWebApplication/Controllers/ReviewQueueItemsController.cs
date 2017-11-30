using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ODataWebApplication.Entities.Dal;
using ODataWebApplication.Entities.Dto;
using ODataWebApplication.Repsositories;


namespace ODataWebApplication.Controllers
{
    public class ReviewQueueItemsController : ODataController
    {
        readonly IReviewQueueItemsRepository _repositoryInMemoryList = new InMemoryListReviewQueueItemsRepository();
        readonly IReviewQueueItemsRepository _repositoryInMemoryDb = new InMemoryDbReviewQueueItemsRepository();
        
        public ReviewQueueItemsController()
        {

        }

        //[ODataRoute("ReviewQueues({id})/ReviewQueueItems")]
        //[EnableQuery(PageSize = 50)]
        //[HttpGet]
        //public IHttpActionResult Get([FromODataUri] long id)
        //{
        //    IQueryable<ReviewQueueItem> reviewQueueItems = _repositoryInMemoryList.Get().Where(rqi => rqi.ReviewQueueId == id);
        //    return Ok(reviewQueueItems);            
        //}

        //[ODataRoute("ReviewQueues({id})/ReviewQueueItems")]
        //[EnableQuery(PageSize = 50)]
        //[HttpGet]
        //public IHttpActionResult Get([FromODataUri] long id)
        //{
        //    IQueryable<ReviewQueueItem> reviewQueueItems = _repositoryInMemoryList.Get().Where(rqi => rqi.ReviewQueueId == id);

        //    IMapper mapper = DomainEntityToDtoMappingProfile.GetConfiguration().CreateMapper();

        //    IQueryable<ReviewQueueItemDto> reviewQueueItemDtos = reviewQueueItems.ProjectTo<ReviewQueueItemDto>(mapper.ConfigurationProvider);
        //    List<ReviewQueueItemDto> queueItemDtos = reviewQueueItemDtos.ToList();
        //    Console.WriteLine(queueItemDtos.Count);

        //    return Ok(reviewQueueItemDtos);
        //}


        [ODataRoute("ReviewQueues({id})/ReviewQueueItems")]
        [EnableQuery(PageSize = 50)]
        [HttpGet]
        public IHttpActionResult Get([FromODataUri] long id)
        {
            IQueryable<ReviewQueueItem> reviewQueueItems = _repositoryInMemoryDb.Get().Where(rqi => rqi.ReviewQueueId == id);

            IMapper mapper = DomainEntityToDtoMappingProfile.GetConfiguration().CreateMapper();

            IQueryable<ReviewQueueItemDto> reviewQueueItemDtos = reviewQueueItems.ProjectTo<ReviewQueueItemDto>(mapper.ConfigurationProvider);
            
            return Ok(reviewQueueItemDtos);
        }


        [ODataRoute("Interactions")]
        [EnableQuery(PageSize = 50)]
        [HttpGet]
        public IHttpActionResult GetInteractions()
        {
            IQueryable<Interaction> interactions = _repositoryInMemoryDb.GetInteractions();

            IMapper mapper = DomainEntityToDtoMappingProfile.GetConfiguration().CreateMapper();

            IQueryable<InteractionDto> interactionsDto = interactions.ProjectTo<InteractionDto>(mapper.ConfigurationProvider);
            List<InteractionDto> list = interactionsDto.ToList();
            Console.WriteLine(list.Count);

            return Ok(interactionsDto);
        }
    }
}