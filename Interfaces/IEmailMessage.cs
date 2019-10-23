using Penguin.Files.Abstractions;
using System.Collections.Generic;

namespace Penguin.Email.Abstractions.Interfaces
{
    /// <summary>
    /// An interface representing an email message to be used by the email services in the penguin stack
    /// </summary>
    public interface IEmailMessage
    {
        /// <summary>
        /// An IEnumerable of IFile representing any attachments to be added to the message
        /// </summary>
        IEnumerable<IFile> Attachments { get; }

        /// <summary>
        /// An IEnumerable of BCC recipients
        /// </summary>
        IEnumerable<string> BCCRecipients { get; }

        /// <summary>
        /// The Body HTML of the email
        /// </summary>
        string Body { get; }

        /// <summary>
        /// An IEnumerable of CC recipients
        /// </summary>
        IEnumerable<string> CCRecipients { get; }

        /// <summary>
        /// The account the email is coming from, to be used when using configurations for the sent email
        /// </summary>
        string From { get; }

        /// <summary>
        /// Whether or not the Email contains HTML encoded content
        /// </summary>
        bool IsHtml { get; }

        /// <summary>
        /// An IEnumerable of message recipients
        /// </summary>
        IEnumerable<string> Recipients { get; }

        /// <summary>
        /// The email subject
        /// </summary>
        string Subject { get; }
    }
}