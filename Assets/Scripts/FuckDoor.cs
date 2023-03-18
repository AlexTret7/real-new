using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckDoor : MonoBehaviour
{
    [SerializeField]
    public Animator test;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag=="kek")
        {
            test.SetBool("P1", true);
        }
        
        Debug.Log(other.tag);
    }

    private void OnTriggerExit(Collider other)
    {
     
        if (other.tag == "kek")
        {
            test.SetBool("P1", false);
        }
    }
}
