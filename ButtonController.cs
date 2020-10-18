using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public bool volume = true;
    public Image popup;
    public Image menu;
    public Button help;
    public Button sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Music()
    {
        if(volume == true)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1.0f;
        }
    }
    void Help()
    {
        popup.enabled = true;
        StartCoroutine("Popup");

    }
    void Menu()
    {
        menu.enabled = !menu.enabled;
        help.enabled = !menu.enabled;
        sound.enabled = !menu.enabled;

    }
    public IEnumerator Popup()
    {
        while (!Input.GetMouseButton(0))
        {
            yield return null;
        }
        popup.enabled = false;
    }
}
