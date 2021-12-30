using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neincat_move : MonoBehaviour
{
    public Transform cat_tr;
    public Collider2D colid;
    public float cat_speed;
    public int hitlerState;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            cat_speed = -0.01f;
            GameObject.Find("SpaceShip1").SetActive(false);
        }
    }

    private void Update()
    {
        if (hitlerState == 2)
            cat_tr.position = new Vector3(cat_tr.position.x + cat_speed, cat_tr.position.y, cat_tr.position.z);
    }
}

