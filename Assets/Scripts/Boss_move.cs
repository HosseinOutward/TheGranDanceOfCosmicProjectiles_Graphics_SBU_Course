using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_move : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform tr;
    public Transform player;
    private float diffy, dir;
    public float move_to_map;
    public float speed = 5f;
    

    void Start()
    {
        move_to_map = 5f;
        tr.position = new Vector3(3, -20, 0);
    }

    void Update()
    {

        diffy = player.position.y - tr.position.y;
        dir = Mathf.Sign(diffy);

        if(move_to_map > 0){
            rb.velocity = new Vector3(-3, dir * speed, 0);
            move_to_map -= 0.0001f;
        } else {
            rb.velocity = new Vector3(0, dir * speed, 0);   
        }

        if(tr.position.x < 1){
            move_to_map = 0;
        }

        

            
        
    }
}
