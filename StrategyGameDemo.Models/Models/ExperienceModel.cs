namespace StrategyGameDemo.Models.Models;

public class ExperienceModel
{
    public float LearningSpeed { get; set; }
    public int HealthPoints { get; set; }
    public int StaminaPoints { get; set; }
    public float MovingSpeed { get; set; }
    public int Strength { get; set; }
    public int Accuracy { get; set; }
    public int ReloadSpeed { get; set; }
    public CommandingModel Commanding { get; set; }
}