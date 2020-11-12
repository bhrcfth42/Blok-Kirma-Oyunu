using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloklarController : MonoBehaviour
{
    public GameObject efekt;
    public static int kirilabilirBlokSayisi=0;
    private bool kirilabilirMi;
    private int can;
    private int vurulmasayisi;
    private sahnekontrolu sahnekontrolu;
    public Sprite[] blokgörünümleri;
    // Start is called before the first frame update
    void Start()
    {
        kirilabilirMi = (this.tag == "Kırılabilir Blok");
        if (kirilabilirMi)
        {
            kirilabilirBlokSayisi++;
        }
        sahnekontrolu = GameObject.FindObjectOfType<sahnekontrolu>();
        vurulmasayisi = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<AudioSource>().Play();
        if (kirilabilirMi)
        {
            Vurulma();
        }
    }
    public void Vurulma()
    {
        can = blokgörünümleri.Length + 1;
        vurulmasayisi++;
        if (vurulmasayisi >= can)
        {
            kirilabilirBlokSayisi--;
            EfektOlustur();
            Destroy(gameObject);
            sahnekontrolu.BloklarınBitmesi();
        }
        else
        {
            BlokGoruntusuDegistir();
        }
    }
    void EfektOlustur()
    {
        GameObject efektimiz = Instantiate(efekt, gameObject.transform.position, Quaternion.identity);
        efektimiz.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
    }
    public void SonrakiSahne()
    {
        sahnekontrolu.SonrakiSahne();
    }
    public void BlokGoruntusuDegistir()
    {
        this.GetComponent<SpriteRenderer>().sprite = blokgörünümleri[vurulmasayisi - 1];
    }
}
