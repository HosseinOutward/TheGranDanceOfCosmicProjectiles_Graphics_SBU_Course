using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droid_shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject MissilePrefab;

    public float attack_delay = 1f;
    public float MissileForce = 15f;
    public float nextAttack;
    private bool allowed = false;
   

    void Start()
    {
        nextAttack = Time.time;
    }
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.R)) {
            if(allowed){
                allowed = false;
            } else {
                allowed = true;
            }
        }

    
        if (Time.time >= nextAttack && allowed){
        nextAttack = Time.time + attack_delay;
        Shoot();
        }  
    
    }

    void Shoot(){
        GameObject missiles = Instantiate(MissilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = missiles.GetComponent<Rigidbody2D>();
        rb.velocity = (firePoint.right * MissileForce);
        
    }
}
