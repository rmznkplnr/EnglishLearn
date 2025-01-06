using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sorudizi : MonoBehaviour
{
    [SerializeField] private gameUI gameui;
    [SerializeField] private QuizData quizData;
    private List<Question> questions;
    private Question selectedQuestion;
    int i = 0,score=0;
    private GameObject tebriklerpanel;
    public Text puantxt;
    public Text sonscore;
    AudioSource ses;
    public AudioClip dogses, yanses;

    private void Start()
    {
        ses = GetComponent<AudioSource>();
        tebriklerpanel = GameObject.Find("tebrikler");
        puantxt.text = "Score: " + score;
        tebriklerpanel.SetActive(false);
        questions = quizData.questions;
        SelectQuestion();

    }
    private void SelectQuestion()
    {
       
        selectedQuestion = questions[i];
        gameui.SetQuestion(selectedQuestion);

        if (i ==11 )
        {
            sonscore.text ="Score: " + score;
            tebriklerpanel.SetActive(true);
        }
        i++;




        //int val = Random.Range(0, questions.Count);
        //selectedQuestion = questions[val];
        //gameui.SetQuestion(selectedQuestion);
    }
    public bool Answer(string answered)
    {
        bool correctAns = false;

        if(answered==selectedQuestion.correctAns)
        {
            ses.clip = dogses;
            ses.Play();
            correctAns = true;
            score += 10;
            puantxt.text = "Score: " + score;


        }
        else
        {
            ses.clip = yanses;
            ses.Play();

        }

        Invoke("SelectQuestion", 1f);

        return correctAns;

    }
    public void LoadScrene()
    {
        SceneManager.LoadScene("scene1");
    }
    public void Reset()
    {
        i = 0;
        score = 0;
        tebriklerpanel.SetActive(false);
        puantxt.text = "Score: " + score;

        SelectQuestion();


    }



}


[System.Serializable]
public class Question
{
    public string questionInfo;         
    public QuestionType questionType;   
    public Sprite questionImg;        
    public AudioClip audioClip;         
    public UnityEngine.Video.VideoClip videoClip;   
    public List<string> options;        
    public string correctAns;           
}

[System.Serializable]
public enum QuestionType    
{
    TEXT,
    IMAGE,
    AUDIO,
    VIDEO
}
[SerializeField]
public enum GameStatus
{
    PLAYING,
    NEXT
}
