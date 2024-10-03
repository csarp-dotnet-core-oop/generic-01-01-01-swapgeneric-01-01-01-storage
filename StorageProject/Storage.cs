using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StorageProject
{
    public class Storage<Type>
    {
        // Egyetlen adat tárolása
        private Type _data;

        // Konstruktor az adat beállításához
        public Storage(Type data)
        {
            _data = data;
        }

        // Adat lekérdezése
        public Type GetData()
        {
            return _data;
        }

        // Adat beállítása
        public void SetData(Type data)
        {
            _data = data;
        }

        // Adat kiírása
        public override string ToString()
        {
            return $"Tárolt adat: {_data}";
        }
    }
}
