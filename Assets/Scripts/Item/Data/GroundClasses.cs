using System.Collections.Generic;

[System.Serializable]
public class MapDataWrap
{
    public List<MapData> MapData;
}

[System.Serializable]
public class MapData
{
    public int GroundLength;
    public List<int> GroundSkin;
    public List<GroundObjectData> GroundObjectData;
}

[System.Serializable]
public class GroundObjectData
{
    public int skin;
    public float value;
    public int position;
    public int type;
    public int Position;
}
