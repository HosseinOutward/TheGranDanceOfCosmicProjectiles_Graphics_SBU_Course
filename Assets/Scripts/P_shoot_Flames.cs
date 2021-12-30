using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_shoot_Flames : MonoBehaviour
{
    public Transform firePoint;
    public GameObject MissilePrefab;
    private float nextAttack;
    public float attack_delay = 0.1f;
    public float MissileForce = 15f;
    private int random;
    
    void Start()
    {
           nextAttack = Time.time;
    }
   
    void Update()
    {
        if(Input.GetKey(KeyCode.L)){

            if (Time.time >= nextAttack){
            nextAttack = Time.time + attack_delay;
            Shoot();
            }
            
        }
    }

    void Shoot(){
        random = Random.Range(-1, 6);
        GameObject missiles = Instantiate(MissilePrefab, firePoint.position, firePoint.rotation);
        missiles.transform.position = new Vector3(random/2 + firePoint.position.x, firePoint.position.y, firePoint.position.z);
        missiles.transform.localScale = new Vector3(5 + random, 5 + random, 5 + random);
        Rigidbody2D rb = missiles.GetComponent<Rigidbody2D>(); 
        rb.AddForce(firePoint.right * MissileForce, ForceMode2D.Impulse);
    }
}
