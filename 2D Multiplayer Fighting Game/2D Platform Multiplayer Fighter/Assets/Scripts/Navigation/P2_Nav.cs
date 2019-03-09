using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class P2_Nav : MonoBehaviour
{
    EventSystem p2_EventSystem;
    static GameObject marker;
    GameObject[] markers;

    private void OnEnable()
    {
        p2_EventSystem = EventSystem.current;
    }

    private void Start()
    {
        markers = GameObject.FindGameObjectsWithTag("pmarker2");
        marker = p2_EventSystem.currentSelectedGameObject;
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
