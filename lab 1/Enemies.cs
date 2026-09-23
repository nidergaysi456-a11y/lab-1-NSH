using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace lab_1
{
        public class Enemies
        {
            [JsonInclude]
            public string EnemyType { get; private set; }
            [JsonInclude]
            public int HP { get; private set; }
            [JsonInclude]
            public int Level { get; private set; }
            [JsonInclude]
            public int Damage { get; private set; }
            [JsonConstructor] 
            public Enemies(string enemyType, int hp, int level, int damage)
            {
                EnemyType = enemyType;
                HP = hp;
                Level = level;
                Damage = damage;
            }
        }
    }