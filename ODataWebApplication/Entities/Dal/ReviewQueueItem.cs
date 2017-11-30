using System;
using Supervision.Domain.Entities;

namespace ODataWebApplication.Entities.Dal
{
    /// <summary>
    /// Represents work item related to review queue.
    /// </summary>
    public class ReviewQueueItem : IEntity
    {
        /// <summary>
        /// Id of assigned user.
        /// </summary>
        public  Guid Assignee { get; set; }

        /// <summary>
        /// Date when ReviewQueueItem was selected.
        /// </summary>
        public DateTime SelectionDate { get; set; }

        /// <summary>
        /// Foreign key for related ReviewQueue.
        /// </summary>
        public long ReviewQueueId { get; set; }
        
        /// <summary>
        /// Foreign key for related Interaction.
        /// </summary>
        public long InteractionId { get; set; }

        /// <summary>
        /// Navigation property to related interaction.
        /// </summary>
        public virtual Interaction Interaction { get; set; }

        ///// <summary>
        ///// Navigation property to related review queue.
        ///// </summary>
        //public virtual ReviewQueue ReviewQueue { get; set; }
    }
}
