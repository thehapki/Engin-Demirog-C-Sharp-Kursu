using KodlamaIOWebDesignHomework.Entities;
using KodlamaIOWebDesignHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.DataAccess;

class InstructorData : IInstructor
{
    List<Instructors> instructorList;

    public InstructorData()
    {
        instructorList = new List<Instructors>
        {
            new Instructors(){InstructorId = 1, InstructorName = "Engin Demiroğ" },
            new Instructors(){InstructorId = 2, InstructorName = "Halit Enes Kayalcı" }
        };
    }


    public void AddInstructor(Instructors ins)
    {
        instructorList.Add(ins);
    }

    public void RemoveInstructor(Instructors ins)
    {
        instructorList.Remove(ins);
    }

    public void UpdateInstructor(Instructors ins)
    {
        var tempInstructorId = instructorList.FirstOrDefault(inst => inst.InstructorId == ins.InstructorId);

        if(tempInstructorId != null)
        {
            tempInstructorId.InstructorId = ins.InstructorId;
            tempInstructorId.InstructorName = ins.InstructorName;
        }
    }

    List<Instructors> IInstructor.GetInstructorList()
    {
        foreach (var item in instructorList)
        {
            Console.WriteLine($"Eğitmenlerimiz:\n {item.InstructorId}: {item.InstructorName}");
        }
        return instructorList;
    }
}
