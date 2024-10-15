using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //Zona de variables globales
    public int IntegerNumber = -35; // 32bits. De -2B a +2B;
    public float StudentGrade = 8.5f; // 32bits. DECIMALES;
    public string StudentName = "Alarico"; // Letras;
    public bool IsAnActiveStudent = true; // True o False;
    public char Password = '*'; 
    public long BigNumber = 123456789; // 64bits;
    public double BigStudentGrade = 8.55555d; // 64bits. DECIMALES;
    public byte LittleNumber = 255; // 8bits. De 0 a 255;
    public byte ExampleAdd = 134;


    // Start is called before the first frame update
    void Start()
    {
        IntegerNumber = 5 + 8 - ((9 * 8) / 7);
        LittleNumber = 2 % 1; // LittleNumber = 0 buscamos el RESTO (Modulo o %) de la division;
        LittleNumber = 3 % 2; // LittleNumber = 1; 

        //Imprimir en la Consola - Concatenacion - Con "" se concatena. Sin """ se suma;
        //Debug.Log("El resultado de la operacion de modulo es: " + LittleNumber);
        Debug.Log(LittleNumber + 1234);
        Debug.Log("El numero mas pequeno \"pequeno\" del mundo \n es: " + LittleNumber);
    }

    // Update is called once per frame
    void Update()
    {
        StudentGrade = StudentGrade + 1; // StudentGrade++ ; // StudentGrade +=1 ; 

        LittleNumber = 254;
        Debug.Log(LittleNumber);

    }
}
