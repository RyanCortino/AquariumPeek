using AquariumPeek.Application.Common.Interfaces;

namespace AquariumPeek.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
