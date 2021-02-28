using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagGlass : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pin")
        {
            LockButton lb = collision.gameObject.GetComponent<LockButton>();
            lb.Highlight();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Pin")
        {
            LockButton lb = collision.gameObject.GetComponent<LockButton>();
            lb.StopHighlight();
        }
    }
}
