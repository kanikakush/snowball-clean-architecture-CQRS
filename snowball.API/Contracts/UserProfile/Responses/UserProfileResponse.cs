using snowball.Domain.Aggregates.PostAggregate;

namespace snowball.API.Contracts.UserProfile.Responses
{
    public record UserProfileResponse //DTO
    {
        public Guid UserProfileID { get; set; }
        public BasicInformation BasicInfo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
