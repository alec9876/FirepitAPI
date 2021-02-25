﻿using FirepitAPI.Data;
using FirepitAPI.DTO;
using FirepitAPI.Models;
using FirepitAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirepitAPI.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly DataContext _context;
        public PhotoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PhotoForApprovalDTO>> GetUnapprovedPhotos()
        {
            return await _context.Photos
            .IgnoreQueryFilters()
            .Where(p => p.IsApproved == false)
            .Select(u => new PhotoForApprovalDTO
            {
                Id = u.Id,
                Username = u.AppUser.UserName,
                Url = u.ImageUrl,
                IsApproved = u.IsApproved
            }).ToListAsync();
        }
        public async Task<Photo> GetPhotoById(int id)
        {
            return await _context.Photos
            .IgnoreQueryFilters()
            .SingleOrDefaultAsync(x => x.Id == id);
        }
        public void RemovePhoto(Photo photo)
        {
            _context.Photos.Remove(photo);
        }
    }
}
