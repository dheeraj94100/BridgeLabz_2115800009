using System;

class LegacyAPI
{
    // Marking the old method as obsolete
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature. It should not be used.");
    }

    // New recommended method
    public void NewFeature()
    {
        Console.WriteLine("This is the new and improved feature.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LegacyAPI api = new LegacyAPI();

        // Calling the old method (will show a warning)
        api.OldFeature();

        // Calling the new method
        api.NewFeature();
    }
}
