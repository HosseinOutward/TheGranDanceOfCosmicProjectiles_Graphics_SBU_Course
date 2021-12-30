using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_manager_tuto : MonoBehaviour
{
    public GameObject dialogue;
    


    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(0.01f);
        SceneManager.LoadScene(0);
        
    }
    void Update()
    {
        if(dialogue.GetComponent<TypeWriterEffect>().Text_done){
            if(Input.GetButtonDown("Fire1")){
                StartCoroutine(waiter());
            }
            
        }
        
    }
}
