using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Tag")]
    [SerializeField] string _audioTag;

    private void Awake()
    {
        GameObject audioObj = GameObject.FindWithTag(_audioTag);
        if (audioObj != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.tag = _audioTag;
            DontDestroyOnLoad(gameObject);
        }
            
    }
}
