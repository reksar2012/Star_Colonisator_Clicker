using UnityEngine;

public class Reward : MonoBehaviour
{
    public Transform Pos;
    public GameObject[] Coins = new GameObject[3];
    public GameObject health;
    public bool generate;

    public void Generator()
    {
        if (gameObject.GetComponent<health>().Health <= 0 && generate)
        {
            generate = false;
            GenereteCoin();
        }
    }

    public void GenereteCoin()
    {
        for (int j = 0; j < 3; j++)
            for (int i = 0; i < Random.Range(0, 10); i++)
            {
                Instantiate(Coins[j], GameObject.Find("stp").transform.position, Quaternion.identity);
            }
        GameObject obj = GameObject.Find("Hero health");

        int col = obj.GetComponent<PlayerHealth>().col_Hearts();

        if (col < 5)
        {
            col = Random.Range(0, 5 - col + 1);
            for (int i = 0; i < col; i++)
            {
                Instantiate(health, GameObject.Find("stp").transform.position, Quaternion.identity);
            }
        }
    }
}