using KodlamaIOWebDesignHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.Interface;

interface IInstructor
{
    public void AddInstructor(Instructors ins);
    public void RemoveInstructor(Instructors ins);
    public void UpdateInstructor(Instructors ins);

    List<Instructors> GetInstructorList();
}
