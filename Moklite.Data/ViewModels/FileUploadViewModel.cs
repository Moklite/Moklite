using Moklite.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moklite.Data.ViewModels
{
    public class FileUploadViewModel
    {
        public List<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
    }
}
