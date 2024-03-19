using StrategyGameDemo.Enums.CharacterEnums;

namespace StrategyGameDemo.Models.Models;

public class NeedsModel
{
    //Set inside of the model...
    public float Health { get; private set; }
    public float Pain { get; set; }
    public bool Bleeding { get; set; }
    //TODO consider new class?
    public bool Fracture { get; set; }
    public int FractureCount { get; set; }
    public List<FracturesEnum> FracturedParts { get; set; }
    public TemperatureAffectionLevelEnum? OverHeating { get; set; }
    public TemperatureAffectionLevelEnum? Hypothermia { get; set; }
    //Needds 2 electricBoogaloo
    public float Morale { get; set; }
    public float Hunger { get; set; }
    public float Thirst { get; set; }
    //Zmęczenie i Sen... 
    public float Tiredness { get; set; }
    public float Temperature { get; set; }
}