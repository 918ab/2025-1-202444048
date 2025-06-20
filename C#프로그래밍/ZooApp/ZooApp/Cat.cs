﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Cat
    {
        private string _name;
        private int _level;
        private COLOR _color;
        
        public string Name { get { return _name; }  }
        public COLOR Color { get { return _color; } }
        public int Level { get { return _level; } set { _level = value;  } }
        
        //이름,색깔,나이
        public Cat(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        public override string ToString()
        {
            return $"CAT:{_name}";
        }

        public string Meow(int count)
        {
            string text = "";
            for (int i = 0; i < count; i++){
                text += "냥!";
            }
            return text;
        }
        public void Eat()
        {
            AddLevel(3);
        }

        public void Play()
        {
            AddLevel(2);
        }
        private bool AddLevel(int level)
        {
            if(_level + level <= 100){
                _level += level;
                return true;
            } else {
                _level = 100;
                return false;
            }
        }
    }
}
