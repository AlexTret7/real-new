using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu: MonoBehaviour
{
    [SerializeField]
    public GameObject test;
    void Start()
    {

        test.SetActive(true);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            test.SetActive(!test.active);
            
        }

    }
}
