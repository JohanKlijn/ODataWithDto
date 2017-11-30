using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataWebApplication.Entities.Dto
{
    /// <summary>
    /// DTO for ReviewQueue entity.
    /// </summary>
    public class ReviewQueueDto
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
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }

        /// <summary>
        /// Description of review queue.
        /// </summary>
        [StringLength(1024, MinimumLength = 0)]
        public string Description { get; set; }

        /// <summary>
        /// Id of creator of current review queue.
        /// </summary>
        public Guid Creator { get; set; }

        /// <summary>
        /// Id of ReviewQueueType.
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte TypeId { get; set; }

        /// <summary>
        /// Query to match for review queue
        /// </summary>
        [Required]
        [StringLength(Int32.MaxValue, MinimumLength = 1)]
        public string Query { get; set; }
        
        /// <summary>
        /// Collection of review queue items DTO.
        /// </summary>        
        public virtual ICollection<ReviewQueueItemDto> ReviewQueueItems { get; set; }
    }
}