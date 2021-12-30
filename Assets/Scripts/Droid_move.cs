using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droid_move : MonoBehaviour
{
    public Transform ship;
    public Transform me;
    private float tetha;
    private float pos_x;
    private float pos_y;
    public float radius; 
    public float speed;

    
    
    void Start()
    {
        
        tetha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pos_x = Mathf.Cos(tetha) * radius + ship.position.x - 1f;
        pos_y = Mathf.Sin(tetha) * radius + ship.position.y;
        me.transform.position = new Vector3(pos_x, pos_y, 0);
        tetha -= 0.005f * speed;
    }
}
