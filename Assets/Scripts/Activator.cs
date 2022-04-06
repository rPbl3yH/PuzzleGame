using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    [SerializeField] GameObject[] _activeGroup;
    [SerializeField] GameObject[] _disactiveGroup;

    [SerializeField] Activator _oppositeButton;

    [SerializeField] Material _natural;
    [SerializeField] Material _transparent;

    public bool CanPush;

    private void OnTriggerEnter(Collider other)
    {
        if (CanPush)
        {
            if (other.CompareTag("Player") || other.CompareTag("Cube"))
            {
                foreach (GameObject cube in _activeGroup)
                {
                    cube.GetComponent<Renderer>().material = _transparent;
                    cube.GetComponent<Collider>().isTrigger = true;
                }

                foreach (GameObject cube in _disactiveGroup)
                {
                    cube.GetComponent<Renderer>().material = _natural;
                    cube.GetComponent<Collider>().isTrigger = false;
                }

                if (_oppositeButton)
                {
                    _oppositeButton.CanPush = true;
                    _oppositeButton.GetComponent<Renderer>().material = _natural;
                }
                
                GetComponent<Renderer>().material = _transparent;
            }
        }
        
    }
}
