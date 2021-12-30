using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_manager_menu : MonoBehaviour
{
    
    public GameObject play;
    public GameObject tutorial;
    public GameObject story;
    public GameObject quit;
    


    IEnumerator waiter(int i)
    {
        yield return new WaitForSecondsRealtime(2);

        if(i == 2)
        SceneManager.LoadScene(2);
        if(i == 1)
        SceneManager.LoadScene(1);
        if(i == 3)
        SceneManager.LoadScene(3);
        if(i == 4)
        Application.Quit();
    }
    void Update()
    {
        if(play.GetComponent<Button_hit>().Boss_health <= 0){
            StartCoroutine(waiter(2));
            
        }
        if(tutorial.GetComponent<Button_hit>().Boss_health <= 0){
            StartCoroutine(waiter(1));
            
        }
        if(story.GetComponent<Button_hit>().Boss_health <= 0){
            StartCoroutine(waiter(3));
        }
        if(quit.GetComponent<Button_hit>().Boss_health <= 0){
            StartCoroutine(waiter(4));   
            
        }
    }
}
