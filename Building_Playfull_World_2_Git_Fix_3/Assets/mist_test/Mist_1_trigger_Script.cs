using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mist_1_trigger_Script : MonoBehaviour
{
    public Animator Mist_Controller;
    public string enterTriggerName = "EnterTrigger";
    public string exitTriggerName = "ExitTrigger";
    public MeshRenderer triggerVolume;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MeshRenderer>() == triggerVolume)
        {
            Mist_Controller.SetTrigger(enterTriggerName);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<MeshRenderer>() == triggerVolume)
        {
            Mist_Controller.SetTrigger(exitTriggerName);
        }
    }
}


