using mainservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace mainservice.Controllers
{
    /// <summary>
    /// Manage all email message activities
    /// </summary>
    [Route("api/[controller]")]
    public class MailController
    {
        // POST api/values
        /// <summary>
        /// Enqueue an email message
        /// </summary>
        /// <remarks>
        /// This method enqueue an email message to be send to the receipts.
        /// In the message is possible to specify attachments, copy and hidden copy receipts.
        /// </remarks>
        /// <param name="mailMessage">The message to be queued to be send</param>
        /// <response code="201">The email message was enqueued succefully.</response>
        /// <response code="400">The email message sent is invalid or malformed.</response>
        /// <response code="401">There`s no authentication data or the authentication is invalid.</response>
        /// <response code="403">The authentication data isn`t suficient to call this method.</response>
        /// <response code="500">Bad bad, Dr. App. We`ve experiencing some troble.</response>
        [HttpPost]
        [ProducesResponseType(typeof(MailMessage),201)]
        [ProducesResponseType(typeof(MailMessage),400)]
        [ProducesResponseType(typeof(MailMessage),401)]
        [ProducesResponseType(typeof(MailMessage),403)]
        [ProducesResponseType(typeof(MailMessage),500)]
        public void Post([FromBody]MailMessage mailMessage)
        {

        }
    }
}