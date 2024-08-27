public class CCharacter
{
    public string characterName;
    public CSkillset skillset;
    public int hunger;
    public int energy;
    public CCharacter(string characterName, int hunger=0, int energy=0)
    {
        this.characterName = characterName;
        this.hunger = hunger;
        this.energy = energy;
    }
    
}

