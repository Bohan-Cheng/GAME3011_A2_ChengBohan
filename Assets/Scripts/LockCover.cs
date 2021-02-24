using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCover : MonoBehaviour
{
    [SerializeField] float LifeTime = 3.0f;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
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
