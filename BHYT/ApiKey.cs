
using System.Runtime.Serialization;

namespace BHYT
{
    [DataContract]
    public class ApiKey
    {
        [DataMember]
        public string access_token { get; set; }
        [DataMember]
        public string id_token
        {
            get;
            set;
        }

        [DataMember]
        public string token_type
        {
            get;
            set;
        }

        [DataMember]
        public string username
        {
            get;
            set;
        }

        [DataMember]
        public System.DateTime expires_in
        {
            get;
            set;
        }
    }

}
