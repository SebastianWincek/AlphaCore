using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_Sound : MonoBehaviour
{
    private void Start()
    {

            FindObjectOfType<AudioManager>().Play("TorchSound");
    }

    private void Update()
    {

    }
    
}
