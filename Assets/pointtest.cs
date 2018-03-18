using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pointtest : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) {
        var g = GameObject.CreatePrimitive(PrimitiveType.Cube);
        g.transform.position = Camera.main.ScreenToWorldPoint(eventData.position);
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
