using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float waktu;
    public float MaxWaktu;
    public TMP_Text timerText;
    public bool waktuBerjalan = true;
    public KeyCode StartCoroutineKey;
    public KeyCode StopCoroutineKey;
    public Coroutine hitungTimeCoroutine;
    public Image ProgressFillA;

    private void Update()
    {
        if (Input.GetKeyDown(StartCoroutineKey))
        {
            if (hitungTimeCoroutine == null)
            {
                hitungTimeCoroutine = StartCoroutine(hitungtimer());   
            }
        }
        if (Input.GetKeyDown(StopCoroutineKey))
        {
            if (hitungTimeCoroutine != null)
            {
                StopCoroutine(hitungTimeCoroutine);
                hitungTimeCoroutine = null;                
            }
        }
        
    }

    IEnumerator hitungtimer()
    {
        while (waktuBerjalan == true && waktu < MaxWaktu)
        {
            waktu = waktu + 1;
            timerText.text = waktu.ToString();
            ProgressFillA.fillAmount = waktu / MaxWaktu;
            yield return new WaitForSeconds(1);
        }
       
    }
}
