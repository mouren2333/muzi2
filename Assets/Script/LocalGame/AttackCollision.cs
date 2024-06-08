using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    public int Player; //Player1==1,Player2==2 
    private void OnTriggerEnter(Collider other)
    {
        if(Player==2)
        {
            if (other.gameObject.CompareTag("Player1_Attack"))
            {
                LocalGameControllerManager.Instance.HP_Player2 += 2;
                print("Player2 attack");
            }
        }
        else
        {
            if (other.gameObject.CompareTag("Player2_Attack"))
            {
                LocalGameControllerManager.Instance.HP_Player1 += 2;
                print("Player1 attack");
            }
        }
    }
}
