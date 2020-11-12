using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnekontrolu : MonoBehaviour
{
    public void SonrakiSahne()
    {
        int mevcutSahneninIndexi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(mevcutSahneninIndexi + 1);
    }
    public void SahneyeYonlen(string sahneİsmi)
    {
        SceneManager.LoadScene(sahneİsmi);
    }
    public void OyunSahnesineYonlen()
    {
        SceneManager.LoadScene(1);
    }
    public void OyundanCikis()
    {
        Application.Quit();
    }
    public void menuSahnesneYonlen()
    {
        SceneManager.LoadScene(0);
    }
    public void BloklarınBitmesi()
    {
        if (BloklarController.kirilabilirBlokSayisi <= 0)
        {
            SonrakiSahne();
        }
    }
}
