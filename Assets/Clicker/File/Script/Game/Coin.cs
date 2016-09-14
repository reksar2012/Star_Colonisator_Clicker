using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject e;
    private float Dtime;
    private bool Magnetic = false;
    public AudioClip sound;
    public bool gold;
    public bool silver;
    public bool bronze;
    private int coast, score;

    // Use this for initialization
    private void Start()
    {
        Vector2 a = Vector2.left * Random.Range(-200, 200);
        gameObject.GetComponent<Rigidbody2D>().AddForce(a);
        e = GameObject.Find("Image");
        score = GameObject.Find("Score").GetComponent<Score>().GetScore();
        coast = Random.Range(score / 25, score / 10);
        coast = (coast == 0) ? 1 : coast;
        Dtime = 0;
        Destroy(gameObject, 20f);
    }

    private void LateUpdate()
    {
        Dtime += 1 * Time.deltaTime;
        if (Dtime >= 6 || Magnetic) MagneticCoin(e.transform);
        if (transform.position.y < -30) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.name == "ground")
        {
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            //     gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<EdgeCollider2D>().enabled = false;
        }
        if (obj.name == "Image")
        {
            GameObject.Find("Image").GetComponent<Animator>().SetTrigger("Coin");
            GameObject f = GameObject.Find("Score");
            if (gold) f.GetComponent<Score>().ADDGold(coast);
            if (silver) f.GetComponent<Score>().ADDSilver(coast);
            if (bronze) f.GetComponent<Score>().ADDBronze(coast);
            obj.GetComponent<AudioSource>().PlayOneShot(sound, Camera.main.GetComponent<SoundManager>().LevelSound(PlayerPrefs.GetFloat("GetCoin")));
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.name == "ground")
        {
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            gameObject.GetComponent<EdgeCollider2D>().enabled = false;
        }
    }

    public void MagneticCoin(Transform EndPoint)
    {
        if (Vector3.Distance(gameObject.transform.position, EndPoint.position) < 5000)
        {
            gameObject.transform.Translate((EndPoint.position - gameObject.transform.position) * 4 * Time.deltaTime, Space.World);
        }
    }

    private void OnMouseDown()
    {
        Magnetic = true;
    }
}