﻿using FoldersManager.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FoldersManager.WebUI.Models
{
    public class FolderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }

        public string Path { get; set; }

        public ICollection<FolderViewModel> Folders { get; set; }

        public static FolderViewModel FoldersPath(Folder folder, string path)
        {
            return new FolderViewModel
            {
                Id = folder.Id,
                Name = folder.Name,
                Parent = folder.Parent,
                Folders = folder.Folders.Select(f => new FolderViewModel
                {
                    Id = f.Id,
                    Name = f.Name,
                    Path = path + "/" + f.Name
                }).ToArray()
            };
        }
    }
}