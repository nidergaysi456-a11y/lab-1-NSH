using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace lab_1
{
    public class Enemies
    {
        //Свойства класса — будут сохранены в json благодаря [JsonInclude]
        [JsonInclude]
        public string EnemyType { get; private set; }
        [JsonInclude]
        public int HP { get; private set; }
        [JsonInclude]
        public int Level { get; private set; }
        [JsonInclude]
        public int Damage { get; private set; }
    
    public Enemies(string enemyType, int hp, int level, int damage)
        {
            EnemyType = enemyType;
            HP = hp;
            Level = level;
            Damage = damage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём список экземпляров класса
            List<Enemies> enemies = new List<Enemies>();
           enemies.Add(new Enemies("Bastard", 50, 3, 15 ));
           enemies.Add(new Enemies("Cyclop", 80, 3, 30));
           enemies.Add(new Enemies("Pipega", 10, 10, 98));

            // Сериализация списка в JSON
            string jsonString = JsonSerializer.Serialize(enemies);
            // Сохранение JSON в файл
            File.WriteAllText("enemies.json", jsonString);
        }
    }
}
