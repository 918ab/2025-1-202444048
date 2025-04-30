using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //열거형, enum == 정수형 값에 이름을 붙이는 것.
    enum YEAR
    {
        ONE = 0,
        TWO,
        THREE,
        FOUR,

        END,
    }
    enum CLASS
    {
        A,
        B,
        C,

        END,
    }
    class Student {

        //static field
        //메모리 하나만 할당 됨.
        public static Dictionary<YEAR, string>
            YearNames = new Dictionary<YEAR, string>() {
                {YEAR.ONE,   "1학년"},
                {YEAR.TWO,   "2학년"},
                {YEAR.THREE, "3학년"},
                {YEAR.FOUR,  "4학년 (심화)"},
            };
        public string Number { get; private set; } //학번
        public string Name { get; set; } //이름
        public DateTime BirthInfo { get; private set;} //생년월일
        public void SetBirthInfo(int y, int m, int d)
        {
            BirthInfo = new DateTime(y, m, d);
        }
        public string DepartmentCode { get; set; } //학과코드
        public string AdvisorNumber { get; set; } //지도교수번호
        public YEAR Year { get; set; } // 학년
        public CLASS Class { get; set; }// 반
        public string RegStatus { get; set; }//재적상태

        //자동 구현 프로퍼티
        public string Address { get; set; }//주소

        //전형적인 프로퍼티
        private string _contact;//연락처
        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }
        public Student(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public override string ToString() {
            return $"[{this.Number}]{this.Name}";
        }

    }
}
