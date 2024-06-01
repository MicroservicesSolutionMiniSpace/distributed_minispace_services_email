namespace MiniSpace.Web.DTO.Enums
{
    public enum NotificationEventType
    {
        NewFriendRequest,
        FriendRequestAccepted,
        NewEvent,
        EventDeleted,
        EventNewSignUp,
        EventNewSignUpFriend,
        StudentCancelledSignedUpToEvent,
        StudentShowedInterestInEvent,
        StudentCancelledInterestInEvent,
        EventParticipantAdded,
        EventParticipantRemoved,
        PostCreated,
        PostUpdated,
        MentionedInPost,
        EventReminder,
        PasswordResetRequest,
        UserSignUp,
        NewEventInvitaion,
        CommentCreated,
        CommentUpdated,
        ReactionAdded,
        ReportCreated,
        ReportDeleted,
        ReportRejected,
        ReportResolved,
        ReportReviewStarted,
        Other
    }
}