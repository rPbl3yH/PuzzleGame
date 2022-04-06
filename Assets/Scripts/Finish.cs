using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] KeyCode _restartKey;
    [SerializeField] KeyCode _nextLevelKey;
    [SerializeField] KeyCode _prevLevelKey;

    [SerializeField] int _nextIdScene;
    [SerializeField] int _prevIdScene;
    [SerializeField] int _currentIdScene;

    private void Start()
    {
        _currentIdScene = SceneManager.GetActiveScene().buildIndex;
        _nextIdScene = _currentIdScene + 1;
        if(_currentIdScene != 0)
        {
            _prevIdScene = _currentIdScene - 1;
        }
    }

    private void Update()
    {
        if (Input.GetKey(_restartKey))
        {
            SceneManager.LoadScene(_currentIdScene);
        }
        if (Input.GetKey(_prevLevelKey) && _currentIdScene != 0)
        {
            SceneManager.LoadScene(_prevIdScene);
        }
        if (Input.GetKey(_nextLevelKey))
        {
            SceneManager.LoadScene(_nextIdScene);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && CompareTag("Finish"))
        {
            SceneManager.LoadScene(_nextIdScene);
        }
    }
}
