using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject healItemPrefab;
    public GameObject SpeedPrefab;

    public TextAsset jsonFile;

    public void CreateItem(ItemData data)
    {
        GameObject prefeb = null;

        switch (data.type)
        {   
            
        }
    }
}
