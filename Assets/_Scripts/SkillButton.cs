using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    public int      maxSkill;
    public Text     skillNumText;
    public void SkillNumTextRedacting (int numSkill)
    {
        skillNumText.text = $"{numSkill}/{maxSkill}";
    }
}
