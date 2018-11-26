using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    private void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

    public void ChangeScene(string scenename)
    {
        Application.LoadLevel(scenename);

    }
}