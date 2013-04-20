namespace ChirpyR.Data.Model
{
    using System.Collections.Generic;

    public class ChirpyRUser : IDataEntity<ChirpyRUser, Domain.Model.ChirpyRUser>
    {

        public ChirpyRUser()
        {
            this.Followers = new List<ChirpyRrelation>();
            this.Following = new List<ChirpyRrelation>();
        }

        public long Id { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<ChirpyRrelation> Followers { get; set; }
        public List<ChirpyRrelation> Following { get; set; }

        public Domain.Model.ChirpyRUser ToDomainEntity()
        {
            return new Domain.Model.ChirpyRUser
                       {
                           UserId = this.UserId,
                           Id = this.Id,
                           FullName = this.FullName,
                           Email = this.Email
                       };
        }

        public ChirpyRUser LoadFromDomainEntity(Domain.Model.ChirpyRUser input)
        {
            Id = input.Id;
            UserId = input.UserId;
            FullName = input.FullName;
            Email = input.Email;
            return this;
        }
    }
}
