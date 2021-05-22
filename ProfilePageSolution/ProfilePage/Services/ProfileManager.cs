using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProfilePage.Models;

namespace ProfilePage.Services
{
    public class ProfileManager:IRepo<Profile>
    {
        private ProfileContext _context;
        private ILogger<ProfileManager> _logger;

        public ProfileManager(ProfileContext context, ILogger<ProfileManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(Profile t)
        {
            try
            {
                _context.Profiles.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }

       

        public IEnumerable<Profile> GetAll()
        {
            try
            {
                if (_context.Profiles.Count() == 0)
                    return null;
                return _context.Profiles.ToList();
                   
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

    }
}
