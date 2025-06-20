﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Dog : Animal
    {
        //아래 두개는 부모 것을 접근 못해서
        //그대로 사용해도 문제 없음.
        //private string _name;
        //private int _level;

        //아래 한 개는 부모 것에 접근할 수
        //있지만 나만 것을 만들 때 쓰는 경우
        //private new COLOR _color;

        //부모에도 없는 것
        private int _year;

                
        //public string Name { get { return _name; }  }
        //public COLOR Color { get { return _color; } }
        //public int Level { get { return _level; } }

        public int Year { get { return _year; } }
        
        //이름,색깔,나이
        public Dog(string name, COLOR color, int year)
            //: base() //기본 base() 생성자
            : base(name, color)
        {
            //_name = name;
            //_color = color;
            _year = year;
        }

        public override string ToString()
        {
            return $"DOG:{Name}";
        }

        public string Bark(int count)
        {
            string text = "";
            for (int i = 0; i < count; i++){
                text += "왈!";
            }
            return text;
        }

        //오버라이딩
        public override void Eat()
        {
            AddLevel(30);
        }


        //하이딩
        public new void Play()
        {
            AddLevel(20);
        }

        protected override bool AddLevel(int level)
        {
            if (_level + level <= 100)
            {
                _level += level;
                return true;
            } else
            {
                _level = 100;
                return false;
            }
        }
    }
}
