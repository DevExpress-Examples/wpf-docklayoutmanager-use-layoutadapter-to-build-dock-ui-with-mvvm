using System.Collections.ObjectModel;

namespace dxSampleGrid {
    public class MyViewModel  {
        public MyViewModel() {
            CreateList();
        }
     
        public ObservableCollection<Person> PersonList { get; set; }

        void CreateList() {
            PersonList = new ObservableCollection<Person>();
            for (int i = 0; i < 5; i++) {
                Person p = new Person(i);
                p.ParentName = "LayoutGroup1";
                PersonList.Add(p);
            }
            PersonList[0].IsTabbed = true;
            PersonList[1].IsTabbed = true;
            PersonList[2].IsFloat = true;
        }
    }


}
