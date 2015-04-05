namespace AuEditor
{
    public class AuFile
    {
        public string FilePath { get; set; }
        public AuFileHeader Header { get; set; }
        public AuFileData Channels { get; set; }
    }
}
