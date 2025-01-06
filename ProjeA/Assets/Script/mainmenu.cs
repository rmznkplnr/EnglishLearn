using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    public GameObject setpanel, categoripanel,anamenu;

    public void PlayGame()
    {
        SceneManager.LoadScene("scene2");
    }
    public void AnimKategori()
    {
        SceneManager.LoadScene("animal");
    }
    public void Ayarlar()
    {
        setpanel.SetActive(true);
        anamenu.SetActive(false);

    }
    public void Back()
    {
        setpanel.SetActive(false);
        anamenu.SetActive(true);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void CategoriMenu()
    {
        categoripanel.SetActive(true);
        anamenu.SetActive(false);

    }
    public void CateBack()
    {
        categoripanel.SetActive(false);
        anamenu.SetActive(true);


    }
    public void Alphabet1()
    {

    }

}
