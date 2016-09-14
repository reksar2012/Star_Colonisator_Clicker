using UnityEngine;
using UnityEngine.UI;

public class StatScript : MonoBehaviour
{
    private int Damage;
    private int CriticalChance;
    private int Speed;
    public Text field;

    public int GetDamage()
    {
        return Damage;
    }

    public int GetCriticalChance()
    {
        return CriticalChance;
    }

    public int GetSpeed()
    {
        return Speed;
    }

    private void FixedUpdate()
    {
        if (!PlayerPrefs.HasKey("Damage")) { PlayerPrefs.SetInt("Damage", 10); Damage = 10; } else { Damage = PlayerPrefs.GetInt("Damage"); }
        if (!PlayerPrefs.HasKey("CriticalChance")) { PlayerPrefs.SetInt("CriticalChance", 0); CriticalChance = 0; } else { CriticalChance = PlayerPrefs.GetInt("CriticalChance"); }
        if (!PlayerPrefs.HasKey("Speed")) { PlayerPrefs.SetInt("Speed", 1); Speed = 1; } else { Speed = PlayerPrefs.GetInt("Speed"); }
        switch (gameObject.name)
        {
            case "Damage Stat Text": { field.text = Damage.ToString(); } break;
            case "Critical chanse Stat Text": { field.text = CriticalChance.ToString() + "%"; } break;
            case "Speed Stat Text": { field.text = "X" + Speed.ToString(); } break;
        }
    }
}