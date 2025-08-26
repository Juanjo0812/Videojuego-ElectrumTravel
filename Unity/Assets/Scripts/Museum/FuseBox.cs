using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseBox : MonoBehaviour
{
    private int fuse = 7;
    private bool activeLever = false;
    [SerializeField] 
    private GameObject fuseOne;
    [SerializeField] 
    private GameObject fuseSpec;

    private void Start()
    {
        activeLever = false;
    }

    private void Update()
    {
        if (fuse >= 8)
        {
            activeLever = true;
        }
    }

    public void missingFuse()
    {
        fuse++;
        fuseOne.SetActive(true);
        fuseSpec.SetActive(false);
    }
}
