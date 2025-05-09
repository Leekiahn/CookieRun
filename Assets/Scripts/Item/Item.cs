using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected GroundObjectData data;
    public Item(GroundObjectData data)
    {
        this.data = data;
    }

    public GroundObjectData GetData()
    {
        return this.data;
    }
}