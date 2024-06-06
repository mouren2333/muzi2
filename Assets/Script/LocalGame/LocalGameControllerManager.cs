using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalGameControllerManager: MonoBehaviour
{
    public string Animator_name;

    public GameObject Player1;
    public GameObject Player2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        ActionControl_Player1();
        ActionControl_Player2();
    }

    public void ActionControl(KeyCode a , KeyCode d, KeyCode w, KeyCode s,GameObject player)
    {
        Animator _anim = player.GetComponent<Animator>();

        if (Input.GetKeyDown(a))             //Defence
        {
            _anim.SetInteger(Animator_name, 1);
        }
        else if (Input.GetKeyDown(d))        //Attack
        {
            _anim.SetInteger(Animator_name, 2);
        }
        else if (Input.GetKeyDown(w))       //GoBack
        {
            _anim.SetInteger(Animator_name, 3);
        }
        else if (Input.GetKeyDown(s))       //Down
        {
            _anim.SetInteger(Animator_name, 4);
        }
    }

    public void ActionControl_Player1()
    {
        ActionControl(KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S, Player1);
    }
    public void ActionControl_Player2()
    {
        ActionControl(KeyCode.J, KeyCode.L, KeyCode.I, KeyCode.K, Player2);
    }
}
