using System;

namespace API.Interfaces;

public interface IunitOfWork
{
    IMemberRepository MemberRepository { get; }
    IMessageRepoository MessageRepository { get; }
    ILikesRepository LikesRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
}