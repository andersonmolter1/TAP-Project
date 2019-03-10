using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class P3_Nav : MonoBehaviour
{
    EventSystem p3_EventSystem;
    static GameObject marker;
    GameObject[] markers;

    private void OnEnable()
    {
        p3_EventSystem = EventSystem.current;
    }

    private void Start()
    {
        markers = GameObject.FindGameObjectsWithTag("pmarker3");
        marker = p3_EventSystem.currentSelectedGameObject;
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
