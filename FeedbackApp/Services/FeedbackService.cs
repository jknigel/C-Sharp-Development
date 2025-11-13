using FeedbackApp.Models;

namespace FeedbackApp.Services
{
    public class FeedbackService
    {
        public List<Feedback> feedbackList = new List<Feedback>();
        public List<Feedback> GetAllFeedbacks() => feedbackList;

        public void AddFeedback(Feedback feedback)
        {
            feedbackList.Add(feedback);
        }
    }
}

