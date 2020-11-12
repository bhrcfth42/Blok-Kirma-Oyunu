using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunTopuController : MonoBehaviour
{
    public OyunBarıController oyunBari;
    private bool basladiMi;
    private Vector3 TopIleBarArasındakiMesafe;
    // Start is called before the first frame update
    void Start()
    {
        TopIleBarArasındakiMesafe = this.transform.position - oyunBari.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!basladiMi)
        {
            this.transform.position = oyunBari.transform.position + TopIleBarArasındakiMesafe;
            if (Input.GetMouseButtonDown(0))
            {
                basladiMi = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 14f);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
        if (basladiMi)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += ufakSapma;
        }
    }
}
