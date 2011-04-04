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
    [Required(ErrorMessage = "Student number is required.")]
    //[StringLength(9,MinimumLength=0,ErrorMessage="")]
    [RegularExpression("^[aA]0{2}[0-9]{6}", ErrorMessage="Student number does not match A00xxxxxx format.")]
    public string StudentNumber { get; set; }
    [DataMember]
    [Required(ErrorMessage = "First name is required.")]
    public string FirstName { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Last name is required.")]
    public string LastName { get; set; }
    [DataMember]
    [Required(ErrorMessage = "First Choice is required.")]
    public string FirstChoice { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Second Choice is required.")]
    public string SecondChoice { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Third Choice is required.")]
    public string ThirdChoice { get; set; }
    [DataMember]
    [Required(ErrorMessage = "Fourth Choice is required.")]
    public string FourthChoice { get; set; }
    [DataMember]
    public DateTime CreateDate { get; set; }
    [DataMember]
    public int ChoiceId { get; set; }
    [DataMember]
    public int Year { get; set; }
}