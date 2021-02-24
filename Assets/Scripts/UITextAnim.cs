using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextAnim : MonoBehaviour
{
    [SerializeField] Text text;
    bool IsBright = true;

    // Update is called once per frame
    void Update()
    {
        if(text.color.a >= 0.9f)
        {
            IsBright = true;
        }
        else if(text.color.a <= 0.3f)
        {
            IsBright = false;
        }
        if (IsBright)
        {
            Color nCol = text.color;
            nCol.a = Mathf.Lerp(nCol.a, 0.2f, 2.0f * Time.deltaTime);
            text.color = nCol;
        }
        else
        {
            Color nCol = text.color;
            nCol.a = Mathf.Lerp(nCol.a, 1.0f, 2.0f * Time.deltaTime);
            text.color = nCol;
        }
    }
}
