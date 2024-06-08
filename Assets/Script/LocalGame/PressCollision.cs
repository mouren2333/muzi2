using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressCollision : MonoBehaviour
{
    public int Player; //Player1==1,Player2==2 

    private void OnTriggerEnter(Collider other)
    {
        if (Player == 2)
        {
            if (other.gameObject.CompareTag("Player1_Press"))
            {
                LocalGameControllerManager.Instance.BattleScene.SetActive(true);
                LocalGameControllerManager.Instance.BattleScene_player1_Press_player2.SetActive(true);

                LocalGameControllerManager.Instance.Player1.GetComponent<Animator>().enabled=false;
                LocalGameControllerManager.Instance.Player2.GetComponent<Animator>().enabled = false;
                LocalGameControllerManager.Instance.Self.SetActive(false);

                this.gameObject.SetActive(false);
                print("Player2 defence");
            }
        }
        else
        {
            if (other.gameObject.CompareTag("Player2_Press"))
            {
                LocalGameControllerManager.Instance.BattleScene.SetActive(true);
                LocalGameControllerManager.Instance.BattleScene_player2_Press_player1.SetActive(true);

                LocalGameControllerManager.Instance.Player1.GetComponent<Animator>().enabled = false;
                LocalGameControllerManager.Instance.Player2.GetComponent<Animator>().enabled = false;
                LocalGameControllerManager.Instance.Self.SetActive(false);

                this.gameObject.SetActive(false);
                print("Player1 defence");
            }
        }
    }
}
