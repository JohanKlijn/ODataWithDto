using Supervision.Domain.Entities;

namespace ODataWebApplication.Entities.Dal
{
    /// <summary>
    /// 
    /// </summary>
    public class Participant : IEntity
    {
        
        /// <summary>
        /// Interaction id.
        /// </summary>
        public long InteractionID { get; set; }
        /// <summary>
        /// Value of participant.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Type of participant.
        /// </summary>
        public byte TypeID { get; set; }

        ///// <summary>
        ///// Navigation property to related interaction.
        ///// </summary>
        //public virtual Interaction Interaction { get; set; }

    }
}
