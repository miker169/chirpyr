
namespace ChirpyR.Data.Model
{
    public class ChirpyRRelation
    {
        public long Id { get; set; }
        public ChirpyRUser Parent { get; set; }
        public ChirpyRUser Child { get; set; }
    }
}
