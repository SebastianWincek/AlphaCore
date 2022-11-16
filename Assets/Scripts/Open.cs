using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    Animator _doorAnim;
    private void OnTriggerEnter(Collider other)
    {
        _doorAnim.SetBool("Open", true);
    }
    private void OnTriggerExit(Collider other)
    {
        _doorAnim.SetBool("Open", false);
    }

    void Start()
    {
        _doorAnim = this.transform.parent.GetComponent<Animator>();
    }
    void Update()
    {

    }


}