using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_col : MonoBehaviour
{
    public Animator animator;
    private bool collided = false;
    private bool flag = true;
    public Rigidbody2D rb;
    private float startTime;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "enemy"){
            animator.SetBool("Collide", true);
            collided = true;
            
            if(flag){
                startTime = Time.time;
                flag = false;
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
        

    }
    void FixedUpdate()
    {
        if(collided == true){
            if(Time.time - startTime > 0.15) {
                Destroy(gameObject);
            }
        }
    }
}
