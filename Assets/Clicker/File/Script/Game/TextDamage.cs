using UnityEngine;

public class TextDamage : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Destroy(gameObject, 1.1f);
    }
}