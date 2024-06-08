using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalGameControllerManager: MonoBehaviour
{
    public static LocalGameControllerManager Instance;
    public GameObject Self;

    private void Awake()
    {
        Self = this.gameObject;
        Instance = this;
    }
    private void OnDestroy()
    {
        Instance=null;
    }

   
    public GameObject BattleScene;
    public GameObject BattleScene_player1_Press_player2;
    public GameObject BattleScene_player2_Press_player1;
    public string Animator_name;

    public int Player1_keyPressCount = 0;
    public List<KeyCode> Player1_KC = new List<KeyCode>() { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
    public Image HP_Player1_UI;

    public GameObject Player1;
    public float HP_Player1;
    public GameObject AttackCollision_Player1;
    public GameObject DefenceCollision_Player1;
    public GameObject PressCollision_Player1;



    public int Player2_keyPressCount = 0;
    public List<KeyCode> Player2_KC = new List<KeyCode>() { KeyCode.J, KeyCode.K, KeyCode.I, KeyCode.L };
    public Image HP_Player2_UI;

    public GameObject Player2;
    public float HP_Player2;
    public GameObject AttackCollision_Player2;
    public GameObject DefenceCollision_Player2;
    public GameObject PressCollision_Player2;



    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Plyer1_CheckKeyDown_btn();
        Plyer2_CheckKeyDown_btn();

        ActionControl_Player1();
        ActionControl_Player2();

        HP_Player1_UI.fillAmount = HP_Player1/ 100;
        HP_Player2_UI.fillAmount = HP_Player2 / 100;
    }

    public void Plyer1_CheckKeyDown_btn()
    {
        foreach (KeyCode keyCode in Player1_KC)
        {
            if (Input.GetKeyDown(keyCode))
            {
                Player1_keyPressCount++;
            }
            if (Input.GetKeyUp(keyCode))
            {
                Player1_keyPressCount--;
            }
        }

        //Debug.Log("Keys pressed this frame: " + Player1_keyPressCount);
    }

    public void Plyer2_CheckKeyDown_btn()
    {
        foreach (KeyCode keyCode in Player2_KC)
        {
            if (Input.GetKeyDown(keyCode))
            {
                Player2_keyPressCount++;
            }
            if (Input.GetKeyUp(keyCode))
            {
                Player2_keyPressCount--;
            }
        }

        //Debug.Log("Keys pressed this frame: " + Player2_keyPressCount);
    }


    public void ActionControl(KeyCode a , KeyCode d, KeyCode w, KeyCode s,GameObject player ,int pressCount,
                                    GameObject AttackCollison, GameObject DefenceCollision, GameObject PressCollision)
    {
        Animator _anim = player.GetComponent<Animator>();

       

        if (Input.GetKeyDown(a))             //Defence
        {
            _anim.SetInteger(Animator_name, 1);
            AttackCollison.SetActive(false);
            DefenceCollision.SetActive(true);
            PressCollision.SetActive(true);

        }
        else if (Input.GetKeyDown(d))        //Attack
        {
            _anim.SetInteger(Animator_name, 2);
            AttackCollison.SetActive(false);
            DefenceCollision.SetActive(false);
            PressCollision.SetActive(true);
        }
        else if (Input.GetKeyDown(w))       //GoBack
        {
            _anim.SetInteger(Animator_name, 3);
            AttackCollison.SetActive(false);
            DefenceCollision.SetActive(false);
            PressCollision.SetActive(false);
        }
        else if (Input.GetKeyDown(s))       //Press
        {
            _anim.SetInteger(Animator_name, 4);
            AttackCollison.SetActive(false);
            DefenceCollision.SetActive(false);
            PressCollision.SetActive(true);

        }
        else if (pressCount <= 0)   //Idle
        {
            _anim.SetInteger(Animator_name, 0);
            AttackCollison.SetActive(true);
            DefenceCollision.SetActive(false);
            PressCollision.SetActive(false);

        }

        
    }

    public void ActionControl_Player1()
    {
        ActionControl(KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S, Player1, Player1_keyPressCount, AttackCollision_Player1, DefenceCollision_Player1, PressCollision_Player1);
    }
    public void ActionControl_Player2()
    {
        ActionControl(KeyCode.L, KeyCode.J, KeyCode.I, KeyCode.K, Player2, Player2_keyPressCount, AttackCollision_Player2, DefenceCollision_Player2, PressCollision_Player2);
    }
}

