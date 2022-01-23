namespace Xackathon.Abstractions
{
    public enum OrganizationType
    {
        Executive,
        Supervising
    }
    public enum MailingType
    {
        Phone,
        Mail
    }
    public enum SendStatus
    {
        Success,
        Failure
    }
    public enum ContentType
    {
        Image,
        Video
    }
    public enum StoryType
    {
        Information,
        Warning,
        Danger,
        Advetring
    }
    public enum Source
    {
        Landing,
        Vk,
        Operator,
        Excel,
        Telegram,
        Android,
        Ios,
        Other
    }

    public enum Status
    {
        InProcessing,
        InConsideration,
        InExecution,
        InExecutionCheck,
        Completed,
        Archived,
    }
}