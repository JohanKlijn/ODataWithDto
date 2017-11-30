using System.Data;
using System.Linq;
using ODataWebApplication.Entities.Dal;

namespace ODataWebApplication.Repsositories
{
    public interface IReviewQueueItemsRepository
    {
        IQueryable<ReviewQueueItem> Get();

        IQueryable<Interaction> GetInteractions();


        IQueryable<Participant> GetParticipant();
    }
}