using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hp = 1;
    public Emitter emitter;
    public bool moveDown = true;

    //private void FixedUpdate() {
    //    transform.position = new Vector3(transform.position.x, transform.position.y + emitter.brickMoveSpeed * Time.fixedDeltaTime * (moveDown ? -1 : 1), transform.position.z);
    //}
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Ball")) {
            hp--;
            if(hp <= 0) {
                Destroy(gameObject);
            }
            var ballrig = collision.gameObject.GetComponent<Ball>().rig;
            ballrig.velocity = new Vector2(ballrig.velocity.x, -ballrig.velocity.y);
        }
    }
}
