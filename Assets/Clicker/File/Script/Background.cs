using UnityEngine;

public class Background : MonoBehaviour
{
    public AudioClip TeckClip;
    public AudioClip[] Sound;
    private int index;

    private void Start()
    {
        index = Random.Range(0, Sound.Length);
        TeckClip = Sound[index];
        GetComponent<AudioSource>().PlayOneShot(TeckClip, Camera.main.GetComponent<SoundManager>().GetValue("BackgroundMusic"));
    }

    private void FixedUpdate()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            index++;
            if (index < Sound.Length) { TeckClip = Sound[index]; } else { index = 0; TeckClip = Sound[index]; }
            GetComponent<AudioSource>().PlayOneShot(TeckClip, Camera.main.GetComponent<SoundManager>().GetValue("BackgroundMusic"));
        }
    }
}