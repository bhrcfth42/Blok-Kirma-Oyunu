using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunBarıController : MonoBehaviour
{
    public bool otomatikPlay = false;
    private oyunTopuController oyunTopu;
    // Start is called before the first frame update
    void Start()
    {
        oyunTopu = GameObject.FindObjectOfType<oyunTopuController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (otomatikPlay)
        {
            OtomatikHareket();
        }
        else
        {
            FareHareket();
        }

    }
    void FareHareket()
    {
        Vector3 oyunBariKonumu = new Vector3(0f, this.transform.position.y, 0f);//Oyun barı y değerini tutuyoz
        float mouseKonumX = Input.mousePosition.x / Screen.width * 16;//mouse positionunu al ama bunu 18 kare yanyana olduğu için ona göre hesapla x değerini
        oyunBariKonumu.x = Mathf.Clamp(mouseKonumX, 0f, 16f);
        this.transform.position = oyunBariKonumu;
    }
    void OtomatikHareket()
    {
        Vector3 oyunBariKonumu = new Vector3(0, this.transform.position.y, 0);//Oyun barı y değerini tutuyoz
        Vector3 topunKonumu = oyunTopu.transform.position;
        oyunBariKonumu.x = Mathf.Clamp(topunKonumu.x, 0f, 16f);
        this.transform.position = oyunBariKonumu;
    }
}
