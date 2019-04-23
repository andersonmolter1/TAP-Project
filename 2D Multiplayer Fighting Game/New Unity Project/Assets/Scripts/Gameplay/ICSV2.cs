using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICSV2 : MonoBehaviour
{
    public int iceCreamCount;
    public int goldCount;
    public bool isMainMenu;
    public bool isGold;

    void Update()
    {
        if (!isMainMenu)
        {
            int minY = PlayerPrefs.GetInt("MinY");
            if ((int)gameObject.transform.position.y < minY)
            {
                Destroy(this.gameObject);
            }
        }
        if(isMainMenu)
        {
            int minY = -100;
            if((int)gameObject.transform.position.y < minY)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && !isGold)
        {
            iceCreamCount = PlayerPrefs.GetInt("IceCream");
            iceCreamCount += 1;
            PlayerPrefs.SetInt("IceCream", iceCreamCount);
            Destroy(this.gameObject);
        }
        else if(isGold)
        {
            goldCount = PlayerPrefs.GetInt("Gold");
            goldCount += 1;
            PlayerPrefs.SetInt("Gold", goldCount);
            Destroy(this.gameObject);
        }
    }
}
