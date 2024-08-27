using System.Collections.Generic;

public class CAction
{
    public CAction() 
    {

    }
    public string CActionName { get; set; }  // e.g. 'Fishing', 'Building Shelter', etc.
    public bool enabled = false; // Unless something enables this action, it shouldn't happen.

    public List<CSkills> applicableSkillsList;



}