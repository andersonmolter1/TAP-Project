using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class P1_Nav : MonoBehaviour
{
    EventSystem p1_EventSystem;
    static GameObject marker;
    GameObject[] markers;

    private void OnEnable()
    {
        p1_EventSystem = EventSystem.current;
    }

    private void Start()
    {
        markers = GameObject.FindGameObjectsWithTag("pmarker1");
        marker = p1_EventSystem.currentSelectedGameObject;
        //marker.SetActive(true);
        HideMarkers();
    }

    void Update()
    {
        
    }

    public void ShowMarker(GameObject g) {
        HideMarkers();
        g.SetActive(true);
    }

    public void HideMarkers() {
        foreach(GameObject g in markers)
        {
            g.SetActive(false);
        }
    }
}
