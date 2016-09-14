using UnityEngine;
using UnityEngine.UI;

public enum Typecoast { Damage = 0, CriticalChanse = 1, Speed = 2 };

public class CoastScript : MonoBehaviour
{
    public Sprite[] sprts = new Sprite[3];
    private int coast;
    private bool gold;
    private bool silver;
    private bool bronze;
    public Typecoast a;
    public Text field;

    private void Start()
    {
        switch (a)
        {
            case Typecoast.Damage:
                {
                    if (!PlayerPrefs.HasKey("CoastDamage"))
                    {
                        PlayerPrefs.SetInt("CoastDamage", 10);
                        PlayerPrefs.SetInt("CoastDamageTypeCoast", Random.Range(0, 3));
                        coast = 10;
                    }
                    else
                    {
                        coast = PlayerPrefs.GetInt("CoastDamage");
                        switch (PlayerPrefs.GetInt("CoastDamageTypeCoast"))
                        {
                            case 0:
                                {
                                    gold = true;
                                    silver = false;
                                    bronze = false;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[0];
                                }; break;
                            case 1:
                                {
                                    gold = false;
                                    silver = true;
                                    bronze = false;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[1];
                                }; break;
                            case 2:
                                {
                                    gold = false;
                                    silver = false;
                                    bronze = true;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                                }; break;
                            default:
                                {
                                    gold = false;
                                    silver = false;
                                    bronze = true;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                                }
                                break;
                        }
                    }
                }; break;
            case Typecoast.CriticalChanse:
                {
                    if
                        (!PlayerPrefs.HasKey("CoastCriticalChanse"))
                    {
                        PlayerPrefs.SetInt("CoastCriticalChanse", 10);
                        PlayerPrefs.SetInt("CoastCriticalChanseTypeCoast", Random.Range(0, 3));
                        coast = 10;
                    }
                    else
                    {
                        coast = PlayerPrefs.GetInt("CoastCriticalChanse");

                        switch (PlayerPrefs.GetInt("CoastCriticalChanseTypeCoast"))
                        {
                            case 0:
                                {
                                    gold = true;
                                    silver = false;
                                    bronze = false;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[0];
                                }; break;
                            case 1:
                                {
                                    gold = false;
                                    silver = true;
                                    bronze = false;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[1];
                                }; break;
                            case 2:
                                {
                                    gold = false;
                                    silver = false;
                                    bronze = true;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                                }; break;
                            default:
                                {
                                    gold = false;
                                    silver = false;
                                    bronze = true;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                                }
                                break;
                        }
                    }
                }
                break;

            case Typecoast.Speed:
                {
                    if
                        (!PlayerPrefs.HasKey("CoastSpeed"))
                    {
                        PlayerPrefs.SetInt("CoastSpeed", 10);
                        PlayerPrefs.SetInt("CoastSpeedTypeCoast", Random.Range(0, 3));
                        coast = 10;
                    }
                    else
                    {
                        coast = PlayerPrefs.GetInt("CoastSpeed");
                        switch (PlayerPrefs.GetInt("CoastSpeedTypeCoast"))
                        {
                            case 0:
                                {
                                    gold = true;
                                    silver = false;
                                    bronze = false;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[0];
                                }; break;
                            case 1:
                                {
                                    gold = false;
                                    silver = true;
                                    bronze = false;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[1];
                                }; break;
                            case 2:
                                {
                                    gold = false;
                                    silver = false;
                                    bronze = true;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                                }; break;
                            default:
                                {
                                    gold = false;
                                    silver = false;
                                    bronze = true;
                                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                                }
                                break;
                        }
                    }
                }; break;
        }

        field.text = coast.ToString();
    }

    public void setNewCoast(int count)
    {
        coast = (int)(coast * 1.5 + count * 15);
        field.text = coast.ToString();
        switch (Random.Range(0, 3))
        {
            case 0:
                {
                    gold = true;
                    silver = false;
                    bronze = false;
                    gameObject.GetComponentInChildren<Image>().sprite = sprts[0];
                    switch (a)
                    {
                        case Typecoast.Damage: { PlayerPrefs.SetInt("CoastDamageTypeCoast", 0); }; break;
                        case Typecoast.CriticalChanse: { PlayerPrefs.SetInt("CoastCriticalChanseTypeCoast", 0); }; break;
                        case Typecoast.Speed: { PlayerPrefs.SetInt("CoastSpeedTypeCoast", 0); }; break;
                    }
                }; break;
            case 1:
                {
                    gold = false;
                    silver = true;
                    bronze = false;
                    gameObject.GetComponentInChildren<Image>().sprite = sprts[1];
                    switch (a)
                    {
                        case Typecoast.Damage: { PlayerPrefs.SetInt("CoastDamageTypeCoast", 1); }; break;
                        case Typecoast.CriticalChanse: { PlayerPrefs.SetInt("CoastCriticalChanseTypeCoast", 1); }; break;
                        case Typecoast.Speed: { PlayerPrefs.SetInt("CoastSpeedTypeCoast", 1); }; break;
                    }
                }; break;
            case 2:
                {
                    gold = false;
                    silver = false;
                    bronze = true;
                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                    switch (a)
                    {
                        case Typecoast.Damage: { PlayerPrefs.SetInt("CoastDamageTypeCoast", 2); }; break;
                        case Typecoast.CriticalChanse: { PlayerPrefs.SetInt("CoastCriticalChanseTypeCoast", 2); }; break;
                        case Typecoast.Speed: { PlayerPrefs.SetInt("CoastSpeedTypeCoast", 2); }; break;
                    }
                }; break;
            default:
                {
                    gold = false;
                    silver = false;
                    bronze = true;
                    gameObject.GetComponentInChildren<Image>().sprite = sprts[2];
                    switch (a)
                    {
                        case Typecoast.Damage: { PlayerPrefs.SetInt("CoastDamageTypeCoast", 2); }; break;
                        case Typecoast.CriticalChanse: { PlayerPrefs.SetInt("CoastCriticalChanseTypeCoast", 2); }; break;
                        case Typecoast.Speed: { PlayerPrefs.SetInt("CoastSpeedTypeCoast", 2); }; break;
                    }
                }
                break;
        }
        switch (a)
        {
            case Typecoast.Damage:
                {
                    PlayerPrefs.SetInt("CoastDamage", coast);
                }
                break;

            case Typecoast.CriticalChanse:
                {
                    PlayerPrefs.SetInt("CoastCriticalChanse", coast);
                }
                break;

            case Typecoast.Speed:
                {
                    PlayerPrefs.SetInt("CoastSpeed", coast);
                }
                break;
        }
    }

    public bool canBuy()
    {
        int goldcount = GameObject.Find("Score").GetComponent<Score>().GetGold();
        int silvercount = GameObject.Find("Score").GetComponent<Score>().GetSilver();
        int bronzecount = GameObject.Find("Score").GetComponent<Score>().GetBronze();
        if (gold && goldcount >= coast) { return true; }
        if (silver && silvercount >= coast) { return true; }
        if (bronze && bronzecount >= coast) { return true; }
        return false;
    }

    public void Buy()
    {
        int count = 0;
        switch (a)
        {
            case Typecoast.Damage:
                {
                    if (!PlayerPrefs.HasKey("countDamage"))
                    {
                        PlayerPrefs.SetInt("countDamage", 1);
                        count = 1;
                    }
                    else
                        count = PlayerPrefs.GetInt("countDamage");
                }
                break;

            case Typecoast.CriticalChanse:
                {
                    if (!PlayerPrefs.HasKey("countCriticalChanse"))
                    {
                        PlayerPrefs.SetInt("countCriticalChanse", 1);
                        count = 1;
                    }
                    else
                        count = PlayerPrefs.GetInt("countCriticalChanse");
                }
                break;

            case Typecoast.Speed:
                {
                    if (!PlayerPrefs.HasKey("countSpeed"))
                    {
                        PlayerPrefs.SetInt("countSpeed", 1);
                        count = 1;
                    }
                    else
                        count = PlayerPrefs.GetInt("countSpeed");
                }
                break;
        }

        int goldcount = PlayerPrefs.GetInt("countCoinGold");
        int silvercount = PlayerPrefs.GetInt("countCoinSilver");
        int bronzecount = PlayerPrefs.GetInt("countCoinBronze");
        if (gold && goldcount >= coast)
        {
            PlayerPrefs.SetInt("countCoinGold", PlayerPrefs.GetInt("countCoinGold") - coast);
            setNewCoast(count);
        }
        if (silver && silvercount >= coast)
        {
            PlayerPrefs.SetInt("countCoinSilver", PlayerPrefs.GetInt("countCoinSilver") - coast);
            setNewCoast(count);
        }
        if (bronze && bronzecount >= coast)
        {
            PlayerPrefs.SetInt("countCoinBronze", PlayerPrefs.GetInt("countCoinBronze") - coast);
            setNewCoast(count);
        }
        switch (a)
        {
            case Typecoast.Damage:
                {
                    count++;
                    PlayerPrefs.SetInt("countDamage", count);
                    PlayerPrefs.SetInt("Damage", (PlayerPrefs.GetInt("Damage") * 0.2 < 1) ? PlayerPrefs.GetInt("Damage") + 1 : (int)(PlayerPrefs.GetInt("Damage") + PlayerPrefs.GetInt("Damage") * 0.2));
                }
                break;

            case Typecoast.CriticalChanse:
                {
                    count++;
                    PlayerPrefs.SetInt("countCriticalChanse", count);
                    PlayerPrefs.SetInt("CriticalChance", PlayerPrefs.GetInt("CriticalChance") + 1);
                }
                break;

            case Typecoast.Speed:
                {
                    count++;
                    PlayerPrefs.SetInt("countSpeed", count);
                    PlayerPrefs.SetInt("Speed", PlayerPrefs.GetInt("Speed") + 1);
                }
                break;
        }
    }
}