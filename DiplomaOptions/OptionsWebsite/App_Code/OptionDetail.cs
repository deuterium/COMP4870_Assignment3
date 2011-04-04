using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

[DataContract]
public class OptionDetail
{
    [DataMember]
    public string Title { get; set; }
}