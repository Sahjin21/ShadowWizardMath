namespace ShadowWizardMath.Models
{
    public class Enemy
    {
    public string name { get; set; }
        public int level { get; set; }
        public int hp { get; set; }
        public string sprite { get; set; }
    }

    public class Root
    {
        public Enemy enemies { get; set; }
    }
}