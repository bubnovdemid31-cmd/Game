using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtControll : MonoBehaviour
{
    public GameObject[] cubesOn, cubesOf;

    public Material normal, transp;
    public ButtControll but;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("cube"))
        {
            for(int i = 0; i < cubesOf.Length; i++)
            {
                cubesOf[i].GetComponent<Renderer>().material = transp;
                cubesOf[i].GetComponent<BoxCollider>().isTrigger = true;
                GetComponent<Renderer>().material = transp;
                but.GetComponent<Renderer>().material = normal;

            }
            for (int i = 0; i < cubesOn.Length; i++)
            {
                cubesOn[i].GetComponent<Renderer>().material = normal;
                cubesOn[i].GetComponent<BoxCollider>().isTrigger = false;
                GetComponent<Renderer>().material = transp;
                but.GetComponent<Renderer>().material = normal;

            }
        }
    }
}
