using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class IceCreamScript : MonoBehaviour
{
    public bool isRegular;
    public bool isGold;
    public Tile pointTile;
   // public GameObject tilemapPointTile;
    public int iceCreamCount;
    public int goldCount;

    public GameObject tilemapCoin;
    public Tilemap tilemap;

    public Generator gen;

    Tilemap coinTM;
    // Start is called before the first frame update
    void Start()
    {
        gen = FindObjectOfType<Generator>();
        PlayerPrefs.SetInt("IceCream", 0);
        iceCreamCount = 0;

        if (isRegular)
        {
            PlayerPrefs.SetInt("IceCream", 0);
            iceCreamCount = 0;
        }
        if (isGold)
        {
            PlayerPrefs.SetInt("Gold", 0);
            goldCount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    Debug.Log(col.collider.tag);

    //    Debug.Log(col.gameObject.name);
    //    Vector3Int hitPos = Vector3Int.zero;
    //    if (tilemapPointTile == col.gameObject)
    //    {
    //        foreach (ContactPoint2D hit in col.contacts)
    //        {
    //            hitPos.x = (int) hit.point.x;
    //            hitPos.y = (int) hit.point.y;
    //            coinTM.SetTile(coinTM.WorldToCell(hitPos), null);
    //            iceCreamCount++;
    //        } 
    //    }
    //    //if (isRegular)
    //    //{
    //    //    iceCreamCount += 1;
    //    //    PlayerPrefs.SetInt("IceCream", iceCreamCount);
    //    //    Destroy(pointTile);
    //    //}
    //    //if (isGold)
    //    //{
    //    //    goldCount += 1;
    //    //    PlayerPrefs.SetInt("Gold", goldCount);
    //    //    Destroy(pointTile);
    //    //} Once coins destroy implement this
    //}

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.LogWarning(col.gameObject.tag);
        if (col.gameObject.tag == "coin")
        {
            Debug.LogWarning("coin should Snatch");
            Vector3Int hitPos = Vector3Int.zero;
            Debug.LogWarning(hitPos);
            foreach (ContactPoint2D hit in col.contacts)
            {
                Debug.LogWarning(hit);
                hitPos.x = (int)hit.point.x;

                hitPos.y = (int)hit.point.y;
                Debug.LogWarning(hitPos);
                //tilemap.SetTile(tilemap.WorldToCell(hitPos), null);
                //Vector3Int wrld = tilemap.WorldToCell(hitPos);
                //wrld.z = 0;
                //gen.DeleteBlock(hitPos);
                tilemap.SetTile(hitPos, null);
                Debug.LogWarning(hitPos);
                hitPos = Vector3Int.zero;
                iceCreamCount++;
                //Destroy(col.gameObject);
                PlayerPrefs.SetInt("IceCream", iceCreamCount);
            }
        }
    }
}
