using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaybetmeController : MonoBehaviour
{
    private sahnekontrolu yonetici;
    private void OnTriggerEnter2D(Collider2D other) {
        yonetici=GameObject.FindObjectOfType<sahnekontrolu>();
        yonetici.SahneyeYonlen("Kaybetme");
    }
}
