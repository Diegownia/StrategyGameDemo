using StrategyGameDemo.Enums.CharacterEnums;

namespace StrategyGameDemo.BaseModels;

public abstract class CharacterBaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public NationalityEnum Nationality { get; set; }
    public RaceEnum Race { get; set; }
    //TODO how to express that value in inches and other shit...
    public decimal Height { get; set; }
    public float Weight { get; set; }
    public EyeColourEnum EyeColour { get; set; }
    public HairColourEnum HairColour { get; set; }
}