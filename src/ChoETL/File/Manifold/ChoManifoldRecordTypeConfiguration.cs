using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL
{
    [DataContract]
    public class ChoManifoldRecordTypeConfiguration : ChoRecordTypeConfiguration
    {
        [DataMember]
        public int StartIndex
        {
            get;
            set;
        }
        [DataMember]
        public int Size
        {
            get;
            set;
        }
    }
}
