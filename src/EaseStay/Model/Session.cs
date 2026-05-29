using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaseStay.Model
{
    internal class Session
    {
        public Guid Id { get; set; }

        public Guid UserUUID { get; set;  }
        public string FirstName { get; set;  }
        public string LastName { get; set;  }
        public string Email { get; set;  }
    }
}
