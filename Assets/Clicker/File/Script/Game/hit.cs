using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hit : MonoBehaviour, IPointerDownHandler
{
    private static GameObject HERO;
    public GameObject cut;
    public GameObject TextValue;

    private void Start()
    {
        HERO = GameObject.Find("Hero");
        if (!PlayerPrefs.HasKey("Damage")) PlayerPrefs.SetInt("Damage", 10);
        if (!PlayerPrefs.HasKey("CriticalChance")) PlayerPrefs.SetInt("CriticalChance", 0);
        if (!PlayerPrefs.HasKey("Speed")) { PlayerPrefs.SetInt("Speed", 1); }
    }

    private void OnMouseDown()
    {
        HERO.GetComponent<Animator>().SetTrigger("Fire");
        GetComponent<Animator>().SetTrigger("Hit");
        if (PlayerPrefs.GetInt("CriticalChance") > UnityEngine.Random.Range(0, 100))
            GetComponent<health>().GetHit(2 * PlayerPrefs.GetInt("Speed") * PlayerPrefs.GetInt("Damage"));
        else
            GetComponent<health>().GetHit(PlayerPrefs.GetInt("Speed") * PlayerPrefs.GetInt("Damage"));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        var a = eventData.pointerPressRaycast.worldPosition;
        a.z = -6;
        Instantiate(cut, a, Quaternion.Euler(new Vector3(0, 0, UnityEngine.Random.Range(0, 180))));
        GameObject txt = Instantiate(TextValue, a, Quaternion.identity) as GameObject;
        if (PlayerPrefs.GetInt("CriticalChance") > UnityEngine.Random.Range(0, 100))
            txt.GetComponentInChildren<Text>().text = "-" + (2 * PlayerPrefs.GetInt("Speed") * PlayerPrefs.GetInt("Damage")).ToString();
        else
            txt.GetComponentInChildren<Text>().text = "-" + (PlayerPrefs.GetInt("Speed") * PlayerPrefs.GetInt("Damage")).ToString();
    }
}