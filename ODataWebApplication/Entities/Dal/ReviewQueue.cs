using System;
using System.Collections.Generic;
using Supervision.Domain.Entities;

namespace ODataWebApplication.Entities.Dal
{
    /// <summary>
    /// Represents review queue.
    /// </summary>
    public class ReviewQueue : IEntity
    {
        /// <summary>
        /// Review id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Creation date of review queue in UTC.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date of last modification of review queue in UTC.
        /// </summary>
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Title of review queue.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of review queue.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Stores query related to current review queue.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Id of creator of current review queue. 
        /// </summary>
        public Guid Creator { get; set; }

        /// <summary>
        /// Foreign key for related ReviewQueueType.
        /// </summary>
        public byte TypeId { get; set; }


        /// <summary>
        /// Navigation property to related review queue items.
        /// </summary>
        public virtual ICollection<ReviewQueueItem> ReviewQueueItems { get; set; }

    }
}
