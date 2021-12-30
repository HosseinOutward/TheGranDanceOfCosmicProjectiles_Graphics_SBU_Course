using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_shoot : MonoBehaviour
{
   public Transform firePoint;
    public GameObject MissilePrefab;

    public float attack_delay = 1f;
    public float MissileForce = 15f;
    public float nextAttack;
    // Update is called once per frame
    public GameObject sight;
    bool can_shoot;
    
    
    void Update()
    {
        can_shoot = sight.gameObject.GetComponent<E_3_sight>().can_shoot;
        if(can_shoot){
            if (Time.time >= nextAttack){
            nextAttack = Time.time + attack_delay;
            Shoot();
            }
        }
    }

    void Shoot(){
        GameObject missiles = Instantiate(MissilePrefab, firePoint.position, firePoint.rotation);
        //missiles.transform.localScale = new Vector3(12, 12, 12);
        Rigidbody2D rb = missiles.GetComponent<Rigidbody2D>();
        rb.velocity = (firePoint.right * MissileForce);
        
    }
}
