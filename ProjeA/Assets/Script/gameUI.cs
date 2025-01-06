using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameUI : MonoBehaviour
{
    [SerializeField] private sorudizi sorudizi;
    [SerializeField] private Image questionimage;
    [SerializeField] private List<Button> options;
    [SerializeField] private Color correctCol, wrongCol, normalCol; 
    [SerializeField] private AudioSource questionAudio;
    [SerializeField] private UnityEngine.Video.VideoPlayer questionVideo;   




    private float audioLength;
    private Question question;
    private bool answered;
    void Awake()
    {
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn= options[i];
            localBtn.onClick.AddListener(() => Onclick(localBtn));
        }
        

    }
    public void SetQuestion(Question question)
    {
        this.question = question;
        switch (question.questionType)
        {
            case QuestionType.TEXT:
                break;
            case QuestionType.IMAGE:
                imageHolder();
                questionimage.transform.gameObject.SetActive(true);
                questionimage.sprite = question.questionImg;
                break;
            case QuestionType.AUDIO:
                imageHolder();
                questionAudio.transform.gameObject.SetActive(true);
                

                audioLength = question.audioClip.length;
                StartCoroutine(PlayAudio());
                break;
            case QuestionType.VIDEO:
                //imageHolder();
                //questionVideo.transform.gameObject.SetActive(true);
                //questionVideo.clip = question.qustionVideo;
                //questionVideo.Play();
                break;
            default:
                break;
        }

        List<string> answerList = ShuffleList.ShuffleListItems<string>(question.options);

        for (int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];
            options[i].image.color = normalCol;
        }
        answered = false;
    }

    IEnumerator PlayAudio()
    {
        if (question.questionType == QuestionType.AUDIO)
        {
            questionAudio.PlayOneShot(question.audioClip);
            yield return new WaitForSeconds(audioLength + 2f);
            StartCoroutine(PlayAudio());
        }
        else
        {

            StopCoroutine(PlayAudio());
            
            
            yield return null;
        }
    }
    void imageHolder()
    {
        questionimage.transform.parent.gameObject.SetActive(true);
        questionimage.transform.gameObject.SetActive(false);
        questionAudio.transform.gameObject.SetActive(false);
        questionVideo.transform.gameObject.SetActive(false);

    }

    private void Onclick(Button btn)
    {
        if (!answered)
        {
            answered = true;
            bool val = sorudizi.Answer(btn.name);
            if (val)
            {
                btn.image.color = correctCol;
            }
            else
            {
                btn.image.color = wrongCol;
            }
        }
    }
    public abstract class ShuffleList
    {
        public static List<E> ShuffleListItems<E>(List<E> inputList)
        {
            List<E> originalList = new List<E>();
            originalList.AddRange(inputList);
            List<E> randomList = new List<E>();

            System.Random r = new System.Random();
            int randomIndex = 0;
            while (originalList.Count > 0)
            {
                randomIndex = r.Next(0, originalList.Count); 
                randomList.Add(originalList[randomIndex]); 
                originalList.RemoveAt(randomIndex); 
            }

            return randomList; 
        }
    }

    
}
