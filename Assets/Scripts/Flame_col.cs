using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame_col : MonoBehaviour
{
    private float start_time;
    public float destroy_time = 0.5f;
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - start_time > destroy_time){
            Destroy(gameObject);
        }      
    }
}
