using System.Collections.Generic;
using System.Collections.ObjectModel;
using HorseShow.Model;

namespace HorseShow.PageModel
{
    public class ClassesPageModel: FreshMvvm.FreshBasePageModel
    {
         public List<Discipline>  DisciplineList { get; set; }
        List<string> lista = new List<string>();
        public ClassesPageModel()
        {
            
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            LoadDisciplineIntoList();
        }

        private async void LoadDisciplineIntoList()
        {
            var DateGroup = new Discipline() { headerName = "Date" };

            var DisciplineGroup = new Discipline() { headerName = "Discipline" };

            DateGroup.discipline ="All Classes By Date";
            //listDiscipline = await App.HSEventManager.GetDiscipline();
            //if (listDiscipline != null)
            lista = await App.HSEventManager.GetDisciplineString();
            {
                foreach (var e in lista)
                {
                    DisciplineGroup.discipline = e;
                }
            }

            DisciplineList.Add(DateGroup);
            DisciplineList.Add(DisciplineGroup);
        }
    }
}