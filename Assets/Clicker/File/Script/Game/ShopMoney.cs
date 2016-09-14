using UnityEngine;
using UnityEngine.UI;

public class ShopMoney : MonoBehaviour
{
    public Text text1;
    private GameObject score;

    private void FixedUpdate()
    {
        setValue();
    }

    public void setValue()
    {
        if (!PlayerPrefs.HasKey("countCoinGold")) { PlayerPrefs.SetInt("countCoinGold", 0); }
        if (!PlayerPrefs.HasKey("countCoinSilver")) { PlayerPrefs.SetInt("countCoinSilver", 0); }
        if (!PlayerPrefs.HasKey("countCoinBronze")) { PlayerPrefs.SetInt("countCoinBronze", 0); }

        switch (gameObject.name)
        {
            case "GoldText": { text1.text = (score.GetComponent<Score>().GetGold()).ToString(); } break;
            case "SilverText": { text1.text = (score.GetComponent<Score>().GetSilver()).ToString(); } break;
            case "BronzeText": { text1.text = (score.GetComponent<Score>().GetBronze()).ToString(); } break;
        }
    }

    private void OnEnable()
    {
        score = GameObject.Find("Score");
    }
}