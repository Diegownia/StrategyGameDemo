using StrategyGameDemo.BaseModels;

namespace StrategyGameDemo.Models.Models;

public class HeroModel : CharacterBaseModel
{
    public List<HeroModel> Family { get; set; }
    public NeedsModel Needs { get; set; }
    public ExperienceModel Experience { get; set; }
}