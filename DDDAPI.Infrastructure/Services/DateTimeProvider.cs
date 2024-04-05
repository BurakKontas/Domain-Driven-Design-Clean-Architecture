using DDDAPI.Application.Common.Interfaces.Services;

namespace DDDAPI.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}