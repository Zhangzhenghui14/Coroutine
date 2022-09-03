using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private IEnumerator enumerator;
    // Start is called before the first frame update
    void Start()
    {
        enumerator = test();
        CoroutineManager.Instance.StartCoroutine(enumerator);
        Invoke("stop",5);
    }

    void stop()
    {
        Debug.Log("停止协程");
        CoroutineManager.Instance.StopCoroutine(enumerator);
    }

    IEnumerator test()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("每隔一秒打印一次日志");
        }
    }
}
