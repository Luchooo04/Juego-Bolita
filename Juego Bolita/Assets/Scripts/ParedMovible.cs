using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedMovible : MonoBehaviour
{

    bool tengoQueBajar = false;
    int rapidez = 10;

    void Update()
    {
        if (transform.position.y >= 8)
        {
            tengoQueBajar = true;
        }
        if (transform.position.y <= 2)
        {
            tengoQueBajar = false;
        }

        if (tengoQueBajar)
        {
            Bajar();
        }
        else
        {
            Subir();
        }

    }

    void Subir()
    {
        transform.position += transform.up * rapidez * Time.deltaTime;
    }

    void Bajar()
    {
        transform.position -= transform.up * rapidez * Time.deltaTime;
    }
}