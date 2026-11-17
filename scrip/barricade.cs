using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricade : MonoBehaviour
{ Animator anim;
public float barricadehp = 100;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision other)
{
    barricadehp -= 10; 
}
}