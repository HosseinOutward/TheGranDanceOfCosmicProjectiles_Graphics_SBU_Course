using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_move : MonoBehaviour
{
    public float speed;
    public Transform tr;
    private float pos_x;

    public int map_move = 0;

    private void Start()
    {
        pos_x = tr.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        pos_x -= 0.01f * speed * map_move;
        tr.position = new Vector3(pos_x, tr.position.y, tr.position.z);
    }
}
