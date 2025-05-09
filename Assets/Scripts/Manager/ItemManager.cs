using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject healItemPrefab;
    public GameObject SpeedUpPrefab;
    public GameObject SpeedDownPrefab;

    public TextAsset jsonFile;

    void Start()
    {
        string json = jsonFile.text;
        MapData mapData = JsonUtility.FromJson<MapData>(json);

        SpawnItems(mapData.Coin, coinPrefab);
        SpawnItems(mapData.Heal, healItemPrefab);
        SpawnItems(mapData.SpeedUp, SpeedUpPrefab);
        SpawnItems(mapData.SpeedDown, SpeedDownPrefab);
    }

    private void SpawnItems<T>(List<T> items, GameObject prefab) where T : IItemData
    {
        foreach (var item in items)
        {
            // 아이템의 위치를 기반으로 생성
            Vector3 position = new Vector3(item.Position, 0, 0);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
