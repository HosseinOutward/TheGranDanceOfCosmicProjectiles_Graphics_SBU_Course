using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class df_p_move : MonoBehaviour
{
     public float maxVerticalSpeed;
     public float maxHorizontalSpeed;
     public float Speed;
 
 
     void Start () {
 
     
     }
     
     void FixedUpdate () {
 
     transform.Translate (new Vector3 (0, Input.GetAxis ("Vertical") * maxVerticalSpeed * Time.deltaTime));
     transform.Translate (new Vector3 (Input.GetAxis ("Horizontal") * maxHorizontalSpeed * Time.deltaTime, 0)); 

     }
}
