using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirepitAPI.DTO;
using FirepitAPI.Helpers;
using FirepitAPI.Models;

namespace FirepitAPI.Repositories.Interface
{
    public interface IUsersRepository
    {
        void Update(AppUser user);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<AppUser> GetUserByPhotoId(int photoId);
        Task<PagedList<MemberDTO>> GetMembersAsync(UserParams userParams);
        Task<MemberDTO> GetMemberAsync(string username, bool? isCurrentUser);

    }
}
