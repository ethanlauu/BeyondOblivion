using UnityEngine;
using System.Collections;

public class TextFade1 : MonoBehaviour
{
    float time = 5;

    void Update()
    {
        if (Time.time > time)
        {
            Destroy(gameObject);
        }
        /*
        Color myColor = BluePortaltxt.color;
        float ratio = Time.time / time;
        myColor.a = Mathf.Lerp(1, 0, ratio);
        BluePortaltxt.color = myColor;*/

    }
}
