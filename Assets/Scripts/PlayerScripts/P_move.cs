using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_move : MonoBehaviour
{
    // Start is called before the first frame update
     public float maxVerticalSpeed;
     public float maxHorizontalSpeed;
    
 
 
     void Start () {
 
     
     }
     
     void FixedUpdate () {
 
     transform.Translate (new Vector3 (0, Input.GetAxis ("Vertical") * maxVerticalSpeed * Time.deltaTime));
     transform.Translate (new Vector3 (Input.GetAxis ("Horizontal") * maxHorizontalSpeed * Time.deltaTime, 0)); 

     }
}
