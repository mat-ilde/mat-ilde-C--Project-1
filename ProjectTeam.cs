using System;
using EmployeeDetailsImplementation;
using System.Collections.Generic; 


namespace ProjectTeamProgrammerInCharge{


  // class ProgrammerIncharge implementing the interface Employee
    public class ProjectTeam{

        private List<ProgrammerIncharge> listOfProgrammersInCharge=new List<ProgrammerIncharge>();
        private ProgrammerIncharge? programmerIncharge {set;get;}

        public ProjectTeam()
        {
            
        }

        public void SetProjectTeam(ProgrammerIncharge programmer ){
            programmerIncharge=programmer;
            listOfProgrammersInCharge.Add(programmer);

        }
        public void GetProjecTeam(){
          foreach(ProgrammerIncharge programmer in listOfProgrammersInCharge){

            Console.Write(programmer.ToString());

          }
        }
    }

}