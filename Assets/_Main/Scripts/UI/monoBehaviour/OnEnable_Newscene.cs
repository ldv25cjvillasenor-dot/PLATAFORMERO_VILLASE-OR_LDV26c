using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OnEnable_Newscene : MonoBehaviour
{
    public SceneTransition sceneTransition;

    public void OnClick()
    {
        sceneTransition.StartFade();
    }
}
  
