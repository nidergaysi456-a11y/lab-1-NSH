using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_1 { 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class CEnemyTemplate
    {
        //Свойства класса — доступны для чтения снаружи,
        //изменяются только изнутри класса (через конструктор)
        public string Name { get; private set; }
        public string IconName { get; private set; }
        public int BaseLife { get; private set; }
        public double LifeModifier { get; private set; }
        public int BaseGold { get; private set; }
        public double GoldModifier { get; private set; }
        public double SpawnChance { get; private set; }
        //Конструктор класса
        public CEnemyTemplate(string name, string iconName, int baseLife,
        double lifeModifier, int baseGold,
        double goldModifier, double spawnChance)
        {
            Name = name;
            IconName = iconName;
            BaseLife = baseLife;
            LifeModifier = lifeModifier;
            BaseGold = baseGold;
            GoldModifier = goldModifier;
            SpawnChance = spawnChance;
        }
    }
}