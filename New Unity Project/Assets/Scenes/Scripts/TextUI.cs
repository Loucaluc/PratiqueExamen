using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUI : MonoBehaviour {

    public GameObject text;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = FindObjectOfType<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Fire1") != 0)
        {
            Instantiate(text,transform);
            System.Threading.Thread.Sleep(2000);
            audioSource.Play();
        }
    }
}   
