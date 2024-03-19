namespace StrategyGameDemo.Models.Models;

public class CommandingModel
{
    private decimal _medicalSpeed;
    private decimal _repairSpeed;
    private decimal _diggingSpeed;
    
    //floats are percentage representation... 100 == boss
    //TODO what to do with weapons... (Service?)
    public float WeaponKnowledge { get; set; }
    public float MedicalKnowledge { get; set; }
    //TODO driving license
    //public float DrivingKnowledge { get; set; }
    public float RepairKnowledge { get; set; }
    public float ExplosivesKnowledge { get; set; }

    public decimal MedicalSpeed
    {
        get => _medicalSpeed;
        set => CalculateSpeed(MedicalKnowledge);
    }

    public decimal RepairSpeed
    {
        get => _repairSpeed;
        set => CalculateSpeed(RepairKnowledge);
    }

    public decimal DiggingSpeed
    {
        get => _diggingSpeed;
        set => CalculateSpeed(ExplosivesKnowledge);
    }

    private static decimal CalculateSpeed(float value)
    {
        return (decimal)value / 10;
    }
}