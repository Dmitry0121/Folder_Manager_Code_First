using FoldersManager.Domain.Entities.Context;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FoldersManager.Domain.Entities
{
    [DuplicateNameAttribute(ErrorMessage = "Invalid name")]
    public class Folder
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'' '\s]*$")]
        public string Name { get; set; }

        public int? Parent { get; set; }

        [ForeignKey("Parent")]
        public virtual ICollection<Folder> Folders { get; set; }
        
        public class DuplicateNameAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                Folder newItem = value as Folder;

                using (FolderContext db = new FolderContext())
                {
                    Folder foundItem = db.Folders
                                        .Where(f => f.Name.Equals(newItem.Name))
                                        .Where(f => f.Parent == newItem.Parent)
                                        .FirstOrDefault();

                    if (foundItem == null)
                    {
                        return true;
                    }
                    else
                    {
                        if (newItem.Id != foundItem.Id)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }
    }
}
