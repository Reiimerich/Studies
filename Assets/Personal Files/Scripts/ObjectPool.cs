using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects; //Se crea una lista de objectos que seran almacenados para su uso durante la accion
    public GameObject objectToPool; //El objeto que vamos a requerir crear
    public int amountToPool; //Cantidad de objetos que seran creados

    private void Awake()
    {
        SharedInstance = this; //Se instancia el objeto, de esta manera solo habra uno de estos activos durante todas las escenas
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>(); //Se crea una nueva lista de objetos que seran utilizados, esto para que en cada prueba empiece desde 0
        GameObject temp; //Se crea un objeto temporal que sera el asignado de almacenar los valores del gameObject
        for(int i=0; i < amountToPool; i++)
        {
            //Se crean los objetos que van a ser utilizados si el boton es presionado y se desactivan para que no aparezcan en escena
            temp = Instantiate(objectToPool);
            temp.SetActive(false);
            pooledObjects.Add(temp); //Cada uno de ellos es añadido a la lista
        }
    }

    public GameObject GetPooledObjet()
    {
        //Se hace una revision de los objetos que puedan ser generados en la lista
        for(int i=0;i < amountToPool; i++)
        {
            //Si no se encuentran objetos activos en la hierarquia
            if (!pooledObjects[i].activeInHierarchy)
            {
                //Añadelos a la misma
                return pooledObjects[i];
            }
        }
        //Si se encuentran, no hagas nada
        return null;
    }
}
