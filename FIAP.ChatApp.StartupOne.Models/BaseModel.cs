using System;

namespace FIAP.ChatApp.StartupOne.Models
{
    public class BaseModel
    {
        public long ID { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}