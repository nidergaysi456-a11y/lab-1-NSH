using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace lab_1
{
    public class CEnemyTemplateList
    {
        // Список противников
        private List<CEnemyTemplate> enemies;

        public CEnemyTemplateList()
        {
            enemies = new List<CEnemyTemplate>();
        }

        // Добавляет нового противника в список
        public void AddEnemy(string name, string iconName, int baseLife,
                             double lifeModifier, int baseGold,
                             double goldModifier, double spawnChance)
        {
            CEnemyTemplate enemy = new CEnemyTemplate(
                name, iconName, baseLife,
                lifeModifier, baseGold, goldModifier, spawnChance);

            enemies.Add(enemy);
        }

        public List<string> GetListOfEnemyNames()
        {
            List<string> names = new List<string>();
            foreach (CEnemyTemplate enemy in enemies)
            {
                names.Add(enemy.Name);
            }
            return names;
        }
        public CEnemyTemplate GetEnemyByName(string name)
        {
            foreach (CEnemyTemplate enemy in enemies)
            {
                if (enemy.Name == name)
                    return enemy;
            }

            return null;
        }
        public CEnemyTemplate GetEnemyByIndex(int id)
        {
            if (id < 0 || id >= enemies.Count)
                return null;

            return enemies[id];
        }
        public void DeleteEnemyByIndex(int id)
        {
            if (id < 0 || id >= enemies.Count)
                return;

            enemies.RemoveAt(id);
        }
        public void DeleteEnemyByName(string name)
        {
            CEnemyTemplate found = GetEnemyByName(name);

            if (found != null)
            {
                enemies.Remove(found);
            }
        }
        public void SaveToJson(string path)
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(enemies);
            System.IO.File.WriteAllText(path, jsonString);
        }
        public void LoadFromJson(string path)
        {
            enemies.Clear();
            string jsonFromFile = File.ReadAllText(path);

            using JsonDocument doc = JsonDocument.Parse(jsonFromFile);

            foreach (JsonElement element in doc.RootElement.EnumerateArray())
            {
                string name = element.GetProperty("Name").GetString();
                string iconName = element.GetProperty("IconName").GetString();
                int baseLife = element.GetProperty("BaseLife").GetInt32();
                double lifeModifier = element.GetProperty("LifeModifier").GetDouble();
                int baseGold = element.GetProperty("BaseGold").GetInt32();
                double goldModifier = element.GetProperty("GoldModifier").GetDouble();
                double spawnChance = element.GetProperty("SpawnChance").GetDouble();

                enemies.Add(new CEnemyTemplate(
                    name, iconName, baseLife,
                    lifeModifier, baseGold, goldModifier, spawnChance));
            }
        }
    }
}