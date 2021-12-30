using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_shoot_Bomb : MonoBehaviour
{
    public Transform firePoint;
    public GameObject MissilePrefab;

    public float attack_delay = 5f;
    public float MissileForce = 15f;
    public float nextAttack;
    // Update is called once per frame
    void Start()
    {
        nextAttack = Time.time;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.I)){

            if (Time.time >= nextAttack){
            nextAttack = Time.time + attack_delay;
            Shoot();
            }
            
        }
    }

    void Shoot(){
        GameObject missiles = Instantiate(MissilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = missiles.GetComponent<Rigidbody2D>();
        rb.velocity = (firePoint.right * MissileForce);
        GameObject.Find("AudioSourcer").GetComponent<AudioManager>().PlayOnce(2);
    }
}
