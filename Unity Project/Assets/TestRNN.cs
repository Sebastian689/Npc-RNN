using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class TestRNN : MonoBehaviour
{
    [DllImport("RNN")]
    public static extern int test_number();
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(test_number());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
