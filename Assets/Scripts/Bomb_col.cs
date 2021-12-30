using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_col : MonoBehaviour
{

    public Collider2D collider2;
    private float start_time;
    public float destroy_time = 1.41f;
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - start_time > destroy_time - 1 )
            collider2.enabled = true;

        if(Time.time - start_time > destroy_time){
            Destroy(gameObject);
        }      
    }
}
