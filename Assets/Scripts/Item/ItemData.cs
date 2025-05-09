using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData 
{
    public int skin;
    public int value;
    public int position;
    public int type;
}

[System.Serializable]
public class ItemDataList
{
    public ItemData[] items;
}

