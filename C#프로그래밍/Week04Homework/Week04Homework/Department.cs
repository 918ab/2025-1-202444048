using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //Object 클래스를 상속한 Department
    class Department : object
    {
        //인스턴스 필드
        public string _code;
        private string _name;
        
        //속성, Property
        //getter + setter 한꺼번에 구현
        //정의 : 메소드와 흡사
        //사용 : 변수와 유사
        public string Code
        {
            get { return _code; }
            private set { if (string.IsNullOrEmpty(value) == false)
                { _code = value; } }
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrEmpty(value) == false)
                { _name = value; }
            }
        }

        //getter
        public string GetCode()
        {
            return _code;
        }

        //setter
        private void SetCode(String value)
        {
            if(string.IsNullOrEmpty(value) == false){
                _code = value;
            }
            
        }

        //인스턴스 메소드
        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

        //생성자, Constructor
        //특수 메소드
        //반환타입 X, 이름이 클래스이름과 동일

        //기본(Default) 생성자
        //컴파일러 만들어준다.
        //단, 다른 생성자가 있으면 제외
        //public Department(){
            
        //}
        public Department(string code,string name)
        {
            _code = code;
            _name = name;
        }

        //메소드 오버로딩
        //동일한 메소드를 다수개 만드는 방법
        //방법 : 매개변수의 개수, 타입을 다르게 하면 됨

    }
}
