using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject[] Health;
    public Sprite No_Damage;
    public Sprite Damage;
    public bool update = true;
    public GameObject End;
    private int countHearts;

    private void Start()
    { update = true; }

    private void Update()
    {
        if (Check_no_health() && update)
        {
            Instantiate(End, transform.position, Quaternion.identity);
            update = !update;
        };
    }

    private bool Check_no_health()
    {
        foreach (GameObject Obj in Health)
        {
            if (Obj.GetComponent<Image>().sprite == No_Damage) return false;
        }
        return true;
    }

    public int col_Hearts()
    {
        int count = 0;
        foreach (GameObject Obj in Health) if (Obj.GetComponent<Image>().sprite == No_Damage) ++count;
        return count;
    }

    public void add_Hearts(int i = 1)
    {
        foreach (GameObject Heart in Health)
            if (Heart.GetComponent<Image>().sprite == Damage && i > 0)
            {
                Heart.GetComponent<Image>().sprite = No_Damage;
                i--;
            }
    }

    public void minus_Hearts(int i = 1)
    {
        foreach (GameObject Heart in Health)
            if (Heart.GetComponent<Image>().sprite == No_Damage && i > 0)
            {
                Heart.GetComponent<Image>().sprite = Damage;
                i--;
            }
        if (Check_no_health() && update)
        {
            Instantiate(End, transform.position, Quaternion.identity);
            update = !update;
        };
    }
}