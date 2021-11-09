namespace System
{
    internal class EventHandle
    {
        private Action<object, EventArgs> removeWhitespace;

        public EventHandle(Action<object, EventArgs> removeWhitespace)
        {
            this.removeWhitespace = removeWhitespace;
        }
    }
}