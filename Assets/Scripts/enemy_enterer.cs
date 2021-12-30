using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_enterer : MonoBehaviour
{

    public bool enter1 = false;
    public bool enter2 = false;
    public bool enter3 = false;
    public bool enter4 = false;
    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Enter1"){
            enter1 = true;
        } else if(other.gameObject.tag == "Enter2"){
            enter2 = true;
        } else if(other.gameObject.tag == "Enter3"){
            enter3 = true;
        } else if(other.gameObject.tag == "Enter4"){
            enter4 = true;
        }



    }
}
