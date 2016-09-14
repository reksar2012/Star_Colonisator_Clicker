using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Tscore;
    private int count;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Score"))
        {
            Tscore.text = "0";
            count = 0;
            PlayerPrefs.SetInt("Score", 0);
        }
        else
        {
            count = PlayerPrefs.GetInt("Score");
            Tscore.text = count.ToString();
        }
    }

    public void FScore(int point = 1)
    {
        count += point;
        PlayerPrefs.SetInt("Score", count);
        Tscore.text = count.ToString();
    }

    public void ADDGold(int coast)
    {
        if (!PlayerPrefs.HasKey("countCoinGold")) { PlayerPrefs.SetInt("countCoinGold", coast); }
        else
            PlayerPrefs.SetInt("countCoinGold", PlayerPrefs.GetInt("countCoinGold") + coast);
    }

    public void ADDSilver(int coast)
    {
        if (!PlayerPrefs.HasKey("countCoinSilver")) { PlayerPrefs.SetInt("countCoinSilver", coast); }
        else
            PlayerPrefs.SetInt("countCoinSilver", PlayerPrefs.GetInt("countCoinSilver") + coast);
    }

    public void ADDBronze(int coast)
    {
        if (!PlayerPrefs.HasKey("countCoinBronze")) { PlayerPrefs.SetInt("countCoinBronze", coast); }
        else
            PlayerPrefs.SetInt("countCoinBronze", PlayerPrefs.GetInt("countCoinBronze") + coast);
    }

    public int GetGold()
    {
        return PlayerPrefs.GetInt("countCoinGold");
    }

    public int GetSilver()
    {
        return PlayerPrefs.GetInt("countCoinSilver");
    }

    public int GetBronze()
    {
        return PlayerPrefs.GetInt("countCoinBronze");
    }

    public int GetScore()
    {
        return count;
    }
}