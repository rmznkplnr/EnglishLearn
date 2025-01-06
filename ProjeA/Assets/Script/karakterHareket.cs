using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterHareket : MonoBehaviour
{
    

    Animator animator;
    
    // Start is called before the first frame update
    
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Yurume());
     
    }

    IEnumerator Yurume()
    {
        yield return new WaitForSeconds(4);
        animator.SetInteger("hareket", 0);
        StartCoroutine(Dance());


    }
    IEnumerator Dance()
    {
        yield return new WaitForSeconds(4);
        animator.SetInteger("dans", 1);
        


    }
   





}



