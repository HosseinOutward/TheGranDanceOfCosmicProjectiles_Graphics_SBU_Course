using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_3_sight : MonoBehaviour
{

    public bool can_shoot;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            can_shoot = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            can_shoot = false;
        }
    }

    
}
