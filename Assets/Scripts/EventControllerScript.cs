using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventControllerScript : MonoBehaviour
{
    
    public GameObject textBox;
    public GameObject map;



    public GameObject droid;
    public GameObject health_bar;
    public GameObject health_barE1;
    public GameObject health_barE2;
    public GameObject health_barE3;
    public GameObject health_barE4;
    public GameObject player;


    public Transform spawn_tr;
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;



    private bool E1_enter;
    private bool E2_enter;
    private bool E3_enter;
    private bool E4_enter;

    private bool end_game = false;
    
    
    void Start()
    {
        droid.SetActive(false);
        health_bar.SetActive(false);
        player.SetActive(false);
        E1.SetActive(false);
        E2.SetActive(false);
        E3.SetActive(false);
        E4.SetActive(false);
        health_barE1.SetActive(false);
        health_barE2.SetActive(false);
        health_barE3.SetActive(false);
        health_barE4.SetActive(false);

    }
    
    void Update()
    {

        // End Of Dialogues : 
        if(textBox.gameObject.GetComponent<TypeWriterEffect>().Text_done){
            health_bar.SetActive(true);
            player.SetActive(true);
            droid.SetActive(true);
            map.gameObject.GetComponent<Map_move>().map_move = 1;
            E1_enter = true;

            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().setMusic(E1.GetComponent<Boss_hit>().clip_on_start);
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().musicAS.volume -= 0.6f;
            textBox.gameObject.GetComponent<TypeWriterEffect>().Text_done = false;
        }


        // controlling enemy spawnage
        if (E1_enter && E1){
            E1.SetActive(true);
            health_barE1.SetActive(true);}
        if(E2_enter && E2){
            E2.SetActive(true);
            health_barE2.SetActive(true);}
        if(E3_enter && E3){
            E3.SetActive(true);
            health_barE3.SetActive(true);}
        if(E4_enter && E4){
            E4.SetActive(true);
            health_barE4.SetActive(true);}

        if(E1 && E1.GetComponent<Boss_hit>().Boss_health <= 0){
            E2_enter = true;
        }
        if(E2 && E2.GetComponent<Boss_hit>().Boss_health <= 0){
            E3_enter = true;
        }
        if(E3 && E3.GetComponent<Boss_hit>().Boss_health <= 0){
            E4_enter = true;
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().setMusic(E4.GetComponent<Boss_hit>().clip_on_start);
        }
        if(E4 && E4.GetComponent<Boss_hit>().Boss_health <= 0){
            end_game = true;
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().setMusic(0);
            GameObject.Find("AudioSourcer").GetComponent<AudioManager>().PlayOnce2(4);
        }
        
        if(end_game){
            
        }
    }
    


}
