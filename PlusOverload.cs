using CustomListUnitTestProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTest
{
    class PlusOverload
    {
        public void something()
        {
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            test1.AddMethod(1);
            test2.AddMethod(2);
            //expected {1,2}
            CustomList<int> list3 = test1 + test2;
        }
    }
}
