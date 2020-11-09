using System.Data.Entity;

namespace FoldersManager.Domain.Entities.Context
{
    public class FolderContext : DbContext
    {
        public FolderContext() : base("FoldersStructureDatabase") { }

        public virtual DbSet<Folder> Folders { get; set; }
    }
}
