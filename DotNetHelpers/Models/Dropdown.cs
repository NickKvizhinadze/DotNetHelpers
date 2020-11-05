namespace DotNetHelpers.Models
{
    /// <summary>
    /// Model for dropdowns
    /// </summary>
    /// <typeparam name="T">type of value</typeparam>
    public class Dropdown<T>
    {
        /// <summary>
        /// empty constructor
        /// </summary>
        public Dropdown()
        {
            Value = default;
            Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="text">Text</param>
        public Dropdown(T value, string text)
        {
            Value = value;
            Text = text;
        }

        /// <summary>
        /// Value
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// If value is selected
        /// </summary>
        public bool Selected { get; set; }
    }
}
