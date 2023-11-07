using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    int contoh;
    int contoh2;
    bool condition1;
    int[] array;

    private void Awake()
    {
        IniMethod("1");
    }

    private void OnEnable()
    {
        IniMethod("Onenable");
    }

    // Start is called before the first frame update
    void Start()
    {
        IniMethod("a");
        Vector3 vector3 = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        contoh = 10;
        contoh2 = 20;
        condition1 = false;
        Debug.Log(contoh);

        for (int i=0; i<10; i++)
        {
            array[i] = i*2;
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (condition1==true)
        //{
        //    Debug.Log("Ini benar");
        //}
        //else
        //{
        //    Debug.Log("Ini salah");
        //}

        //foreach (int i in array)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Debug.Log("okay!");
        //    }
        //    else
        //    {
        //        Debug.Log("Not okay :(");
        //    }
            
        //}
        
    }

    private void LateUpdate()
    {
        Debug.Log("late update");
    }

    public void IniMethod(string s)
    {
        s = "Ini method";
        Debug.Log(s);
    }

    public void IniMethod(int i)
    {
        Debug.Log(i);
    }

}
