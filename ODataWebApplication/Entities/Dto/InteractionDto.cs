using System;
using System.Collections.Generic;
using ODataWebApplication.Entities.Dal;

namespace ODataWebApplication.Entities.Dto
{
    /// <summary>
    /// DTO for <see cref="Interaction"/> entity.
    /// </summary>
    public class InteractionDto
    {

        public InteractionDto()
        {
            Participants = new List<ParticipantDto>();
        }

        /// <summary>
        /// Id of interaction.
        /// </summary>
        public long Id { get; set; }

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
        /// Date on which interaction was ingested to Index
        /// </summary>
        public DateTime IngestDate { get; set; }

        /// <summary>
        /// Type of interaction.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Risk score
        /// </summary>
        public Int16 RiskScore { get; set; }

        /// <summary>
        /// Navigation property to Participants related to current interaction.
        /// </summary>
        public IEnumerable<ParticipantDto> Participants { get; set; }

   
    }
}