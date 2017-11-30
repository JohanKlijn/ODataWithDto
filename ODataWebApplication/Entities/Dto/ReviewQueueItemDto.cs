using System;
using ODataWebApplication.Entities.Dal;


namespace ODataWebApplication.Entities.Dto
{
    /// <summary>
    /// DTO for <see cref="ReviewQueueItem"/> entity.
    /// </summary>
    public class ReviewQueueItemDto
    {
        /// <summary>
        /// Id of related ReviewQueue.
        /// </summary>
        public long ReviewQueueId { get; set; }

        /// <summary>
        /// Id of related Interaction.
        /// </summary>
        public long InteractionId { get; set; }

        /// <summary>
        /// Id of assigned user.
        /// </summary>
        public Guid Assignee { get; set; }

        /// <summary>
        /// Date when ReviewQueueItem was selected.
        /// </summary>
        public DateTime SelectionDate { get; set; }

        /// <summary>
        /// Navigation property to related interaction.
        /// </summary>
        public InteractionDto Interaction { get; set; }
    }
}