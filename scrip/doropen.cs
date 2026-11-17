using UnityEngine;

public class doropen : MonoBehaviour
{ private Animator ss;

public bool InCollider = false;
  public SC_EnemySpawner sc;
  public int needpoint = 200;
    // Start is called before the first frame update
    void Start()
    {
       ss = GetComponent<Animator>();
    }
     void update() {
          if (sc.Point < needpoint && Input.GetKeyDown(KeyCode.F) && InCollider){ ss.Play("dor"); 
          }

                  }
void OnTriggerStay(Collider other)
{
    InCollider = true;
}
 void OnTriggerExit(Collider other)
 {
    InCollider = false; 
 }                               

    
}
