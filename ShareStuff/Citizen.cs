using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareStuff {
    class Citizen : Person {
        private string _Job;

        public Citizen(string fNa, string lNa)
            :base(fNa,lNa){

        }

        public string Job {
            get { return _Job; }
            set { _Job = value; }
        }
    }
}
