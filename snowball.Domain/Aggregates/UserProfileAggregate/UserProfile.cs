using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Domain.Aggregates.PostAggregate
{
    public class UserProfile
    {
        private UserProfile()
        {
            
        }
        public Guid UserProfileID { get; private set; }
        public string IdentityID { get; private set; } = string.Empty;
        public BasicInfo BasicInfo { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }

        //factory method
        public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
        {
            return new UserProfile
            {
                UserProfileID = Guid.NewGuid(),
                IdentityID = identityId,
                BasicInfo = basicInfo,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }
        //public methods
        public void UpdateBasicInfo(BasicInfo basicInfo)
        {
            BasicInfo = basicInfo;
            LastModified = DateTime.UtcNow;
        }
    }
}
