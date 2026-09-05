using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HidingTheText : MonoBehaviour
{
    void HideText()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        Invoke(nameof(HideText), 3f);
    }
}
