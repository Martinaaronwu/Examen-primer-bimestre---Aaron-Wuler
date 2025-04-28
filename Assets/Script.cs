using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int litro;
    int kilometros;
    float costoLitro;
    float descuento = 26; // el 20% de 130 es 26
    public int cantidadDeDias;
    public int flota;

    // Start is called before the first frame update
    void Start()
    {
        if (litro == 1)
        {
            costoLitro = 130;

        
        } else if (litro >= 2 && litro < 100 )
        {
            costoLitro = 130 * litro;

        } else if (litro >= 100)
        {
            costoLitro = litro * descuento;

        }

        Debug.Log("Una flota de " + flota + " unidades trabajando durante " + cantidadDeDias + " días implicará un gasto de " + costoLitro + "$ pesos en concepto de combustible.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
