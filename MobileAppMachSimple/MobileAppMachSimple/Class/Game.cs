using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppMachSimple.Class
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdPublisher { get; set; }
        public Publisher Publish { get; set; }
    }
}
