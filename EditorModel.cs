using System;

namespace Blazaco
{
	public class EditorModel
	{
        public string Id { get; set; } = $"Blazaco_{new Random().Next(0, 1000000).ToString()}";

        public string Language { get; set; } = string.Empty;
        public string Theme { get; set; } = "vs";
        public string Value { get; set; } = string.Empty;
    }
}
