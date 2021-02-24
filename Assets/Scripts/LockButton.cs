using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockButton : MonoBehaviour
{
    bool Unlocked = false;
    [SerializeField] int Order = 0;
    [SerializeField] float ResetTime = 5;
    [SerializeField] float OpenPosY;
    Vector3 OriginPos;

    void Start()
    {
        OriginPos = transform.position;
    }

    void Update()
    {
        if(Unlocked)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, OpenPosY, transform.position.z), 10.0f * Time.deltaTime);
        }
        else
        {
            if (transform.position != OriginPos)
            {
                transform.position = Vector3.Lerp(transform.position, OriginPos, 10.0f * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pick" && !Unlocked)
        {
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
            Unlocked = true;
            Invoke("ResetPin", ResetTime);
        }
    }

    void ResetPin()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        Unlocked = false;
    }
}
