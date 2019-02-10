using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2 {
    class Guild {
        readonly uint id;
        string name;
        string server;
        GuildType type;

        public Guild() {
            id = 0;
            name = "No name";
            server = "Rexxar";
            type = 0;
        }

        public Guild(uint id, string name, string server, GuildType type) {
            this.id = id;
            this.name = name;
            this.server = server;
            this.type = type;
        }

        public uint ID {
            get { return this.id; }
        }

        public string Name {
            get { return this.name; }
        }

        public string Server {
            get { return this.server; }
        }

    }
}
