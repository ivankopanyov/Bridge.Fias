namespace Bridge.Fias
{
    public class FiasOptions
    {
        public const string SectionName = "Fias";

        public string Hostname { get; set; }

        public int Port { get; set; }

        public bool Running { get; set; }
    }
}
