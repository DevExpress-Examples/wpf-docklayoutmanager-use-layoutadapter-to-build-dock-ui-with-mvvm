namespace dxSampleGrid {
      
    public class Person  {
       
        public Person(int i) {
            FirstName = "FirstName" + i;
            LastName = "LastName" + i;
            Age = i * 10;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ParentName { get; set; }
        public bool IsTabbed { get; set; }
        public bool IsFloat { get; set; }
    }
}
