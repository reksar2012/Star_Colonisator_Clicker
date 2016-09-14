using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingSound : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject[] mas = GameObject.FindGameObjectsWithTag("Music");
        foreach (GameObject obj in mas)
        {
            obj.GetComponentInChildren<Slider>().value = PlayerPrefs.GetFloat(obj.name);
        }
    }

    public void Apply()
    {
        GameObject[] mas = GameObject.FindGameObjectsWithTag("Music");
        foreach (GameObject obj in mas)
        {
            PlayerPrefs.SetFloat(obj.name, obj.GetComponentInChildren<Slider>().value);
        }
        Scene a = SceneManager.GetActiveScene();

        if (a.name == "Main Menue")
            PlayerPrefs.SetString("NextLevel", "Main Menue");
        if (a.name == "Game")
            PlayerPrefs.SetString("NextLevel", "Game");
        SceneManager.LoadScene("Load");
    }

    public void cancle()
    {
        Scene a = SceneManager.GetActiveScene();

        if (a.name == "Main Menue")
            PlayerPrefs.SetString("NextLevel", "Main Menue");
        if (a.name == "Game")
            PlayerPrefs.SetString("NextLevel", "Game");
        SceneManager.LoadScene("Load");
    }
}