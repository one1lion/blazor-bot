namespace BlazorBot.Shared.Enums;

public enum SourcePlatform
{
    Twitch,
    Discord,
    YouTube
}

[AttributeUsage(AttributeTargets.Class)]
public class SourcePlatformAttribute : Attribute
{
    public SourcePlatform SourcePlatform { get; }

    public SourcePlatformAttribute(SourcePlatform sourcePlatform)
    {
        SourcePlatform = sourcePlatform;
    }
}