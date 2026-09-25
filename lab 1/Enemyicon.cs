using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace lab_1
{
    public class EnemyIcon
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public EnemyIcon(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }

        public override string ToString() => Name;

    }   
}