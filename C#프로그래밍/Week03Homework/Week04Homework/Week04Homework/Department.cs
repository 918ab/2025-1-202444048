using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //Object 클래스를 상속한 Department
    class Department : Object
    {
        //인스턴스 필드(변수), 멤버 변수
        public string Code;
        public string Name;

        //python의 __str__()와 동일
        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }
    }
}
