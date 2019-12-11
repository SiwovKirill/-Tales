using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music music;

    public GameObject mainCam;
    public bool musik, sound; 
    // Start is called before the first frame update
    void Start()
    {
        sound = true;
        musik = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusik(string name)
    {
        if (musik)
        {
        AudioSource audio = mainCam.AddComponent<AudioSource>();
        audio.clip = Resources.Load<AudioClip>("Audio/" + name);
        audio.Play();
        Destroy(audio, audio.clip.length);
        }
    }

    public void Musik()
    {
        if (musik)
            musik = false;
        else musik = true;
    }

    public void Sound()
    {
        if (sound)
            sound = false;
        else sound = true;
    }
}
