using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_A
{
    enum MainMenu
    {
        AddEntity = 1,
        //SynthData,
        ShowData,
        Exit

    }
    enum AddEntity
    {
        AddStudent = 1,
        AddCourse,
        AddTrainer,
        AddAssigment,
        PreviousMenu
    }
    enum ShowData
    {
        ShowStudent = 1,
        ShowCourse,
        ShowTrainer,
        ShowAssigment,
        PreviousMenu
    }
}

