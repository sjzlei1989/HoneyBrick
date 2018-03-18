using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed = 4;

	void Start()
	{
		
	}
	
	void Update()
	{
		
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        //检测和墙的碰撞, 如果是左右墙, 将x速度反向; 如果是上下墙, 输了
        if((name.Equals("ball1") && collision.CompareTag("P1DeadWall")) || (name.Equals("ball2") && collision.CompareTag("P2DeadWall"))) {
            Debug.Log("YOU LOST!!!" + name);
            Destroy(gameObject);
        }
        else if(collision.CompareTag("LRWall")) {
            rig.velocity = new Vector2(-rig.velocity.x, rig.velocity.y);
        }
        else if(collision.CompareTag("Stick") || (name.Equals("ball1") && collision.CompareTag("P1UWall")) || (name.Equals("ball2") && collision.CompareTag("P2UWall"))) {
            rig.velocity = new Vector2(rig.velocity.x, -rig.velocity.y);
        }
    }

    public void Init() {
        float y = 0;
        if(name.Equals("ball2")) {
            y = Random.Range(-3.0f, -1.0f);
        }
        else {
            y = Random.Range(1.0f, 3.0f);
        }
        rig.velocity = new Vector2(Random.Range(-3.0f, 3.0f), y).normalized * speed;
    }
}
