using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class Radacct
    {
        public long Radacctid { get; set; }
        public string Acctsessionid { get; set; }
        public string Acctuniqueid { get; set; }
        public string Username { get; set; }
        public string Groupname { get; set; }
        public string Realm { get; set; }
        public string Nasipaddress { get; set; }
        public string Nasportid { get; set; }
        public string Nasporttype { get; set; }
        public DateTime? Acctstarttime { get; set; }
        public DateTime? Acctstoptime { get; set; }
        public uint? Acctsessiontime { get; set; }
        public string Acctauthentic { get; set; }
        public string ConnectinfoStart { get; set; }
        public string ConnectinfoStop { get; set; }
        public long? Acctinputoctets { get; set; }
        public long? Acctoutputoctets { get; set; }
        public string Calledstationid { get; set; }
        public string Callingstationid { get; set; }
        public string Acctterminatecause { get; set; }
        public string Servicetype { get; set; }
        public string Framedprotocol { get; set; }
        public string Framedipaddress { get; set; }
        public uint? Acctstartdelay { get; set; }
        public uint? Acctstopdelay { get; set; }
        public string Xascendsessionsvrkey { get; set; }
        public string Btk { get; set; }
    }
}
