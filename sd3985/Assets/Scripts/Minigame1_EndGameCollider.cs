using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1_EndGameCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Minigame1_PlayerController.endGame = true;
        }
        
    }
}
