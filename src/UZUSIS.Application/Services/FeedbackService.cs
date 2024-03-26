using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class FeedbackService : BaseService<Feedback>, IFeedbackService
{
    public FeedbackService(INotification notification, IMapper mapper) : base(notification, mapper)
    {
    }
    
    
    
}