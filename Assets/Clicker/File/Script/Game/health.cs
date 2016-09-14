using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;

    public Slider HealthSlider;

    // Use this for initialization
    private void Start()
    {
        Health = MaxHealth;
    }

    public void GetHit(int damage)
    {
        int health = Health - damage;
        HealthIndication(health);
        if (health <= 0)
        {
            Health = health;
            GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().generate = true;
            GameObject.Find("Score").GetComponent<Score>().FScore();
            UnityEngine.Object.Destroy(gameObject);
            gameObject.GetComponent<Reward>().GenereteCoin();
        }
        else
            Health = health;
        GetComponent<Monster>().dTime = 0;
    }

    private void OnDestroy()
    {
        if (Health <= 0) GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().Generator();
        GetComponent<Reward>().Generator();
        Destroy(gameObject);
    }

    public void HealthIndication(float health)
    {
        HealthSlider.value = health / MaxHealth;
    }
}