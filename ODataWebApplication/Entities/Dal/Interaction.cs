using System;
using System.Collections.Generic;
using Supervision.Domain.Entities;

namespace ODataWebApplication.Entities.Dal
{
    /// <summary>
    /// Type represents interaction in Supervision database.
    /// </summary>
    public class Interaction : IEntity
    {
  
        /// <summary>
        /// Id of interaction.
        /// </summary>
        public long InteractionId { get; set; }

        /// <summary>
        /// Interaction identifier in Smart Index, i.e .id field.
        /// </summary>
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// Title of interaction, i.e interaction_title in Smart Index.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Start date of interaction.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Type of interaction.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Date on which interaction was ingested to Index
        /// </summary>
        public DateTime IngestDate { get; set; }

        /// <summary>
        /// RiskScore of interaction
        /// </summary>
        public Int16 RiskScore { get; set; }

        ///// <summary>
        ///// Navigation property to ReviewQueueItems related to current interaction.
        ///// </summary>
        //public virtual ICollection<ReviewQueueItem> ReviewQueueItems { get; set; }

        /// <summary>
        /// Navigation property to Participants related to current interaction.
        /// </summary>
        public virtual ICollection<Participant> Participants { get; set; }


    }
}
