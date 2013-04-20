namespace ChirpyR.Domain.Model
{
    using System.Collections.Generic;

    public class ChirpyRUser
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Gravatar { get; set; }
        /// <summary>
        /// Password is not loaded form
        /// the database. It is for 
        /// new account registration ONLY
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Used in the view model only
        /// </summary>
        public string OldPassword { get; set; }
        public List<ChirpyRUser> FollowerIds { get; set; }
        public List<ChirpyRUser> FollowingIds { get; set; } 
    }
}