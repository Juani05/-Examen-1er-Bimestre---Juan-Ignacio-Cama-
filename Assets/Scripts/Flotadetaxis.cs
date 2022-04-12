using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotadetaxis : MonoBehaviour
{
    public int cantidaddeunidadesdetaxis;
    public int cantidaddedías;
    public int cantidaddedíasdelluvia;
    // Start is called before the first frame update
    void Start()
    {
        int litrosquesegastanenundíanormal;
        int litrosquesegastanenundíadelluvia;
        int díasdelluviaydíasnormales;
        int costodelitrosendíadelluvia;
        int costodelitrosendíanormal;
        int costototaldíasdelluvia = 0;
        int costototaldíasnormales = 0;
        int costototal;
        díasdelluviaydíasnormales = cantidaddedías + cantidaddedíasdelluvia;
        if (cantidaddedías > 0)
        {
            litrosquesegastanenundíanormal = (90 / 15);
            costodelitrosendíanormal = (litrosquesegastanenundíanormal) * 130;
            costototaldíasnormales = (costodelitrosendíanormal) * (cantidaddedíasdelluvia);
        }
        else if (cantidaddedíasdelluvia > 0)
        {
            litrosquesegastanenundíadelluvia = (110 / 15);
            costodelitrosendíadelluvia = (litrosquesegastanenundíadelluvia) * 130;
            costototaldíasdelluvia = (costodelitrosendíadelluvia) * (cantidaddedías);
        }

        costototal = (costototaldíasdelluvia + costototaldíasnormales) * cantidaddeunidadesdetaxis;

        Debug.Log("Una flota de " + cantidaddeunidadesdetaxis + " unidades trabajando durante " + díasdelluviaydíasnormales +
            " días implicará un gasto de " + costototal + " pesos en concepto de combustible");
     if (díasdelluviaydíasnormales < 5 || díasdelluviaydíasnormales > 7 || cantidaddedíasdelluvia < 0)
        {
            Debug.Log("ERROR");
        }
    }

    // Update is called once per frame}

    void Update()
    {
        
    }
}
