using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class yükleniyor : MonoBehaviour
{
    public Image resim;
    public float toplam = 325;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int b = 1;
        RectTransform asd = resim.GetComponent<RectTransform>();
        float a = asd.sizeDelta.x;
        asd.sizeDelta = new Vector2(asd.sizeDelta.x + b, asd.sizeDelta.y);
        if (a == toplam)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        
    }
}
