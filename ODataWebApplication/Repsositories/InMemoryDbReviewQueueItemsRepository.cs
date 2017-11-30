using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ODataWebApplication.Entities.Dal;
using System.Data.SQLite;

namespace ODataWebApplication.Repsositories
{
    public class InMemoryDbReviewQueueItemsRepository: IReviewQueueItemsRepository
    {
        private readonly DbSet<ReviewQueueItem> _reviewQueueItemsSet;
        private readonly DbSet<Interaction> _ineractionsdbSet;
        private readonly DbSet<Participant> _participantSet;
        private readonly MyDbContext _myDbContext;
        private readonly DbSet<ReviewQueue> _reviewQueues;

        public InMemoryDbReviewQueueItemsRepository()
        {
            
            
            _myDbContext = new MyDbContext();
            _reviewQueueItemsSet = _myDbContext.ReviewQueueItems;
            _ineractionsdbSet = _myDbContext.Interactions;
            _reviewQueues = _myDbContext.ReviewQueues;
            _participantSet = _myDbContext.Participants;

            InitializeRepo();

        }


        private void InitializeRepo()
        {
            if (_reviewQueues.Any())
            {
                return;
            }

            _reviewQueues.Add(
                new ReviewQueue()
                {
                    Id = 1,
                    Title = "Queue 1",
                    CreateDate = DateTime.Now,
                    Description = "",
                    LastModifiedDate = DateTime.Now,
                    Query = "",
                    TypeId = 1
                }
                );

            _reviewQueues.Add(
                new ReviewQueue()
                {
                    Id = 2,
                    Title = "Queue 2",
                    CreateDate = DateTime.Now,
                    Description = "",
                    LastModifiedDate = DateTime.Now,
                    Query = "",
                    TypeId = 1
                }
            );


            List<ReviewQueueItem> items = new List<ReviewQueueItem>()
            {
                new ReviewQueueItem()
                {
                    ReviewQueueId = 1,
                    Assignee = Guid.NewGuid(),
                    Interaction = new Interaction()
                    {
                        InteractionId = 1,
                        RiskScore = 7,
                        IngestDate = DateTime.Now,
                        SourceIdentifier = "abc-1",
                        StartDate = DateTime.Now,
                        Title = "abc-1",
                        Type = "abc-1",
                        Participants = new List<Participant>()
                        {
                            new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant1"}
                        }
                    }
                },
                new ReviewQueueItem()
                {
                    ReviewQueueId = 1,
                    Assignee = Guid.NewGuid(),
                    Interaction = new Interaction()
                    {
                        InteractionId = 11,
                        RiskScore = 7,
                        IngestDate = DateTime.Now,
                        SourceIdentifier = "abc-11",
                        StartDate = DateTime.Now,
                        Title = "abc-11",
                        Type = "abc-11",
                        Participants = new List<Participant>()
                        {
                            new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant2"}
                        }
                    }
                },
                new ReviewQueueItem()
                {
                    ReviewQueueId = 1,
                    Assignee = Guid.NewGuid(),
                    Interaction = new Interaction()
                    {
                        InteractionId = 12,
                        RiskScore = 7,
                        IngestDate = DateTime.Now,
                        SourceIdentifier = "abc-11",
                        StartDate = DateTime.Now,
                        Title = "abc-11",
                        Type = "abc-11",
                        Participants = new List<Participant>()
                        {
                            new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant1"},
                            new Participant() {InteractionID = 1, TypeID = 1, Value = "Participant2"}
                        }
                    }
                },
                new ReviewQueueItem()
                {
                    ReviewQueueId = 2,
                    Assignee = Guid.NewGuid(),
                    Interaction = new Interaction()
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
                            new Participant() {InteractionID = 21, TypeID = 1, Value = "Participant1"}
                        }
                    }
                }
            };

            
            foreach (ReviewQueueItem reviewQueueItem in items)
            {
                _reviewQueueItemsSet.Add(reviewQueueItem);
            }

            _myDbContext.SaveChanges();
        }

        public IQueryable<ReviewQueueItem> Get()
        {
            return _reviewQueueItemsSet;
        }

        public IQueryable<Interaction> GetInteractions()
        {
            return _ineractionsdbSet;
        }

        public IQueryable<Participant> GetParticipant()
        {
            return _participantSet;
        }
    }
}