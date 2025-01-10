namespace Recombee.ApiClient.Bindings
{
    /// <summary>Binding for string response</summary>
    public class StringBinding: RecombeeBinding
    {
        private readonly string str;

        /// <summary>String response</summary>
        public string StringValue
        {
            get {return str;}
        }

        public StringBinding(string str)
        {
            this.str = str;
        }
    }
}
