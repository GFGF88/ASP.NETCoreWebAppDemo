namespace DI_Service_LifeTime.Services
{
    public class SingletonGuidService : ISingletonGuidService
    {
        public readonly Guid Id;

        public SingletonGuidService() 
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
