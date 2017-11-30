using System.Data.Entity.ModelConfiguration;

namespace ODataWebApplication.Entities.Dal.Configuration
{
    class ParticipantsConfiguration : EntityTypeConfiguration<Participant>
    {
        public ParticipantsConfiguration()
        {
            //Composed key            
            this.HasKey(rqi => new { rqi.InteractionID, rqi.Value });

            this.
               ToTable("Participant");
            //this.
            //    HasRequired(p => p.Interaction).
            //    WithMany(i => i.Participants).
            //    HasForeignKey(p => p.InteractionID);
            this.
                Property(i => i.Value).
                HasColumnType("nvarchar").
                HasMaxLength(450).
                IsRequired();
            this.
                Property(i => i.TypeID).
                HasColumnType("TINYINT").
                IsRequired();
        }
    }
}
