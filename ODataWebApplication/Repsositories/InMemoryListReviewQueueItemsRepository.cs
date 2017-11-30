using System;
using System.Collections.Generic;
using System.Linq;
using ODataWebApplication.Entities.Dal;

namespace ODataWebApplication.Repsositories
{
    class InMemoryListReviewQueueItemsRepository : IReviewQueueItemsRepository
    {
        private List<ReviewQueueItem> _items = new List<ReviewQueueItem>();
        public InMemoryListReviewQueueItemsRepository()
        {
           //InitializeRepo();
        }

        //private void InitializeRepo()
        //{
        //    _items = new List<ReviewQueueItem>()
        //    {
        //        new ReviewQueueItem()
        //        {
        //            ReviewQueueId = 1,
        //            Assignee = Guid.NewGuid(),
        //            Interaction = new Interaction()
        //            {
        //                InteractionId = 1,
        //                RiskScore = 7,
        //                IngestDate = DateTime.Now,
        //                SourceIdentifier = "abc-1",
        //                StartDate = DateTime.Now,
        //                Title = "abc-1",
        //                Type = "abc-1",
        //                //Participants = new List<Participant>()
        //                //{
        //                //    new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant1"}
        //                //}
        //            }
        //        },
        //        new ReviewQueueItem()
        //        {
        //            ReviewQueueId = 1,
        //            Assignee = Guid.NewGuid(),
        //            Interaction = new Interaction()
        //            {
        //                InteractionId = 11,
        //                RiskScore = 7,
        //                IngestDate = DateTime.Now,
        //                SourceIdentifier = "abc-11",
        //                StartDate = DateTime.Now,
        //                Title = "abc-11",
        //                Type = "abc-11",
        //                //Participants = new List<Participant>()
        //                //{
        //                //    new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant2"}
        //                //}
        //            }
        //        },
        //        new ReviewQueueItem()
        //        {
        //            ReviewQueueId = 1,
        //            Assignee = Guid.NewGuid(),
        //            Interaction = new Interaction()
        //            {
        //                InteractionId = 11,
        //                RiskScore = 7,
        //                IngestDate = DateTime.Now,
        //                SourceIdentifier = "abc-11",
        //                StartDate = DateTime.Now,
        //                Title = "abc-11",
        //                Type = "abc-11",
        //                //Participants = new List<Participant>()
        //                //{
        //                //    new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant1"},
        //                //    new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant2"}
        //                //}
        //            }
        //        },
        //        new ReviewQueueItem()
        //        {
        //            ReviewQueueId = 2,
        //            Assignee = Guid.NewGuid(),
        //            Interaction = new Interaction()
        //            {
        //                InteractionId = 21,
        //                RiskScore = 1,
        //                IngestDate = DateTime.Now,
        //                SourceIdentifier = "xyz",
        //                StartDate = DateTime.Now,
        //                Title = "xyz",
        //                Type = "xyz",
        //                //Participants = new List<Participant>()
        //                //{
        //                //    new Participant() {InteractionID = 21, TypeID = 1, Value = "Participant1"}
        //                //}
        //            }
        //        }
        //    };
        //}
        
   
        public IQueryable<ReviewQueueItem> Get()
        {            
            return _items.AsQueryable();
        }

        public IQueryable<Interaction> GetInteractions()
        {
            return new List<Interaction>()
            {
                new Interaction()
                {
                    InteractionId = 21,
                    RiskScore = 1,
                    IngestDate = DateTime.Now,
                    SourceIdentifier = "xyz",
                    StartDate = DateTime.Now,
                    Title = "xyz",
                    Type = "xyz",
                    Participants = new List<Participant>()
                    {
                        new Participant() {InteractionID = 21, TypeID = 1, Value = "Participant1OnInteraction21"}
                    }
                }
            }.AsQueryable();
        }

        public IQueryable<Participant> GetParticipant()
        {
            throw new NotImplementedException();
        }
    }
}