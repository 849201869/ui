using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_vclose : MonoBehaviour {
    public AudioClip baojin;
    public AudioSource audiosource;
    public Toggle tog;
    public void set_close()
    {
        transform.gameObject.SetActive(false);
    }
    public void music_control()
    {
        audiosource.clip = baojin;
        if (tog.isOn&&audiosource.isPlaying)
        {
        }
        else if (tog.isOn && !audiosource.isPlaying)
        {
            audiosource.Play();
        }
        else
        {
            audiosource.Pause();
            
        }
        
    }
}
