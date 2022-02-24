using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCtrl : MonoBehaviour
{
    public BossOneIA BossOneIA;
    public PlayerCtrl Player;
    public CameraCtrl cam;
    public UI ui;
    public savePoint SavePoint;


    void OnTriggerEnter2D(Collider2D other)
    {      
        if (other.gameObject.CompareTag("Player"))
        {
            GameCtrl.instance.save = true;
            cam.bossCamera = true;
            //SavePoint.DeleteSave();
            
            if (!GameCtrl.instance.data.BossActive)
            {
                //activo mensaje
                ui.bossBattle.gameObject.SetActive(true);
                PlayerPrefs.SetFloat("CPX", 152);
                PlayerPrefs.SetFloat("CPY", other.gameObject.transform.position.y);
                Player.canMove = false;
                Player.canFire = false;
                Player.canJump = false;
                StartCoroutine(SetCountText());
                StartCoroutine(SetCountBB());
            }
            else
            {
                PlayerPrefs.SetFloat("CPX", 152);
                PlayerPrefs.SetFloat("CPY", other.gameObject.transform.position.y);
                BossOneIA.active = true;            
            }


        }
    }

    IEnumerator SetCountText()
    {
        {
            yield return new WaitForSeconds(5);
            //Time.timeScale = 1;
            Player.MobileStop();
            Player.canMove = true;
            Player.canFire = true;
            Player.canJump = true;
            GameCtrl.instance.UpdateBoss();
            BossOneIA.active = true;
        }
    }


    IEnumerator SetCountBB()
    {
        {
            yield return new WaitForSeconds(4);
            ui.bossBattle.gameObject.SetActive(false);
        }
    }


}
