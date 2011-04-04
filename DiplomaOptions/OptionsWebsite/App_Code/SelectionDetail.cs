using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

[DataContract]
public class SelectionDetail
{
    [DataMember]
    public string StudentNumber { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public string FirstChoice { get; set; }
    [DataMember]
    public string SecondChoice { get; set; }
    [DataMember]
    public string ThirdChoice { get; set; }
    [DataMember]
    public string FourthChoice { get; set; }
    [DataMember]
    public DateTime CreateDate { get; set; }
    [DataMember]
    public int ChoiceId { get; set; }
    [DataMember]
    public int Year { get; set; }
}