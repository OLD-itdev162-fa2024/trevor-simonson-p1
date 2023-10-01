namespace Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaType
    {
        image = 1,
        video = 2
    }
}