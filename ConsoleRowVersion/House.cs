namespace ConsoleRowVersion
{
    public class House
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Owner { get; set; }
        public byte[] RowVer { get; set; }
    }
}
