using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string _sceneName;
    public Animator Fader;

    private void Awake()
    {
        if (Fader == null)
        {
            Fader = GetComponent<Animator>();
        }
    }


    public void StartFade()
    {
        Fader.SetBool("Newscene?", true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("PLATAFORMERO");
    }
}
