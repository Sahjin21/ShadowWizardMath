namespace ShadowWizardMath.Models
{
    public class Level
    {
        public int Stage { get; set; }
        public Player Player { get; set; }
        public List<Enemy> Enemies { get; set; }

        public Level()
        {
            Enemies = new List<Enemy>();
        }
    }
}
