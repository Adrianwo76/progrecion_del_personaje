using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caracteristicas : MonoBehaviour
{
    public int Hp;
    public int Hp_Max;
    public int Level;
    public float Exp;
    public float Exp_Max;

    public int Vitalidad;
    public int Fuerza;
    public int Agilidad;
    public int Magia;
    public int Defensa;

    public int Stats;


    public Text Hp_Texto;
    public Text Level_Texto;
    public Text Exp_Texto;

    public Text Vitalidad_Texto;
    public Text Fuerza_Texto;
    public Text Agilidad_Texto;
    public Text Magia_Texto;
    public Text Defensa_Texto;

    public Text Stats_Texto;


    void Subir_Exp()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Exp += 10;
        }

        if (Exp >= Exp_Max)
        {
            Level++;
            Exp_Max = Mathf.RoundToInt(Exp_Max * 1.5f);
            Stats += 5;
        }
    }

    private void Update()
    {
        Subir_Exp();
        Texto_Interfaz();
    }

    public void Subir_Vitalidad()
    {
        if (Stats > 0)
        {
            Vitalidad++;
            Stats--;
        }
    }

    public void Subir_Fuerza()
    {
        if (Stats > 0)
        {
            Fuerza++;
            Stats--;
        }

        
    }

    public void Subir_Agilidad()
    {
        if (Stats > 0)
        {
            Agilidad++;
            Stats--;
        }
    }

    public void Subir_Magia()
    {
        if (Stats > 0)
        {
            Magia++;
            Stats--;
        }
    }

    public void Subir_Defensa()
    {
        if (Stats > 0)
        {
            Defensa++;
            Stats--;
        }
    }


    public void Bajar_Vitalidad()
    {
        if (Vitalidad > 50)
        {
            Vitalidad--;
            Stats++;
        }
    }

    public void Bajar_Fuerza()
    {
        if (Fuerza > 30)
        {
            Fuerza--;
            Stats++;
        }
    }

    public void Bajar_Agilidad()
    {
        if (Agilidad > 25)
        {
            Agilidad--;
            Stats++;
        }
    }

    public void Bajar_Magia()
    {
        if (Magia > 40)
        {
            Magia--;
            Stats++;
        }
    }

    public void Bajar_Dedensa()
    {
        if (Defensa > 20)
        {
            Defensa--;
            Stats++;
        }
    }

    public void Texto_Interfaz()
    {
        Hp_Texto.text = "" + Hp + "/" + Hp_Max;
        Level_Texto.text = "" + Level;
        Exp_Texto.text = "" + Exp + "/" + Exp_Max;

        Vitalidad_Texto.text = "" + Vitalidad;
        Fuerza_Texto.text = "" + Fuerza;
        Agilidad_Texto.text = "" + Agilidad;
        Magia_Texto.text = "" + Magia;
        Defensa_Texto.text = "" + Defensa;

        Stats_Texto.text = "" + Stats;

        Hp_Max = Vitalidad;
    }
}
