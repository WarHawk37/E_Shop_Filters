using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public enum Category { cloths, watches, jewellery };
    public enum User { women, kids, men };
    public int price;
    public Category category = Category.cloths;
    public User user = User.kids;


    private void Start()
    {

        this.transform.GetChild(1).gameObject.GetComponent<Text>().text = category.ToString();
        this.transform.GetChild(2).gameObject.GetComponent<Text>().text = price.ToString();
        this.transform.GetChild(3).gameObject.GetComponent<Text>().text = user.ToString();


    }
}
