using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_ex : MonoBehaviour
{
    public Animator anim;
    public Transform pos;
    public AudioClip[] hitlerClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("NeinCat"))
        {
            int hitlerState = GameObject.Find("NeinCat").GetComponent<neincat_move>().hitlerState;
            if (pos.position[0] < -145 && hitlerState == 0)
            {
                GameObject.Find("AudioSourcer").GetComponent<AudioManager>().setMusic(hitlerClip[0]);
                GameObject.Find("NeinCat").GetComponent<neincat_move>().hitlerState = 1;
            }
            else if (pos.position[0] < -170 && hitlerState == 1)
            {
                GameObject.Find("AudioSourcer").GetComponent<AudioManager>().setMusic(hitlerClip[1]);
                GameObject.Find("NeinCat").GetComponent<neincat_move>().hitlerState = 2;
            }
        }

        if (Input.GetAxisRaw("Horizontal") > 0){
            anim.SetFloat("Speed", 1);
            anim.SetBool("Still", false);
        } else if(Input.GetAxisRaw("Horizontal") < 0) {
            anim.SetFloat("Speed", -1);
            anim.SetBool("Still", false);
        } else {
            anim.SetFloat("Speed", 0);
            anim.SetBool("Still", true);
        }
    }
}
