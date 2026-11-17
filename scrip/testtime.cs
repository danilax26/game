using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class testtime : MonoBehaviour
{ public float times = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called  once per frame
    void Update()
    { 
      times =  Time.time;;
       Console.WriteLine(times);
    }
}
