using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Factory _factory;
    public string Nombre;
   
    public void ActivarFactory()
    {
        _factory.CreateSkill(Nombre, this.transform);
    }

    
}
