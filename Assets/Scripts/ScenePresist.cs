using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePresist : MonoBehaviour
{
    void Awake() {
        int numScenePresists = FindObjectsOfType<ScenePresist>().Length;
        if (numScenePresists > 1){
            Destroy(gameObject);
        } else
            DontDestroyOnLoad(gameObject);
    }

    public void ResetScenePresist(){
        Destroy(gameObject);
    }
}
