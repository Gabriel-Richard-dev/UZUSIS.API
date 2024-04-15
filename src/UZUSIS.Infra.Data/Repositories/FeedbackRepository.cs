using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class FeedbackRepository : EntityRepository<Feedback>, IFeedbackRepository
{
    public FeedbackRepository(UZUSISContext context) : base(context)
    {
    }
    
    
    
    
}