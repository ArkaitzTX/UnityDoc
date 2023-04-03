using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PruebaClases.m1
{
    // Clases, interfaces, enumeraciones y otros tipos
    //creo un objeto del tipo de mi Funcion para almacenar las funciones que sean de este tipo y asi poder tratarlas como una variable
    public delegate int FuncionRes();

    public class miObjeto
    {

        //Basico

        //protected->Desde la misma clase
        //internal->Accesible dentro del ensamblado
        //vacio->Desde este script

        private string nombre = "prueba";
        private int v1, v2;
        private FuncionRes miResultado;

        public miObjeto(int v2, int v1)
        {
            this.v2 = v2;
            this.v1 = v1;
            MiResultado = new FuncionRes(Resultados);
        }

        public string CambioNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public FuncionRes MiResultado
        {
            get => miResultado;
            set => miResultado = value;
        }


        // funciones expresión
        public int Resultados() => v1 + v2;


    }

    //Herencia, polimorfismo y Abstraccion
    public abstract class Animal
    {
        public string Nombre { get; set; }
        //Funcion principal
        public abstract void HacerSonido();
    }

    public class Perro : Animal
    {
        //Funcion secundaria
        public override void HacerSonido()
        {
            Debug.Log("¡Guau!");
        }
    }

    public class Gato : Animal
    {
        //Funcion secundaria
        public override void HacerSonido()
        {
            Debug.Log("¡Miau!");
        }
    }

    //--------------------------
    public abstract class AnimalAbs
    {
        public abstract void HacerSonido();
    }

    public class PerroAbs : AnimalAbs
    {
        public override void HacerSonido()
        {
            Debug.Log("¡Guau!");
        }
    }

    public class GatoAbs : AnimalAbs
    {
        public override void HacerSonido()
        {
            Debug.Log("¡Miau!");
        }
    }


    //Metodos de extencion

    public static class ExtencioString
    {
        public static string Invertir(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

}

