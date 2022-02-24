using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MobileUICtrl : MonoBehaviour {

    public GameObject player;

    PlayerCtrl playerCtrl;
    //Animator anim;
    //nuevo

    void Start () {
        playerCtrl = player.GetComponent<PlayerCtrl>();  
    }
	
    public void MobileMoveLeft()
    {
        playerCtrl.MobileMoveLeft();
    }

    public void MobileMoveRight()
    {
        playerCtrl.MobileMoveRight();
    }

    public void MobileMoveStop()
    {
        playerCtrl.MobileStop();
    }

    public void MobileJump()
    {
        playerCtrl.MobileJump();
    }
}
