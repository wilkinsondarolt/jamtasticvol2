using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour {
    public Image about;
    public AudioClip clip;
    public Sprite idle;
    public Sprite disabled;

	public void StartGame()
    {
        SoundController.instance.PlaySingle(clip);
        GameController.instance.StartGame();
    }

    public void AboutGame()
    {
        SoundController.instance.PlaySingle(clip);
        about.transform.SetAsLastSibling();        
    }

    public void returnAbout()
    {
        SoundController.instance.PlaySingle(clip);
        about.transform.SetAsFirstSibling();
    }

    public void SoundEnableDisable()
    {
        SoundController.instance.PlaySingle(clip);
        GameController.instance.Sounds = !GameController.instance.Sounds;

        if (GameController.instance.Sounds)
        {
            SoundController.instance.EnableSounds();
            this.GetComponent<Image>().sprite = idle;            
        }
        else
        {
            SoundController.instance.DisableSounds();
            this.GetComponent<Image>().sprite = disabled;
        }            
    }

    public void QuitGame()
    {
        SoundController.instance.PlaySingle(clip);
        Application.Quit();
    }
}
