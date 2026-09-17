using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace lab_1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            // Чтение JSON из файла
            string jsonFromFile = File.ReadAllText("enemies.json");
            List<Enemies> enemies = new List<Enemies>();
            // Парсинг JSON
            JsonDocument doc = JsonDocument.Parse(jsonFromFile);
            //Добавление новой записи в список класса из json
            foreach (JsonElement element in doc.RootElement.EnumerateArray())
            {
                string enemyType = element.GetProperty("EnemyType").GetString();
                int hp = element.GetProperty("HP").GetInt32();
                int level = element.GetProperty("Level").GetInt32();
                int damage = element.GetProperty("Damage").GetInt32();
                // Создание нового экземпляра класса Person с помощью конструктора
                Enemies newenemies = new Enemies(enemyType, hp, level, damage);
                // Добавление объекта в список
                enemies.Add(newenemies);
            }
        }
    }
}
