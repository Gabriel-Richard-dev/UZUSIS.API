using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class FeedbackService : BaseService<Feedback>, IFeedbackService
{
    public FeedbackService(INotification notification, IMapper mapper, IFeedbackRepository feedbackRepository) : base(notification, mapper)
    {
        _feedbackRepository = feedbackRepository;
    }

    private readonly IFeedbackRepository _feedbackRepository;


}