using MongoDB.Driver.Core.Configuration;

namespace Assigment.Models
{
    public class SureMDMDatabaseSettings : ISureMDMDatabaseSettings
    {
        public string CollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;

    }
}
