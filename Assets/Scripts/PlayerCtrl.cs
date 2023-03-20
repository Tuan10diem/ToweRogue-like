using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public static PlayerCtrl instance;

    public PlayerDameReceiver playerDameReceiver;
    public PlayerMovement playerMovement;
    public PlayerState playerState;
    public PlayerShooting playerShooting;
    public PlayerExp playerExp;
    
    // Start is called before the first frame update
    void Awake()
    {
        // DontDestroyOnLoad(gameObject);
        
        playerMovement = GetComponent<PlayerMovement>();
        playerState = GetComponent<PlayerState>();
        playerShooting = GetComponent<PlayerShooting>();
        playerDameReceiver = GetComponent<PlayerDameReceiver>();
        playerExp = GetComponent<PlayerExp>();
        instance = this;
    }
}
