using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphapet : MonoBehaviour
{
    private GameObject[] alphabet;
    public Transform alphabet_child;
    private Animator alphaAnim;
    AudioSource ses;


    private void Start()
    {
        int count = alphabet_child.childCount;
        alphabet = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            alphabet[i] = alphabet_child.GetChild(i).gameObject;
        }
        StartCoroutine(A());
    }
    IEnumerator A()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[0].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[0].GetComponent<Animator>();
        alphaAnim.SetBool("A", true);
        StartCoroutine(B());


    }
    IEnumerator B()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[1].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[1].GetComponent<Animator>();
        alphaAnim.SetBool("B", true);
        StartCoroutine(C());


    }
    IEnumerator C()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[2].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[2].GetComponent<Animator>();
        alphaAnim.SetBool("C", true);
        StartCoroutine(D());


    }
    IEnumerator D()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[3].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[3].GetComponent<Animator>();
        alphaAnim.SetBool("D", true);
        StartCoroutine(E());


    }

    IEnumerator E()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[4].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[4].GetComponent<Animator>();
        alphaAnim.SetBool("E", true);
        StartCoroutine(F());


    }

    IEnumerator F()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[5].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[5].GetComponent<Animator>();
        alphaAnim.SetBool("F", true);
        StartCoroutine(G());


    }
    IEnumerator G()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[6].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[6].GetComponent<Animator>();
        alphaAnim.SetBool("G", true);
        StartCoroutine(H());


    }
    IEnumerator H()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[7].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[7].GetComponent<Animator>();
        alphaAnim.SetBool("H", true);


    }
   


}
