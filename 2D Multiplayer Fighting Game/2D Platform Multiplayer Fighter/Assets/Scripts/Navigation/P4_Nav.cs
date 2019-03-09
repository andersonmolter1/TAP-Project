using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class P4_Nav : MonoBehaviour
{
    EventSystem p4_EventSystem;
    static GameObject marker;
    GameObject[] markers;

    private void OnEnable()
    {
        p4_EventSystem = EventSystem.current;
    }

    private void Start()
    {
        markers = GameObject.FindGameObjectsWithTag("pmarker4");
        marker = p4_EventSystem.currentSelectedGameObject;
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
