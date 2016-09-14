using UnityEngine;

public class CutDestroy : MonoBehaviour
{
    public float aTime;

    // Use this for initialization
    private void Start()
    {
        Destroy(gameObject, aTime * 10);
    }
}