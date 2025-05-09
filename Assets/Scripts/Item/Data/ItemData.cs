using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MapData
{
    public List<CoinData> Coin;
    public List<HealData> Heal;
    public List<SpeedData> SpeedUp;
    public List<SpeedData> SpeedDown;
}

public interface IItemData
{
    int Position { get; }
}

[System.Serializable]
public class CoinData : IItemData
{
    public int skin;
    public float value;
    public int position;
    public int type;

    public int Position => position;
}

[System.Serializable]
public class HealData : IItemData
{
    public int skin;
    public float value;
    public int position;

    public int Position => position;
}

[System.Serializable]
public class SpeedData : IItemData
{
    public int skin;
    public float value;
    public int position;

    public int Position => position;
}

