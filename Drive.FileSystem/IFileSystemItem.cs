﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Drive.FileSystem {
    /// <summary>
    /// 檔案系統項目
    /// </summary>
    public interface IFileSystemItem {
        string Path { get; set; }
        string Name { get; set; }
        long Size { get; }
        DateTime CreationTime { get; }
        DateTime ModifyTime { get; }
        DateTime AccessTime { get; }

        [JsonConverter(typeof(StringEnumConverter))]
        FileSystemItemType Type { get; }
        string RelativePath { get; set; }

        void Move(string targetPath);
        void MoveTo(IFileSystemItem target);
        void Delete();
        IFileSystemItem GetParent(int level = 1);
    }
}
