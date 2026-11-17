using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour


{    Animator anim1;
private string currentState;
public SC_WeaponManager manager;
public SC_Weapon sc;
const string RELOAD = "reload";
//const string
const string FIRE = "fire";
const string idle = "idle";
    // Start is called before the first frame update
    void Start()
    {
      anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void ChangeAnimation(string newStateName)
    {  if (currentState == newStateName) return;
        anim1.Play(newStateName); 
        currentState = newStateName;
    }
    void FixedUpdate()
    {
      if (Input.GetMouseButtonDown(0) && sc.singleFire)
        {
            ChangeAnimation(FIRE);
        }
        if (Input.GetMouseButton(0) && !sc.singleFire)
        {
            ChangeAnimation(FIRE);
        }
        if (Input.GetKeyDown(KeyCode.R) && sc.canFire)
        {
            ChangeAnimation(RELOAD);
        }
        else  ChangeAnimation(idle);
    }
    
}
