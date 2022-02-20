using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNetDemo.Console
{
    public class Class1
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; init;}

        public override string ToString()
        {
            return $" {nameof(MyProperty)} : { MyProperty} , {nameof(MyProperty2)} : {MyProperty2}";
        }

        public int Sum() => MyProperty + MyProperty2; // Expression bodied members.
    }
}
