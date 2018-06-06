using MediatR;

namespace MediatrAPI.Notifications
{
    public class NewValueAddedNotification : INotification
    {
        public NewValueAddedNotification(string newValue)
        {
            NewValue = newValue;
        }

        public string NewValue { get; }
    }
}
