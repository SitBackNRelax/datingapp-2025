using System;
using System.Linq.Expressions;
using API.DTOs;
using API.Entities;

namespace API.Exetnsions;

public static class MessageExtensions
{
    public static MessageDto ToDto(this Message message)
    {
        return new MessageDto
        {
            Id = message.Id,
            SenderId = message.SenderId,
            SenderDisplayName = message.Sender.DisplayName,
            SenderUrl = message.Sender.ImageUrl,
            RecipientId = message.Recipient.Id,
            RecipientDisplayName = message.Recipient.DisplayName,
            RecipientUrl = message.Recipient.ImageUrl,
            Content = message.Content,
            DateRead = message.DateRead,
            MessageSent = message.MessageSent
        };
    }

    public static Expression<Func<Message, MessageDto>> ToDtoProjection()
    {
        return message => new MessageDto
        {
            Id = message.Id,
            SenderId = message.SenderId,
            SenderDisplayName = message.Sender.DisplayName,
            SenderUrl = message.Sender.ImageUrl,
            RecipientId = message.Recipient.Id,
            RecipientDisplayName = message.Recipient.DisplayName,
            RecipientUrl = message.Recipient.ImageUrl,
            Content = message.Content,
            DateRead = message.DateRead,
            MessageSent = message.MessageSent
        };
    }
}
