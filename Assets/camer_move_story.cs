using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camer_move_story : MonoBehaviour
{
    public Transform cam_tr;
    public Transform player_tr;



    private void Update()
    {
        cam_tr.position = new Vector3(player_tr.position.x, cam_tr.position.y, cam_tr.position.z);
    }
}
