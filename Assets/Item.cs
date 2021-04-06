using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;


public static class EnumExtensions
{
    public static Enum GetRandomEnumValue(this Type t)
    {
        return Enum.GetValues(t)          // get values from Type provided
            .OfType<Enum>()               // casts to Enum
            .OrderBy(e => Guid.NewGuid()) // mess with order of results
            .FirstOrDefault();            // take first item in result
    }
}
public class Item : MonoBehaviour
{
    

    public enum Category { cloths  , watches , jewellery  };
    public enum User { women , kids , men };

    public int price;
    public Category category  ;
    public User user ;


    private void Awake()
    {
        price = UnityEngine.Random.Range(500, 1000); 
        category = (Category)UnityEngine.Random.Range(0, 3);
        
        user = (User)UnityEngine.Random.Range(0, 3);
    }
    private void Start()
    {
       

        this.transform.GetChild(1).gameObject.GetComponent<Text>().text = user.ToString();
        this.transform.GetChild(2).gameObject.GetComponent<Text>().text =category.ToString();
        this.transform.GetChild(3).gameObject.GetComponent<Text>().text = price.ToString();


    }
}
