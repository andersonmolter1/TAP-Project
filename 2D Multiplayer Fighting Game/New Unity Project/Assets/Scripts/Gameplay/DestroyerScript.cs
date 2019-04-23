using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public GameObject prefab;
    public Transform prefabPosition;

    PointScript ps = new PointScript();
    public int minY;
    public int maxY = -2;

    void Start()
    {
        //prefab = GetComponent<GameObject>();

    }

    void Update()
    {
        if (prefabPosition.position.y > maxY)
        {
            maxY = (int) prefabPosition.position.y;
        }
            minY = maxY - 3;
        if (prefabPosition.position.y < minY)
        {
            Destroy(prefab);
            //PlayerPrefs.SetString("PlayerDestroyed", "true");
        }
    }
}
