using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    /// <summary>
    /// 一行有几块砖
    /// </summary>
    const int BRICKS_NUM_OF_ROW = 11;

    /// <summary>
    /// 最左边一块砖的x坐标
    /// </summary>
    const float LEFT_START_X = -7.6f;

    const int BRICK_WIDTH = 152;
    const int BRICK_HEIGHT = 60;
    const float PIXEL_PER_UNIT = 100;

    public GameObject brickPrefab;

    public float brickMoveSpeed = 5.0f;

    public bool moveDown = true;

    float timer = 0;
    float createTicker = 0;

    void Start() {
        createTicker = BRICK_HEIGHT / PIXEL_PER_UNIT / brickMoveSpeed;
    }

    private void FixedUpdate() {
        timer += Time.fixedDeltaTime;
        if(timer >= createTicker) {
            CreateARowBricks();
            timer = 0;
        }
    }

    public void CreateARowBricks() {
        for(int i = 0; i < BRICKS_NUM_OF_ROW; i++) {
            //90%机率有砖
            if(Random.value > 0.9f) {
                continue;
            }
            var g = Instantiate<GameObject>(brickPrefab);
            g.GetComponent<Brick>().emitter = this;
            g.GetComponent<Brick>().moveDown = moveDown;
            float x = LEFT_START_X + i * BRICK_WIDTH / PIXEL_PER_UNIT;
            g.transform.position = new Vector3(x, 0, 0);
        }
    }
}
