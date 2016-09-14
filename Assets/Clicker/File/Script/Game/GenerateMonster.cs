using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GenerateMonster : MonoBehaviour
{
    // Use this for initialization
    public GameObject Player;

    public GameObject[] MonstersPrefabs;
    private GameObject Monster;
    public Slider health;
    private int Maxhealth = 100;

    public bool generate = true;

    public float WaitTime;

    public Transform StartPosition;

    // Update is called once per frame
    private void Start()
    {
        NewMonster();
    }

    public void Generator()
    {
        if (generate)
        {
            generate = false;
            StartCoroutine(wait());
        }
    }

    public void NewMonster()
    {
        if (PlayerPrefs.HasKey("Monster health") && Maxhealth < PlayerPrefs.GetInt("Monster health")) { Maxhealth = PlayerPrefs.GetInt("Monster health"); }
        Player.GetComponent<Animator>().SetTrigger("Walk");
        health.value = 1f;
        Monster = Instantiate(MonstersPrefabs[Random.Range(0, MonstersPrefabs.Length)], StartPosition.position, Quaternion.identity) as GameObject;
        Monster.GetComponent<health>().HealthSlider = health;
        Monster.GetComponent<health>().MaxHealth = Maxhealth;
        if (PlayerPrefs.HasKey("Monster health"))
        {
            Maxhealth = (int)(Maxhealth * 1.3);
            PlayerPrefs.SetInt("Monster health", Maxhealth);
        }
        else
        {
            PlayerPrefs.SetInt("Monster health", 100);
            Maxhealth = 100;
        }
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(WaitTime);
        NewMonster();
    }

    public GameObject GetMonster()
    {
        return Monster;
    }
}