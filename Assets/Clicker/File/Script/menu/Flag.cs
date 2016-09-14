using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Flag : MonoBehaviour
{
    public bool Selected;

    // Use this for initialization
    private void Start()
    {
        string sl = PlayerPrefs.GetString("LLanguage");
        GameObject[] a = GameObject.FindGameObjectsWithTag("Flag");
        foreach (GameObject obj in a)
        {
            if (obj.name == sl)
            {
                obj.GetComponent<Flag>().Selected = true;
                obj.GetComponent<Image>().color = Color.yellow;
            }
            else obj.GetComponent<Flag>().Selected = false;
        }
    }

    public void Click(GameObject obj)
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag("Flag");
        foreach (GameObject fobj in a)
        {
            if (fobj == obj)
            {
                fobj.GetComponent<Flag>().Selected = true;
                fobj.GetComponent<Image>().color = Color.yellow;
            }
            else
            {
                fobj.GetComponent<Flag>().Selected = false;
                fobj.GetComponent<Image>().color = Color.white;
            }
        }
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

    public void Apply()
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag("Flag");
        foreach (GameObject obj in a)
        {
            if (obj.GetComponent<Flag>().Selected)
            {
                PlayerPrefs.SetString("LLanguage", obj.name);
            }
        }
        Scene sc = SceneManager.GetActiveScene();

        if (sc.name == "Main Menue")
            PlayerPrefs.SetString("NextLevel", "Main Menue");
        if (sc.name == "Game")
            PlayerPrefs.SetString("NextLevel", "Game");
        SceneManager.LoadScene("Load");
    }
}