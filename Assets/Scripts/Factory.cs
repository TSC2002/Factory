using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private Skill[] skills;
    private Dictionary<string, Skill> skillsByName;


    // Start is called before the first frame update
    private void Awake()
    {
        skillsByName = new Dictionary<string, Skill>();

        foreach (var skill in skills)
        {
            skillsByName.Add(skill.skillName, skill);
        }
    }

    public Skill CreateSkill(string skillName, Transform playerTransform)
    {
        if (skillsByName.TryGetValue(skillName, out Skill skillPrefab))
        {
            Skill Heal = Instantiate(skillPrefab, playerTransform.position,
            Quaternion.identity);
            return Heal;
        }
        else
        {
            Debug.LogWarning($"La habilidad '{skillName}'no existe en la base de datos de habilidades");
            return null;
        }
    }
}
