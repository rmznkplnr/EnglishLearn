using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneGecisleri : MonoBehaviour
{
    public Animator gecisnanim;
    public void LoadSceneVoid  (string sceneName)
    {   
        StartCoroutine(LoadScene(sceneName));
    }
    IEnumerator LoadScene(string sceneName)
    {
        gecisnanim.SetBool("Exit", true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
    public void Anasahne()
    {
        SceneManager.LoadScene("scene1");
    }
}
