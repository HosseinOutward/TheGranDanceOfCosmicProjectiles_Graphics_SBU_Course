using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3_shoot : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
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
        GameObject missiles = Instantiate(MissilePrefab, firePoint1.position, firePoint1.rotation);
        //missiles.transform.localScale = new Vector3(12, 12, 12);
        Rigidbody2D rb1 = missiles.GetComponent<Rigidbody2D>();
        rb1.velocity = (firePoint1.right * MissileForce);

        GameObject missiles2 = Instantiate(MissilePrefab, firePoint2.position, firePoint2.rotation);
        //missiles.transform.localScale = new Vector3(12, 12, 12);
        Rigidbody2D rb2 = missiles2.GetComponent<Rigidbody2D>();
        rb2.velocity = (firePoint2.right * MissileForce);

        GameObject missiles3 = Instantiate(MissilePrefab, firePoint3.position, firePoint3.rotation);
        //missiles.transform.localScale = new Vector3(12, 12, 12);
        Rigidbody2D rb3 = missiles3.GetComponent<Rigidbody2D>();
        rb3.velocity = (firePoint3.right * MissileForce);
        
    }

}
