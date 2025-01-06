using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class RaycastAlpha : MonoBehaviour
{
    public GameObject clickedObject;
    void Update()
    {
        StartCoroutine(RaycastBeklet());
    }
    IEnumerator RaycastBeklet()
    {
        yield return new WaitForSeconds(16f);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                clickedObject = hit.collider.gameObject;
                AudioSource audio = clickedObject.GetComponent<AudioSource>();
                Renderer renderer = clickedObject.GetComponent<Renderer>();
                if (audio != null)
                {
                    audio.Play();
                }
                if (renderer != null)
                {
                    float hue = Random.Range(0f, 1f);
                    float saturation = Random.Range(0f, 1f);
                    float value = Random.Range(0f, 1f);
                    renderer.material.color = Color.HSVToRGB(hue, saturation, value);
                }
            }
        }
    }
}
