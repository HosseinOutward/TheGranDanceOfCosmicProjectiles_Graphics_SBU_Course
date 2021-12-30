using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_hit : MonoBehaviour
{
    public float Boss_health = 500f;
    public Transform tr;
    public GameObject Explosion;

    private float hurt_time;
    public Sprite spriteHurt;
    public Sprite spriteUnHurt;
    public SpriteRenderer spriteRenderer;

    public HealthBar healthBar;
    private float dead_time;

    public GameObject my_obj;
    public AudioClip clip_on_start;
    public AudioClip clip_on_death;
    private void Start()
    {
        healthBar.setMaxHealth(Boss_health);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Mybullets1"){
            spriteRenderer.sprite = spriteHurt;
            hurt_time = Time.time;
            Boss_health -= 0.1f;
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

        healthBar.setHealth(Boss_health);

        if(Time.time - hurt_time >= 0.05){
            spriteRenderer.sprite = spriteUnHurt;
        }

        if(Boss_health <= 0){
            GameObject dust = Instantiate(Explosion, tr.position, tr.rotation);

            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().PlayOnce(clip_on_death);

            Destroy(gameObject);
        }
        
    }
}
