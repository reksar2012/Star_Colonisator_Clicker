using UnityEngine;

public class Monster : MonoBehaviour
{
    public float dTime;
    private float MaxTime = 5f;
    public AudioClip[] mas = new AudioClip[3];

    private GameObject Damage
        ;

    private void Start()
    {
        if (Damage == null)
            Damage = GameObject.Find("DamageHero");
        dTime = 0;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        dTime += 1 * Time.deltaTime;
        if (dTime > MaxTime) { GenerateAtack(); dTime -= MaxTime; }
    }

    private void GenerateAtack()
    {
        int choose = Random.Range(0, 4);
        GameObject obj = GameObject.Find("Hero health");
        switch (choose)
        {
            case 0:
                {
                    obj.GetComponent<PlayerHealth>().minus_Hearts();
                    Damage.GetComponent<AudioSource>().PlayOneShot(mas[0], Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("DamageHero")));
                    Damage.GetComponent<Animator>().SetTrigger("Light wound");
                }
                break;

            case 1:
                {
                    obj.GetComponent<PlayerHealth>().minus_Hearts(2);
                    Damage.GetComponent<AudioSource>().PlayOneShot(mas[1], Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("DamageHero")));
                    Damage.GetComponent<Animator>().SetTrigger("Medium wound");
                }
                break;

            case 2:
                {
                    obj.GetComponent<PlayerHealth>().minus_Hearts(3);
                    Damage.GetComponent<AudioSource>().PlayOneShot(mas[2], Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("DamageHero")));
                    Damage.GetComponent<Animator>().SetTrigger("Hard wound");
                }
                break;

            default: { } break;
        }
    }
}