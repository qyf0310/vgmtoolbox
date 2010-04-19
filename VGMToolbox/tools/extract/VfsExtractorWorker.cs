﻿using System.ComponentModel;

using VGMToolbox.plugin;
using VGMToolbox.util;

namespace VGMToolbox.tools.extract
{
    class VfsExtractorWorker : AVgmtDragAndDropWorker, IVgmtBackgroundWorker
    {
        public const string LITTLE_ENDIAN = "Little Endian";
        public const string BIG_ENDIAN = "Big Endian";
        
        public struct VfsExtractorStruct : IVgmtWorkerStruct
        {
            public string[] SourcePaths { set; get; }
            public string HeaderSourcePath { set; get; }

            // total files
            public bool UseFileCountOffset { set; get; }     // user entered value
            public string FileCountValue { set; get; }
            public string FileCountValueOffset { set; get; } // file count is in VFS
            public string FileCountValueLength { set; get; }
            public bool FileCountValueIsLittleEndian { set; get; }
            
            // header size
            public string FileCountEndOffset { set; get; }
            public bool UseHeaderSizeOffset { set; get; }
            public string HeaderSizeValueOffset { set; get; }
            public string HeaderSizeValueLength { set; get; }
            public bool HeaderSizeValueIsLittleEndian { set; get; }

            // file information
            public string FileRecordsStartOffset { set; get; }
            public string FileRecordSize { set; get; }

            public bool UsePreviousFilesSizeToDetermineOffset { set; get; }
            public string BeginCuttingFilesAtOffset { set; get; }

            public string FileRecordOffsetOffset { set; get; }
            public string FileRecordOffsetLength { set; get; }
            public bool FileRecordOffsetIsLittleEndian { set; get; }
            public bool UseFileRecordOffsetMultiplier { set; get; }
            public string FileRecordOffsetMultiplier { set; get; }

            public string FileRecordLengthOffset { set; get; }
            public string FileRecordLengthLength { set; get; }
            public bool FileRecordLengthIsLittleEndian { set; get; }
            public bool UseLocationOfNextFileToDetermineLength { set; get; }
            public bool UseFileRecordLengthMultiplier { set; get; }
            public string FileRecordLengthMultiplier { set; get; }

            public string FileRecordNameOffset { set; get; }
            public string FileRecordNameLength { set; get; }
            public string FileRecordNameTerminator { set; get; }
            public bool FileRecordNameIsPresent { set; get; }

            public VfsExtractionStruct ToVfsExtractionStruct()
            {
                VfsExtractionStruct ret = new VfsExtractionStruct();

                ret.UseFileCountOffset = this.UseFileCountOffset;
                ret.FileCountValue = this.FileCountValue;
                ret.FileCountValueOffset = this.FileCountValueOffset;
                ret.FileCountValueLength = this.FileCountValueLength;
                ret.FileCountValueIsLittleEndian = this.FileCountValueIsLittleEndian;
                
                ret.UseHeaderSizeOffset = this.UseHeaderSizeOffset;
                ret.HeaderSizeValueOffset = this.HeaderSizeValueOffset;
                ret.HeaderSizeValueLength = this.HeaderSizeValueLength;
                ret.HeaderSizeValueIsLittleEndian = this.HeaderSizeValueIsLittleEndian;
                ret.FileCountEndOffset = this.FileCountEndOffset;

                // file information
                ret.FileRecordsStartOffset = this.FileRecordsStartOffset;
                ret.FileRecordSize = this.FileRecordSize;

                ret.UsePreviousFilesSizeToDetermineOffset = this.UsePreviousFilesSizeToDetermineOffset;
                ret.BeginCuttingFilesAtOffset = this.BeginCuttingFilesAtOffset;

                ret.FileRecordOffsetOffset = this.FileRecordOffsetOffset;
                ret.FileRecordOffsetLength = this.FileRecordOffsetLength;
                ret.FileRecordOffsetIsLittleEndian = this.FileRecordOffsetIsLittleEndian;
                ret.UseFileRecordOffsetMultiplier = this.UseFileRecordOffsetMultiplier;
                ret.FileRecordOffsetMultiplier = this.FileRecordOffsetMultiplier;

                ret.FileRecordLengthOffset = this.FileRecordLengthOffset;
                ret.FileRecordLengthLength = this.FileRecordLengthLength;
                ret.FileRecordLengthIsLittleEndian = this.FileRecordLengthIsLittleEndian;
                ret.UseLocationOfNextFileToDetermineLength = this.UseLocationOfNextFileToDetermineLength;
                ret.UseFileRecordLengthMultiplier = this.UseFileRecordLengthMultiplier;
                ret.FileRecordLengthMultiplier = this.FileRecordLengthMultiplier;

                ret.FileRecordNameOffset = this.FileRecordNameOffset;
                ret.FileRecordNameLength = this.FileRecordNameLength;
                ret.FileRecordNameTerminator = this.FileRecordNameTerminator;
                ret.FileRecordNameIsPresent = this.FileRecordNameIsPresent;
                
                return ret;
            }
        }
        
        public VfsExtractorWorker() : 
            base() 
        {
            this.progressCounterIncrementer = 10;
        }

        protected override void DoTaskForFile(string pPath, IVgmtWorkerStruct pVfsExtractorStruct,
            DoWorkEventArgs e)
        {
            VfsExtractorStruct taskStruct = (VfsExtractorStruct)pVfsExtractorStruct;
            VfsExtractionStruct extractionStruct = taskStruct.ToVfsExtractionStruct();
            string output;

            ParseFile.ParseVirtualFileSystem(pPath, taskStruct.HeaderSourcePath, extractionStruct, out output, true, true);

            this.outputBuffer.Append(output);           
        }
    }
}
