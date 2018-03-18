using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// 保存对面玩家, 用来给对方施加buff之类
    /// </summary>
    public Player otherPlayer;

    /// <summary>
    /// 移动速度
    /// </summary>
    public float speed = 2;

    public Ball ball;

    Vector3 lastPos;

    bool isMovable = false;
    int touchIndex = 0;

    void Start() {
        if(ball != null) {
            ball.Init();
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision) {
        
    //}
    //private void OnTriggerEnter2D(Collider2D collision) {
    //    if(collision.CompareTag("LRWall")) {
    //        lastPos = transform.position;
    //        transform.position = lastPos;
    //    }
    //}
}
