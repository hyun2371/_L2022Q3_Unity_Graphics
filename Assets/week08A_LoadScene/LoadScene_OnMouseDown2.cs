using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene_OnMouseDown2 : MonoBehaviour
{
    public Object SceneToLoad;
    private void OnMouseDown()
    {
        //SceneManager.LoadScene("LoadSceneTest02");
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
