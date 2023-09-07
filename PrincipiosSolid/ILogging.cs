namespace PrincipiosSolid
{
    public interface ILogging
    {
        void Info(string message) {}
        void Error(string message, Exception e) { }
        void Fatal(string message, Exception e) { }
    }
}
