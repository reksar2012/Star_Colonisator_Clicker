using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] Music;
    public AudioClip Shoot;
    public AudioClip Click;

    public void shoot()
    {
        GameObject Hero = GameObject.Find("Hero");

        Hero.GetComponent<AudioSource>().PlayOneShot(Shoot, Camera.main.GetComponent<SoundManager>().GetValue("Shoot"));
    }

    public void Monster()
    {
        GetComponent<AudioSource>().PlayOneShot(Music[Random.Range(0, Music.Length)], Camera.main.GetComponent<SoundManager>().GetValue("DamageMonster"));
    }

    public void SoundButton()
    {
        GetComponent<AudioSource>().PlayOneShot(Click, Camera.main.GetComponent<SoundManager>().GetValue("Button"));
    }
}