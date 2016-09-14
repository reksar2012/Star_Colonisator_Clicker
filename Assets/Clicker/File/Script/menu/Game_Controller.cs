using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public RectTransform panel;
    public Button[] bttn;
    public RectTransform center;
    private float[] distance;
    private bool dragging = false;
    private int bttnDistance;
    private int minButtonNum;

    private void Start()
    {
        int bttnLenght = bttn.Length;
        distance = new float[bttnLenght];

        bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);
    }

    private void Update()
    {
        for (int i = 0; i < bttn.Length; i++)
        {
            distance[i] = Mathf.Abs(center.transform.position.x - bttn[i].transform.position.x);
        }
        float minDistance = Mathf.Min(distance);
        for (int i = 0; i < bttn.Length; i++)
        {
            if (minDistance == distance[i]) { minButtonNum = i; }
        }
        if (!dragging) LerpToBttn(minButtonNum * -bttnDistance);
    }

    private void LerpToBttn(int position)
    {
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.deltaTime * 2.5f);
        Vector2 newPosition = new Vector2(newX, panel.anchoredPosition.y);
        panel.anchoredPosition = newPosition;
    }

    public void StartDrag()
    {
        dragging = true;
    }

    public void EndDrag()
    {
        dragging = false;
    }
}