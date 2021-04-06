using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamTra;
    public GameObject playerCam;

    void Start()
    {
        playerCam = GameObject.Find("PlayerCamera");

        if (playerCam)
        {
            playerCamTra = playerCam.transform;
        }
    }


    void LateUpdate()
    {
        // billboard the healthBar
        if(playerCamTra)
        {
            transform.LookAt(transform.position + playerCamTra.forward);
        }
    }
}
