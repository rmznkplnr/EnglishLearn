using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aphabet2 : MonoBehaviour
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
        StartCoroutine(I());
    }

    IEnumerator I()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[0].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[0].GetComponent<Animator>();
        alphaAnim.SetBool("I", true);
        StartCoroutine(J());


    }
    IEnumerator J()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[1].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[1].GetComponent<Animator>();
        alphaAnim.SetBool("J", true);
        StartCoroutine(K());


    }
    IEnumerator K()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[2].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[2].GetComponent<Animator>();
        alphaAnim.SetBool("K", true);
        StartCoroutine(L());


    }
    IEnumerator L()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[3].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[3].GetComponent<Animator>();
        alphaAnim.SetBool("L", true);
        StartCoroutine(M());


    }

    IEnumerator M()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[4].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[4].GetComponent<Animator>();
        alphaAnim.SetBool("M", true);
        StartCoroutine(N());


    }

    IEnumerator N()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[5].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[5].GetComponent<Animator>();
        alphaAnim.SetBool("N", true);
        StartCoroutine(O());


    }
    IEnumerator O()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[6].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[6].GetComponent<Animator>();
        alphaAnim.SetBool("O", true);
        StartCoroutine(P());


    }
    IEnumerator P()
    {
        yield return new WaitForSeconds(2);
        ses = alphabet[7].GetComponent<AudioSource>();
        ses.PlayDelayed(1f);
        alphaAnim = alphabet[7].GetComponent<Animator>();
        alphaAnim.SetBool("P", true);


    }
}
