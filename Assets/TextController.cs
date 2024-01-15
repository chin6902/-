using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    float speed = 1.0f;
    float time;
    TMP_Text text;

    void Start()
    {
        text = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (text != null)
        {
            text.color = GetAlphaColor(text.color);
        }
    }

    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 3.5f * speed;
        color.a = Mathf.Sin(time);

        return color;
    }
}
