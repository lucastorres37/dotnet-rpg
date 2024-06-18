namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";	// Default value
        public int HitPoints { get; set; } = 100;   // Default value
        public int Strength { get; set; } = 10;     // Default value
        public int Defense { get; set; } = 10;      // Default value
        public int Intelligence { get; set; } = 10; // Default value
        public RpgClass Class { get; set; } = RpgClass.Knight; // Default value 
    }
}