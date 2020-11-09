using FoldersManager.Domain.Entities;
using FoldersManager.Domain.Entities.Context;

namespace FoldersManager.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FolderContext())
            {
                Folder folder_8 = new Folder() { Id = 8, Name = "Final Product", Parent = 4 };
                Folder folder_7 = new Folder() { Id = 7, Name = "Process", Parent = 4 };
                Folder folder_6 = new Folder() { Id = 6, Name = "Secondary Sources", Parent = 2 };
                Folder folder_5 = new Folder() { Id = 5, Name = "Primary Sources", Parent = 2 };
                Folder folder_4 = new Folder() { Id = 4, Name = "Graphic Products", Parent = 1 };
                Folder folder_3 = new Folder() { Id = 3, Name = "Evidence", Parent = 1 };
                Folder folder_2 = new Folder() { Id = 2, Name = "Resources", Parent = 1 };
                Folder folder_1 = new Folder() { Id = 1, Name = "Creating Digital Images", Parent = null };

                db.Folders.Add(folder_1);
                db.Folders.Add(folder_2);
                db.Folders.Add(folder_3);
                db.Folders.Add(folder_4);
                db.Folders.Add(folder_5);
                db.Folders.Add(folder_6);
                db.Folders.Add(folder_7);
                db.Folders.Add(folder_8);

                db.SaveChanges();
            }
        }
    }
}
