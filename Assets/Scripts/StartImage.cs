using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartImage : MonoBehaviour, IDragHandler
{
    public Menu menu;

    public void OnDrag(PointerEventData eventData) {
        var pos = eventData.position;
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("StartImg")) {
            menu.StartGame();
        }
    }
}
