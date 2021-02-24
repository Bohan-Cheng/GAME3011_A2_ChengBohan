using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCover : MonoBehaviour
{
    [SerializeField] float LifeTime = 3.0f;
    [SerializeField] GameObject OpenText;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        Destroy(OpenText);
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        if (rigid)
        {
            rigid.gravityScale = 5;
        }
        Invoke("DestroyCcover", LifeTime);
    }

    void DestroyCcover()
    {
        Destroy(gameObject);
    }
}
