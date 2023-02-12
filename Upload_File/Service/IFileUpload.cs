using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;

namespace Upload_File.Service
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
