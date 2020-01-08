using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    public Text BeginText;
    // Start is called before the first frame update
    void Start()
    {
        BeginText = GetComponent<Text>();
        var tempcolor = BeginText.color;
        tempcolor.a = 0.1f;
        BeginText.color = tempcolor;
        BeginText.CrossFadeAlpha(255f, 3f, false);
        FadeOut();
    }

    // Update is called once per frame
    void FadeOut()
    {
        BeginText.CrossFadeAlpha(0f, 3f, false);
    }
}
