using System.ComponentModel.DataAnnotations;

namespace ODataWebApplication.Entities.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class ParticipantDto
    {
        /// <summary>
        /// The id of the interaction to which the participant belongs
        /// </summary>
        [Required]
        public long InteractionID { get; set; }

        /// <summary>
        /// The particiapant value.
        /// </summary>
        [Required]
        public string Value { get; set; }
        /// <summary>
        /// The type of the participant. (TO, FROM, CC, BCC)
        /// </summary>
        [Required]
        public byte TypeID { get; set; }
        
    }
}