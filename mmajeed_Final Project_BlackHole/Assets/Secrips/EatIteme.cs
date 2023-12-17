using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatIteme : MonoBehaviour
{
    public int score;
    public TMP_Text text;

    private void Update()
    {
        text.text = score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            other.gameObject.GetComponent<Collider>().enabled = false;
            transform.localScale += new Vector3(0.5f, 0, 0.5f);
            score++;
        }

        if (other.CompareTag("chicken"))
        {
            other.gameObject.GetComponent<Collider>().enabled = false;
            transform.localScale += new Vector3(0.9f, 0, 0.9f);
            score = score + 2;
        }
    }
}