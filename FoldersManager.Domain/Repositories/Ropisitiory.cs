using System.Linq;
using System.Data.Entity;
using FoldersManager.Domain.Entities;
using FoldersManager.Domain.Entities.Context;

namespace FoldersManager.Domain.Repositories
{
    public class Ropisitiory
    {
        private FolderContext pContext;

        public Ropisitiory()
        {
            pContext = new FolderContext();
        }

        public Folder GetFolderById(int Id)
        {
            return pContext.Folders
                .Where(f => f.Id == Id)
                .Include(g => g.Folders)
                .FirstOrDefault();
        }
    }
}