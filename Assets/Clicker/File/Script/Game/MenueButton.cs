using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueButton : MonoBehaviour
{
    public void close(GameObject obj)
    {
        Time.timeScale = 1;
        GameObject a = GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster();
        a.GetComponent<BoxCollider2D>().enabled = true;
        a.GetComponent<Rigidbody2D>().isKinematic = false;
        Destroy(obj);
    }

    public void Press2()
    {
        if (gameObject.name == "Damage" || gameObject.name == "CriticalChanse" || gameObject.name == "Speed")
        {
            GameObject[] objs;
            GameObject a = GameObject.Find(gameObject.name + "Stat");
            a.GetComponent<Animator>().SetTrigger("Update");
            objs = GameObject.FindGameObjectsWithTag("Money");
            foreach (GameObject obj in objs)
            {
                obj.GetComponent<Animator>().SetTrigger("buy");
            }
            if (gameObject.GetComponentInChildren<CoastScript>().canBuy()) gameObject.GetComponentInChildren<CoastScript>().Buy();
        }
        else return;
    }

    public void Press(string s)
    {
        GameObject a = GameObject.Find(s);
        if ((a.name == "Damage" || a.name == "CriticalChanse" || a.name == "Speed") && a.GetComponentInChildren<CoastScript>().canBuy())
        {
            a.GetComponent<AudioSource>().Play();
            a.GetComponent<Animator>().SetTrigger("Press");
        }
        else
            if (!(a.name == "Damage" || a.name == "CriticalChanse" || a.name == "Speed"))
        {
            a.GetComponent<AudioSource>().Play();
            a.GetComponent<Animator>().SetTrigger("Press");
        }
    }

    public void Next(GameObject A)
    {
        if (A.activeSelf == false) { A.SetActive(true); }
        else
        {
            A.SetActive(false);
        }
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

    public void Main_Menue()
    {
        PlayerPrefs.SetString("NextLevel", "Main Menue");
        SceneManager.LoadScene("Load");
    }
}