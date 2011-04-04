using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DiplomaOptionsModel;
using System.Configuration;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentOptionsService" in code, svc and config file together.
public class StudentOptionsService : IStudentOptionsService
{
    DiplomaOptionsEntities1 cxt = new DiplomaOptionsEntities1();

    public List<OptionDetail> GetOptions()
    {
        return cxt.Options.Where(o => o.IsActive == true).Select(o => new OptionDetail() { Title = o.Title }).ToList();
    }

    public int AddOptionSelection(SelectionDetail selection)
    {
        StudentOptionChoice s = new StudentOptionChoice()
        {
            StudentNumber = selection.StudentNumber,
            FirstName = selection.FirstName,
            LastName = selection.LastName,
            FirstChoice = selection.FirstChoice,
            SecondChoice = selection.SecondChoice,
            ThirdChoice = selection.ThirdChoice,
            FourthChoice = selection.FourthChoice,
            CreateDate = DateTime.Now.Date,
            Year = Convert.ToInt32(ConfigurationManager.AppSettings["Year"])
        };
        cxt.AddToStudentOptionChoices(s);
        cxt.SaveChanges();
        return s.ChoiceId;
    }

    public List<SelectionDetail> GetStudentChoices(int year)
    {
        return cxt.StudentOptionChoices
            .Where(s => s.Year == year)
            .Select(s => new SelectionDetail()
            {
                ChoiceId = s.ChoiceId,
                StudentNumber = s.StudentNumber,
                FirstName = s.FirstName,
                LastName = s.LastName,
                FirstChoice = s.FirstChoice,
                SecondChoice = s.SecondChoice,
                ThirdChoice = s.ThirdChoice,
                FourthChoice = s.FourthChoice,
                Year = s.Year,
                CreateDate = s.CreateDate
            }).ToList();
    }
}
