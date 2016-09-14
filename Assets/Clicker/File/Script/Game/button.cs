using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject Shop, Setting;

    private GameObject obj, sp;
    public bool pressed = false;
    public AudioClip press;
    public AudioClip[] spSound = new AudioClip[3];
    private float dtime1, dtime2, dtime3;

    private void Start()
    {
        sp = GameObject.Find("sp");
        dtime1 = 0;
        dtime2 = 0;
        dtime3 = 0;
    }

    private void FixedUpdate()
    {
        obj = GameObject.Find("CreateMonster");
        obj = obj.GetComponent<GenerateMonster>().GetMonster();

        dtime2 += 1 * Time.deltaTime;
        dtime3 += 1 * Time.deltaTime;
        switch (gameObject.name)
        {
            case "Power1":
                {
                    if (pressed && dtime1 < 1)
                    {
                        dtime1 += 1 * Time.deltaTime;
                    }
                    else
                    {
                        pressed = !pressed;
                    }
                }
                break;

            case "Power2":
                {
                    if (pressed && dtime2 < 4)
                    {
                        dtime2 += 1 * Time.deltaTime;
                    }
                    else
                    {
                        pressed = !pressed;
                    }
                }
                break;

            case "Power3":
                {
                    if (pressed && dtime3 < 9)
                    {
                        dtime3 += 1 * Time.deltaTime;
                    }
                    else
                    {
                        pressed = !pressed;
                    }
                }
                break;
        }
    }

    public void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "ShopButton":
                {
                    Camera.main.GetComponentInChildren<AudioSource>().PlayOneShot(press, Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Button")));
                    GameObject a = GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster();
                    a.GetComponent<BoxCollider2D>().enabled = false;
                    a.GetComponent<Rigidbody2D>().isKinematic = true;
                    Instantiate(Shop, transform.position, Quaternion.identity);
                }
                break;

            case "Setting":
                {
                    Camera.main.GetComponentInChildren<AudioSource>().PlayOneShot(press, Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Button")));
                    GameObject a = GameObject.Find("CreateMonster").GetComponent<GenerateMonster>().GetMonster();
                    a.GetComponent<BoxCollider2D>().enabled = false;
                    a.GetComponent<Rigidbody2D>().isKinematic = true;
                    Instantiate(Setting, transform.position, Quaternion.identity);
                }
                break;

            case "Power1":
                {
                    Camera.main.GetComponentInChildren<AudioSource>().PlayOneShot(press, Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Button")));
                    sp.GetComponent<AudioSource>().PlayOneShot(spSound[0], Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Skill")));
                    sp.GetComponent<Animator>().SetTrigger("Air bang");
                    obj.GetComponent<health>().GetHit((int)(obj.GetComponent<health>().MaxHealth * 0.2));
                    pressed = true;
                    dtime1 = 0;
                }
                break;

            case "Power2":
                {
                    Camera.main.GetComponentInChildren<AudioSource>().PlayOneShot(press, Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Button")));
                    sp.GetComponent<AudioSource>().PlayOneShot(spSound[1], Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Skill")));
                    sp.GetComponent<Animator>().SetTrigger("Energetic bang");
                    obj.GetComponent<health>().GetHit((int)(obj.GetComponent<health>().MaxHealth * 0.3));
                    pressed = true;
                    dtime2 = 0;
                }
                break;

            case "Power3":
                {
                    Camera.main.GetComponentInChildren<AudioSource>().PlayOneShot(press, Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Button")));
                    sp.GetComponent<AudioSource>().PlayOneShot(spSound[2], Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("Skill")));
                    sp.GetComponent<Animator>().SetTrigger("Super bang");
                    obj.GetComponent<health>().GetHit((int)(obj.GetComponent<health>().MaxHealth * 0.4));
                    pressed = true;
                    dtime3 = 0;
                }
                break;
        }
    }
}