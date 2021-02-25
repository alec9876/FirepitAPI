using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirepitAPI.Repositories.Interface
{
    public interface IUnitOfWork
    {
        IUsersRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }
        ILikesRepository LikesRepository { get; }
        IPhotoRepository PhotosRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}
