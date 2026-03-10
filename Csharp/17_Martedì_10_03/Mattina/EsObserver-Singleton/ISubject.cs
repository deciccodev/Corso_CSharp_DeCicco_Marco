public interface ISubject
{
    void AttachMobile(IObserverMobile observer);
    void DetachMobile(IObserverMobile observer);
    void NotifyMobile(string newsMobile);
    void AttachEmail(IObserverEmail observer);
    void DetachEmail(IObserverEmail observer);
    void NotifyEmail(string newsEmail);
}