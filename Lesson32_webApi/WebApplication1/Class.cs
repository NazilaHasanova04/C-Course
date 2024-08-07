namespace WebApplication1
{
    public interface ISingleton
    {
        public Guid id { get; }
    }
    public interface IScoped
    {
        public Guid id { get; }
    }
    public interface ITransient
    {
        public Guid id { get; }
    }
    public class Class : ISingleton, ITransient, IScoped
    {
        public Guid id { get; set; }
        public Class()
        {
            id = Guid.NewGuid();
        }
    }
}
