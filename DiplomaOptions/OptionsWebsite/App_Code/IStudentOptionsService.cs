using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DiplomaOptionsModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentOptionsService" in both code and config file together.
[ServiceContract]
public interface IStudentOptionsService
{
    //[OperationContract]
    //List<string> getActiveOptions();

    //[OperationContract]
    //bool boolsubmitOptions(string studentNumber, string firstName, string lastName,
    //    string firstOption, string secondOption, string thirdOption, string fourthOption);

    [OperationContract]
    List<OptionDetail> GetOptions();

    [OperationContract]
    int AddOptionSelection(SelectionDetail selection);

    [OperationContract]
    List<SelectionDetail> GetStudentChoices(int year);
}
