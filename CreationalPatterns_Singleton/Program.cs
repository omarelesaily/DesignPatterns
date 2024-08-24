using CreationalPatterns_Singleton;

class Program
{
    static void Main(string[] args)
    {
        // Accessing the Singleton logger instance
        SingletonLogger logger = SingletonLogger.Instance;

        // Logging messages
        logger.Log("Application started.");
        logger.Log("An error occurred.");

        // In another part of the application
        SingletonLogger anotherLogger = SingletonLogger.Instance;
        anotherLogger.Log("User logged in.");

        // Both logger and anotherLogger are the same instance
        Console.WriteLine(object.ReferenceEquals(logger, anotherLogger)); // Output: True
    }
}