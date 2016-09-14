using UnityEngine;
using UnityEngine.UI;

public class Localisation : MonoBehaviour
{
    public Text t;
    public string str;

    private void Start()
    {
        if (PlayerPrefs.HasKey("LLanguage"))
            t.text = Camera.main.GetComponent<LocalizationManager>().GetWord(PlayerPrefs.GetString("LLanguage"), str);
        else
        {
            t.text = Camera.main.GetComponent<LocalizationManager>().GetWord("EN", str);
        }
    }
}