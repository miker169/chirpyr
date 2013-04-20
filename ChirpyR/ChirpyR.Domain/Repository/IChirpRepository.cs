using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChirpyR.Domain.Repository
{
    using ChirpyR.Domain.Model;

    interface IChirpRepository
    {
        IList<Chirp> GetLatestChirps();

        IList<Chirp> GetLatestChirpsFor(string user);

        IList<ChirpyRUser> GetFollowers(ChirpyRUser rUser);

        IList<ChirpyRUser> GetFollowing(ChirpyRUser rUser);

        IList<ChirpTag> GetChirpTags(int topCount);

        long AddChirp(Chirp chirp);

        long RegisterUser(ChirpyRUser newUser);

        long UnRegisterUser(ChirpyRUser updatedUser);

        long FollowChirpR(ChirpyRUser currentUser, ChirpyRUser followUser);

        long UnfollowChirpR(ChirpyRUser currentUser, ChirpyRUser unfollowUser);

        ChirpyRUser GetUserById(string userId);
        /// <summary>
        /// Testing API only. Service method should not be
        /// implemented
        /// </summary>
        /// <param name="deletedUser"></param>
        /// <returns></returns>
        long DeleteUserAccount(ChirpyRUser deletedUser);

    }
}
