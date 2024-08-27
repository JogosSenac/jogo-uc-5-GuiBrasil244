using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    // Start is called before the first frame update

    public static int money = 0;
    public GameObject objetoTexto;
    void Start()
    {
        objetoTexto = GameObject.FindWithTag("TextoMoney");
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            money++;
            objetoTexto.GetComponent<TextMeshProUGUI>().text = "Money: 0  " + money;
        }
        
    }
}
