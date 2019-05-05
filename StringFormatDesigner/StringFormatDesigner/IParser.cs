using System;


namespace StringFormatDesigner
{
    public interface IParser
    {
        string Description { get; }
        string TryParse(string value, string format);
    }
}
