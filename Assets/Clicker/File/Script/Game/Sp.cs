using UnityEngine;

public class Sp : MonoBehaviour
{
    public void MonsterAnimationTrue()
    {
        if (GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster() != null)
            GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster().GetComponent<Animator>().SetBool("BigHit", true);
    }

    public void MonsterAnimationFalse()
    {
        if (GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster() != null)
            GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster().GetComponent<Animator>().SetBool("BigHit", false);
    }
}