using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpriteCtrl : MonoBehaviour
{
    private bool isRight = true;

    public Animator playerAnim;

    public MainHouseDameReceiver mainHouseHP;

    void Update()
    {

        if ((PlayerCtrl.instance.playerMovement.pressX < 0) && isRight)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            isRight = false;
        }
        else if ((PlayerCtrl.instance.playerMovement.pressX > 0) && !isRight)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            isRight = true;
        }

        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        
        if (PlayerCtrl.instance.playerDameReceiver.IsDead() || mainHouseHP.IsDead())
        {
            playerAnim.Play("PlayerDead");
            PlayerCtrl.instance.playerMovement.DeadManDontMove = true;
            Invoke("GameOver", 4.5f);
        }
        else
        {
            if (PlayerCtrl.instance.playerMovement.pressX != 0 || PlayerCtrl.instance.playerMovement.pressY != 0)
            {
                playerAnim.Play("PlayerRun");
            }
            else if (InputManager.instance.OnFiring() != 0f)
            {
                playerAnim.Play("PlayerAttack");
            }
            else playerAnim.Play("PlayerIdle");
        }
    }
    void GameOver()
    {
        SceneManager.LoadScene("EndScene");
    }
}

