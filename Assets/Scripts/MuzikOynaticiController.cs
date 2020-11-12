using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikOynaticiController : MonoBehaviour
{
    static MuzikOynaticiController tekMuzikOynaticisi = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start komutu çalıştı");
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Awake Öncelik Çalışmaya sahip fonksiyon
    private void Awake()
    {
        Debug.Log("Awake Komutu Çalıştı");
        if (tekMuzikOynaticisi != null)
        {
            Destroy(gameObject);
        }
        else
        {
            tekMuzikOynaticisi = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
