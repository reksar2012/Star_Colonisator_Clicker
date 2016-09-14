using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public Sprite image;
        public float coast;
        public float next;
        public float damage;
        public float count;
    }

    public Item[] ShopItem;
    public GameObject element;

    private void Start()
    {
        foreach (Item i in ShopItem)
        {
            GameObject btn = Instantiate(element) as GameObject;
            ItemsScript scp = btn.GetComponent<ItemsScript>();
            scp.name.text = i.name;
            scp.coast.text = i.coast.ToString("F1");
            // scp.thisButton.onClick.AddListener(() =>Purchase());
            btn.transform.SetParent(this.transform);
        }
    }

    private void Purchase()
    {
        Debug.Log("1");
    }
}