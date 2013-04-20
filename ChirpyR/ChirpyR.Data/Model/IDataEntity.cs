namespace ChirpyR.Data.Model
{
    public interface IDataEntity<S, T>
    {
        T ToDomainEntity();

        S LoadFromDomainEntity(T input);
    }
}
