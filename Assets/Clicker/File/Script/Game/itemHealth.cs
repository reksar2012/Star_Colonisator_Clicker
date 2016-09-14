using UnityEngine;

public class itemHealth : MonoBehaviour
{
    private GameObject e;
    private float Dtime;
    private bool Magnetic = false;

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.name == "ground")
        {
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            //     gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<EdgeCollider2D>().enabled = false;
        }
        if (obj.name == "Hero")
        {
            GameObject health = GameObject.Find("Hero health");

            health.GetComponent<PlayerHealth>().add_Hearts();
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

    private void Start()
    {
        Vector2 a = Vector2.left * Random.Range(-200, 200);
        gameObject.GetComponent<Rigidbody2D>().AddForce(a);
        e = GameObject.Find("Hero");
        Dtime = 0;
        Destroy(gameObject, 20f);
    }

    private void LateUpdate()
    {
        Dtime += 1 * Time.deltaTime;
        if (Dtime >= 6 || Magnetic) MagneticCoin(e.transform);
        if (transform.position.y < -30) Destroy(gameObject);
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