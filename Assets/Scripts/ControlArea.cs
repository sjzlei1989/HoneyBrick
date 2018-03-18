using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlArea : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Rigidbody2D controlTarget;
    public Player controlPlayer;

    public void OnDrag(PointerEventData eventData) {
        Vector3 pos = Camera.main.ScreenToWorldPoint(eventData.position);
        controlPlayer.gameObject.transform.position = new Vector3(pos.x, controlPlayer.gameObject.transform.position.y, controlPlayer.gameObject.transform.position.z);
        transform.position = new Vector3(eventData.position.x, transform.position.y, transform.position.z);
    }

    public void OnPointerDown(PointerEventData eventData) {
    }

    public void OnPointerUp(PointerEventData eventData) {
    }
}
