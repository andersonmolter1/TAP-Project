using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelection : MonoBehaviour
{
    public string map;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (map == null)
        {
            Destroy(this);
        }
    }

    public void SetMap(string name)
    {
        map = name;
    }

    public string GetMap()
    {
        return map;
    }
}
