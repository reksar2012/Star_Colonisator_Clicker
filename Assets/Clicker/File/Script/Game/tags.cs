using UnityEngine;

public class tags : MonoBehaviour
{
    private void Awake()
    {
        switch (gameObject.name)
        {
            case "Gold": case "Silver": case "Bronze": { gameObject.tag = "Money"; } break;
            case "DamageStat": case "CriticalChanseStat": case "SpeedStat": { gameObject.tag = "Stat"; } break;
        }
    }
}