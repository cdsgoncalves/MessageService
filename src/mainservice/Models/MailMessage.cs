using System;
using System.Collections.Generic;

namespace mainservice.Models
{
    /// <summary>
    /// Specify an email message
    /// </summary>
    public class MailMessage
    {
        /// <summary>
        /// Gets the id of the message
        /// </summary>
        public Guid Id { get; private set; }
        /// <summary>
        /// Gets or sets the title of the message
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the body of the message
        /// </summary>
        /// <remarks>
        /// The body of the message is a required information.
        /// Email messages withou body cannot be enqueued.
        /// </remarks>
        public string Body { get; set; }
        /// <summary>
        /// Gets or sets the attachments of the message
        /// </summary>
        /// <returns></returns>
        public IEnumerable<byte[]> Attachments { get; set; }
        /// <summary>
        /// Gets or sets the recipients of the message
        /// </summary>
        public IEnumerable<MailAddress> Recipients { get; set; }
        /// <summary>
        /// Gets or sets the copied recipients of the message
        /// </summary>
        public IEnumerable<MailAddress> CopyRecipients { get; set; }
        /// <summary>
        /// Gets or sets the hiden copied recipients of the message
        /// </summary>
        public IEnumerable<MailAddress> HideCopyRecipients { get; set; }
        /// <summary>
        /// Gets or sets the sender oh the message
        /// </summary>
        public MailAddress Sender { get; set; }

        /// <summary>
        /// Creates a new email message with an unique id
        /// </summary>
        public MailMessage()
        {
            Id = new Guid();
        }
    }
}