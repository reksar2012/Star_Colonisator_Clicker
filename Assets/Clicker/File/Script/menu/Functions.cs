using UnityEngine;
using UnityEngine.SceneManagement;

public class Functions : MonoBehaviour
{
    public void FStart()
    {
        PlayerPrefs.SetString("NextLevel", "Game");
        SceneManager.LoadScene("Load");
    }

    public void FEnable(GameObject obj)
    {
        if (obj.activeSelf == false)
        { obj.SetActive(true); }
        else
        { obj.SetActive(false); }
    }

    public void FDisenable(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void FClose()
    {
        Application.Quit();
    }

    public void FPress(GameObject obj)
    {
        obj.GetComponent<Animator>().SetTrigger("Set");
    }
}