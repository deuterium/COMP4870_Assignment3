using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DiplomaOptionsModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentOptionsService" in code, svc and config file together.
public class StudentOptionsService : IStudentOptionsService
{
    DiplomaOptionsEntities1 dipo = new DiplomaOptionsEntities1();

    public List<string> getActiveOptions()
    {
        return dipo.Options.Where(s => s.IsActive).Select(s => s.Title).ToList();
    }

    public bool boolsubmitOptions(string studentNumber, string firstName, string lastName,
        string firstOption, string secondOption, string thirdOption, string fourthOption)
    {
        StudentOptionChoice soc = new StudentOptionChoice()
        {
            CreateDate = DateTime.Now.Date,
            Year = DateTime.Now.Year,
            StudentNumber = studentNumber,
            FirstName = firstName,
            LastName = lastName,
            FirstChoice = firstOption,
            SecondChoice = secondOption,
            ThirdChoice = thirdOption,
            FourthChoice = fourthOption
        };

        try
        {
            dipo.AddToStudentOptionChoices(soc);
            dipo.SaveChanges();
        }
        catch (Exception ex)
        {
            ex.ToString();
            return false;
        }

        return true;
    }
}
