using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ItemManager : MonoBehaviour
{
    private static ItemManager instance;

    public static ItemManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ItemManager>();

                if (instance == null)
                {
                    GameObject obj = new GameObject("ItemManager");
                    instance = obj.AddComponent<ItemManager>();
                }
            }
            return instance;
        }
    }

    public List<ItemStats> items;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        LoadItemsFromCSV("Assets/CSV/ItemData.csv");
        // 디버그 로그를 통해 리스트 확인
        DebugItems();
    }
    void LoadItemsFromCSV(string filePath)
    {
        items = new List<ItemStats>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    int index = int.Parse(line[0]);
                    string itemName = line[1];
                    int itemValue = int.Parse(line[2]);
                    int itemQuantity = int.Parse(line[3]);
                    int damage = int.Parse(line[4]);
                    int defense = int.Parse(line[5]);
                    int healthBonus = int.Parse(line[6]);
                    ItemStats.ItemType itemType = (ItemStats.ItemType)System.Enum.Parse(typeof(ItemStats.ItemType), line[7]);
                    Sprite itemIcon = Resources.Load("ItemIcon/" + index.ToString(), typeof(Sprite)) as Sprite;
                    ItemStats newItem = new ItemStats(index, itemName, itemValue, itemQuantity, damage, defense, healthBonus, itemType, itemIcon);
                    items.Add(newItem);
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("CSV 파일 읽기 오류: " + e.Message);
        }
    }

    void DebugItems()
    {
        foreach (ItemStats item in items)
        {
            Debug.Log($"Item Index: {item.index}, Name: {item.itemName}, Type: {item.itemType}, Icon: {item.itemIcon?.name}");
        }
    }
}
