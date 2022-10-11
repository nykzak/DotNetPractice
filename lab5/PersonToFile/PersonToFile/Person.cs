using System;

namespace PersonToFile
{
    [Serializable]
    class Person
    {
        public string name;
        public string persСode;
        public string age;

        public Person(string a,string b,string c)
        {
            name=a; 
            persСode=b; 
            age=c;
        }
       

    }


}

