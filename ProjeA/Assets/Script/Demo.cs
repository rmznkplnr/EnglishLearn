
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Video;
using System.Collections;
using UnityEngine.SceneManagement;


public class Demo : MonoBehaviour {

	private GameObject[] animal;
	private int animalIndex;
	public Transform animal_parent;
	public TMP_Dropdown dropdownAnimal;
	public Button prevbut, nextbut, gamebut;
	private AudioSource ses;
	private VideoPlayer player;
	public GameObject video;
	public VideoClip[] clips;
	private int videoclipsindex;
	public GameObject quizgirispanel;


	Animator animator;


	void Start()
	{

		gamebut.gameObject.SetActive(false);
		dropdownAnimal.interactable = false;
		player = video.GetComponent<VideoPlayer>();
		player.clip = clips[0];
		animator = video.GetComponent<Animator>();

		//video.SetActive(false);
		//StartCoroutine(VideoBeklet());
		//StartCoroutine(VideoKapat());
		Invoke("VideoBeklet", 4f);
		int count = animal_parent.childCount;
		animal = new GameObject[count];
		List<string> animalList = new List<string>();
		

		for (int i = 0; i < count; i++)
		{
			animal[i] = animal_parent.GetChild(i).gameObject;
			string n = animal_parent.GetChild(i).name;
			animalList.Add(n);
			// animalList.Add(n.Substring(0, n.IndexOf("_")));
			
			if (i == 0) animal[i].SetActive(true);
			else animal[i].SetActive(false);
		}
		
		dropdownAnimal.AddOptions(animalList);
		ses = animal[0].GetComponent<AudioSource>();
		Sesbasla();

		Bounds b = animal[0].transform.GetChild(0).GetChild(0).GetComponent<Renderer>().bounds;
			
		prevbut.interactable = false;

	}

	void Update()
	{

		if(player.isPaused)
		{
			//yield return new WaitForSeconds(6f);

			//video.SetActive(false);
			player.Stop();
		}

	}


	public void NextAnimal()
	{
		video.SetActive(false);
		dropdownAnimal.value++;
		videoclipsindex++;
		if (dropdownAnimal.value >= dropdownAnimal.options.Count - 1)
		{
			nextbut.gameObject.SetActive(false);
			//dropdownAnimal.value = 0;
			gamebut.gameObject.SetActive(true);

		}

		ChangeAnimal();
		//if (videoclipsindex >= clips.Length-1)
		//	videoclipsindex = 0;
		//else
		//	videoclipsindex++;

		

		player.clip = clips[videoclipsindex];
		CancelInvoke("VideoBeklet");
		Invoke("VideoBeklet", 3f);
		//StartCoroutine(VideoBeklet());
		//StartCoroutine(VideoKapat());
		prevbut.interactable = true;
	}

	public void PrevAnimal()
	{

		video.SetActive(false);
		animator.StopPlayback();
		//if (dropdownAnimal.value == 0)
		//{
		//	prevbut.interactable = false;
		//	//dropdownAnimal.value = dropdownAnimal.options.Count - 1;
		//}

		//else
		//{
			dropdownAnimal.value--;
			videoclipsindex--;
		//}
		if (dropdownAnimal.value == 0)
		{
			prevbut.interactable = false;
			//dropdownAnimal.value = dropdownAnimal.options.Count - 1;
		}


		ChangeAnimal();
		nextbut.gameObject.SetActive(true);
		gamebut.gameObject.SetActive(false);


		//if (videoclipsindex <= 0)
		//	//videoclipsindex = clips.Length - 1;
		//else
		//	//videoclipsindex--;

		player.clip = clips[videoclipsindex];
		CancelInvoke("VideoBeklet");
		//Invoke("VideoBeklet", 3f);
		//StartCoroutine(VideoBeklet());
		//StartCoroutine(VideoKapat());
	}

	public void ChangeAnimal()
	{
		
		animal[animalIndex].SetActive(false);
		animal[dropdownAnimal.value].SetActive(true);
		animalIndex = dropdownAnimal.value;
		ses=animal[animalIndex].GetComponent<AudioSource>();
		Seskapat();
		Sesbasla();
		

	}
	void Sesbasla()
	{
		ses.PlayDelayed(1f);
	}
	void Seskapat()
	{
		ses.Stop();
	}

	void VideoBeklet()
	{
		//yield return new WaitForSeconds(1f);
		video.SetActive(true);

		animator.SetBool("gel", true);
		animator.SetBool("git", false);

		player.Play();
		Invoke("VideoKapat", 4f);
	}
	void VideoKapat()
	{
		animator.SetBool("git", true);
		animator.SetBool("gel", false);




		//yield return new WaitForSeconds(6f);
		//video.SetActive(false);
		//player.Stop();

	}

	public void Yenile()
	{
		Sesbasla();
	}
	public void VideoBut()
	{
		CancelInvoke("VideoKapat");

		video.SetActive(false);

		VideoBeklet();

	}
	public void QuizLoad()
	{
		quizgirispanel.SetActive(true);
		Time.timeScale = 0f;
		
		
	}
	public void QuizPanelEnter()
	{
		Time.timeScale = 1f;

		SceneManager.LoadScene("quiz");
	}
	public void QuizPanelExit()
	{
		quizgirispanel.SetActive(false);
		Time.timeScale = 1f;



	}



}