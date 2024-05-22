using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCorr : MonoBehaviour
{
    float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyMethod(1f));
    }

    IEnumerator MyMethod(float delayTime)
    {

        while(count<1)
        {
            count = count + 0.1f;
            yield return new WaitForSeconds(delayTime);
            print("Count: " + count);
        }
    }

    private void Update()
    {
        print("Update");
    }
}
