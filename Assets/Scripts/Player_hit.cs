using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_hit : MonoBehaviour
{
    
    public float Boss_health = 500f;
    public Transform tr;
    public GameObject Explosion;
    public bool not_immune = true;
    private float hurt_time;
    public Sprite spriteHurt;
    public Sprite spriteUnHurt;
    public SpriteRenderer spriteRenderer;

    public HealthBar healthBar;

    private float dead_time;


    private void Start()
    {
        healthBar.setMaxHealth(Boss_health);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemybullets1"){
            if(not_immune) {
                    not_immune = false;
                    Boss_health -= 15f;
                    spriteRenderer.sprite = spriteHurt;
                    hurt_time = Time.time;
            }   
            
            if(Boss_health <= 0){            
                dead_time = Time.time;
            }
        } 
        if(other.gameObject.tag == "Enemybullets2"){  
                     
            if(not_immune) {
                    not_immune = false;
                    Boss_health -= 40f;
                    spriteRenderer.sprite = spriteHurt;
                    hurt_time = Time.time;
            }
            if(Boss_health <= 0){               
                dead_time = Time.time;
            }
        }
        if(other.gameObject.tag == "Enemybullets3"){           
            if(not_immune) {
                    not_immune = false;
                    Boss_health -= 20f;
                    spriteRenderer.sprite = spriteHurt;
                    hurt_time = Time.time;
            }
            if(Boss_health <= 0){                
                dead_time = Time.time;
            }
        }
        if(other.gameObject.tag == "Enemybullets4"){           
            if(not_immune) {
                    not_immune = false;
                    Boss_health -= 150f;
                    spriteRenderer.sprite = spriteHurt;
                    hurt_time = Time.time;
            }
            if(Boss_health <= 0){   
                dead_time = Time.time;        
            }
        }
        if(other.gameObject.tag == "enemy"){
            tr.Translate(-1f, 0.0f,0.0f);
            if (not_immune) {
                    Boss_health -= 40f;
                    spriteRenderer.sprite = spriteHurt;
                    hurt_time = Time.time;
            }
            if(Boss_health <= 0){               
                dead_time = Time.time;
            }
        }
        
    }
    
    void Update()
    {

        healthBar.setHealth(Boss_health);

        if(Time.time - hurt_time >= 2){
            not_immune = true;
            spriteRenderer.sprite = spriteUnHurt;
        }

        if(Boss_health <= 0){
            
            GameObject dust = Instantiate(Explosion, tr.position, tr.rotation);
            Destroy(gameObject);
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().PlayOnce(1);
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().PlayOnce2(2);
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().setMusic(3);
            if (Time.time - dead_time >= 0.04){
                Destroy(gameObject);
            }
            

        }
    }
}
