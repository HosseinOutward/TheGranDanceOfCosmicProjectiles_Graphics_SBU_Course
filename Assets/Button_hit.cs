using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_hit : MonoBehaviour
{
    public float Boss_health = 500f;
    public Transform tr;
    public GameObject Explosion;

    private float hurt_time;
    public Sprite spriteHurt;
    public Sprite spriteUnHurt;
    public SpriteRenderer spriteRenderer;

    private float dead_time;

    public GameObject my_obj;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Mybullets1"){
            spriteRenderer.sprite = spriteHurt;
            hurt_time = Time.time;
            Boss_health -= 1f;
            if(Boss_health <= 0){            
                dead_time = Time.time;
            }
        } 
        if(other.gameObject.tag == "Mybullets2"){           
            Boss_health -= 40f;
            spriteRenderer.sprite = spriteHurt;
            hurt_time = Time.time;
            if(Boss_health <= 0){               
                dead_time = Time.time;
            }
        }
        if(other.gameObject.tag == "Mybullets3"){           
            Boss_health -= 15f;
            spriteRenderer.sprite = spriteHurt;
            hurt_time = Time.time;
            if(Boss_health <= 0){                
                dead_time = Time.time;
            }
        }
        if(other.gameObject.tag == "Mybullets4"){           
            Boss_health -= 150f;
            spriteRenderer.sprite = spriteHurt;
            hurt_time = Time.time;
            if(Boss_health <= 0){                
                dead_time = Time.time;
            }
        }
        if(other.gameObject.tag == "Mybullets5"){   
            Boss_health -= 10f;
            spriteRenderer.sprite = spriteHurt;
            hurt_time = Time.time;
            if(Boss_health <= 0){   
                dead_time = Time.time;
            }
        }
    }
    
    void Update()
    {
        if(Time.time - hurt_time >= 0.05){
            spriteRenderer.sprite = spriteUnHurt;
        }

        if(Boss_health <= 0){
            
            GameObject dust = Instantiate(Explosion, tr.position, tr.rotation);
            
            my_obj.SetActive(false);
            

        }
    }
}
