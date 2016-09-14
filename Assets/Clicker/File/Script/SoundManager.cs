using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Range(0, 1)]
    private float All;

    [Range(0, 1)]
    private float Button;

    [Range(0, 1)]
    private float DamageMonster;

    [Range(0, 1)]
    private float DamageHero;

    [Range(0, 1)]
    private float Shoot;

    [Range(0, 1)]
    private float GetCoin;

    [Range(0, 1)]
    private float Skill;

    [Range(0, 1)]
    private float BackgroundMusic;

    public void SetValue(string Key, float value)
    {
        switch (Key)
        {
            case "All": { PlayerPrefs.SetFloat("All", value); All = value; } break;
            case "Button": { PlayerPrefs.SetFloat("Button", value); Button = value; } break;
            case "DamageMonster": { PlayerPrefs.SetFloat("DamageMonster", value); DamageMonster = value; } break;
            case "DamageHero": { PlayerPrefs.SetFloat("DamageHero", value); DamageHero = value; } break;
            case "Shoot": { PlayerPrefs.SetFloat("Shoot", value); Shoot = value; } break;
            case "GetCoin": { PlayerPrefs.SetFloat("GetCoin", value); GetCoin = value; } break;
            case "Skill": { PlayerPrefs.SetFloat("Skill", value); Skill = value; } break;
            case "BackgroundMusic": { PlayerPrefs.SetFloat("BackgroundMusic", value); BackgroundMusic = value; } break;
        }
    }

    public float GetValue(string Key)
    {
        switch (Key)
        {
            case "All": { return PlayerPrefs.GetFloat("All"); } break;
            case "Button": { return LevelSound(PlayerPrefs.GetFloat("Button")); } break;
            case "DamageMonster": { return LevelSound(PlayerPrefs.GetFloat("DamageMonster")); } break;
            case "DamageHero": { return LevelSound(PlayerPrefs.GetFloat("DamageHero")); } break;
            case "Shoot": { return LevelSound(PlayerPrefs.GetFloat("Shoot")); } break;
            case "GetCoin": { return LevelSound(PlayerPrefs.GetFloat("GetCoin")); } break;
            case "Skill": { return LevelSound(PlayerPrefs.GetFloat("Skill")); } break;
            case "BackgroundMusic": { return LevelSound(PlayerPrefs.GetFloat("BackgroundMusic")); } break;
        }
        return 0;
    }

    public void SetValue(float value)
    {
        All = value;
    }

    public float LevelSound(float max_level)
    {
        return All * max_level;
    }

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("All")) { SetValue("All", 1); } else { All = GetValue("All"); }
        if (!PlayerPrefs.HasKey("Button")) { SetValue("Button", 0.2f); } else { Button = GetValue("Button"); }
        if (!PlayerPrefs.HasKey("DamageMonster")) { SetValue("DamageMonster", 0.2f); } else { DamageMonster = GetValue("DamageMonster"); }
        if (!PlayerPrefs.HasKey("DamageHero")) { SetValue("DamageHero", 0.2f); } else { DamageHero = GetValue("DamageHero"); }
        if (!PlayerPrefs.HasKey("Shoot")) { SetValue("Shoot", 0.2f); } else { Shoot = GetValue("Shoot"); }
        if (!PlayerPrefs.HasKey("GetCoin")) { SetValue("GetCoin", 0.2f); } else { GetCoin = GetValue("GetCoin"); }
        if (!PlayerPrefs.HasKey("Skill")) { SetValue("Skill", 0.2f); } else { Skill = GetValue("Skill"); }
        if (!PlayerPrefs.HasKey("BackgroundMusic")) { SetValue("BackgroundMusic", 1); } else { BackgroundMusic = GetValue("BackgroundMusic"); }
    }
}