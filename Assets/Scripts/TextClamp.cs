using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextClamp : MonoBehaviour
{

    public TMP_Text clampedText;

    void Update()
    {
        Vector3 textPos = Camera.main.WorldToScreenPoint(this.transform.position);
        clampedText.transform.position = textPos;
    }
}
