using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localtest : MonoBehaviour
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
    }
    public void ActionControl_Player1()
    {
        Animator _anim = Player1.GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.A))             //Defence
        {
            _anim.SetInteger(Animator_name, 1);
        }
        else if (Input.GetKeyDown(KeyCode.D))        //Attack
        {
            _anim.SetInteger(Animator_name, 2);
        }
        else if (Input.GetKeyDown(KeyCode.W))       //GoBack
        {
            _anim.SetInteger(Animator_name, 3);
        }
        else if (Input.GetKeyDown(KeyCode.S))       //Down
        {
            _anim.SetInteger(Animator_name, 4);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            _anim.SetInteger(Animator_name, 0);
        }

    }
    public void ActionControl_Player2()
    {


    }
}
