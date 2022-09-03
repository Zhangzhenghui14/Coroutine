using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledCustomCoroutine : MonoBehaviour
{
    private void FixedUpdate()
    {
        CoroutineManager.Instance.UpdateCoroutine();
    }
}
