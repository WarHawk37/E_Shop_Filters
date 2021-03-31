using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemManager : MonoBehaviour
{
    public Item[] items;
    public Transform clothsDisplay;
    public Transform watchDisplay;
    public Transform jewelleryDisplay;
    public List<Item> cloths;
    public List<Item> jewellery;
    public List<Item> watches;
    public Transform clothsToggles;
    public Transform jewelleryToggles;
    public Transform watchesToggles;

  
   

  
    // Start is called before the first frame update

    private void Awake()
    {
      
    }
    void Start()
    {

        items = Resources.FindObjectsOfTypeAll<Item>();
        foreach (var item in items)
        {
            CategorizeItem(item);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void clothswomenFilter( bool  isOn )
    {
        if (isOn)
        {


            foreach (Transform child in clothsDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in cloths)
            {
                if (item.user.ToString() == "women")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, clothsDisplay) as Item;
                    i.transform.SetAsFirstSibling();

                }

            }

        }
        

    }

    public  void ClothsKidsFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in clothsDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in cloths)
            {
                if (item.user.ToString() == "kids")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, clothsDisplay) as Item;
                    i.transform.SetAsFirstSibling();

                }

            }

        }
    }


    public void ClothsMenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in clothsDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in cloths)
            {
                if (item.user.ToString() == "men")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, clothsDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }

    public void JewelleryMenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in jewelleryDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in jewellery)
            {
                if (item.user.ToString() == "men")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, jewelleryDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }
    public void JewelleryKidsFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in jewelleryDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in jewellery)
            {
                if (item.user.ToString() == "kids")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, jewelleryDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }
    public void JewelleryWomenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in jewelleryDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in jewellery)
            {
                if (item.user.ToString() == "women")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, jewelleryDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }

    public void OnResetButtonClick( string cat )
    {

        

        switch (cat)
        {
            case "jewellery":

                foreach (Transform child in jewelleryToggles)
                {

                    if (child.GetComponent<Toggle>().isOn)
                    {
                        child.GetComponent<Toggle>().isOn = false;
                    }
                }



                foreach (Transform child in jewelleryDisplay)
                {
                    GameObject.Destroy(child.gameObject);
                }

                foreach (var item in jewellery)
                {

                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, jewelleryDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();



                }
                break;

           
            case "watches":
                foreach (Transform child in watchesToggles)
                {

                    if (child.GetComponent<Toggle>().isOn)
                    {
                        child.GetComponent<Toggle>().isOn = false;
                    }
                }



                foreach (Transform child in watchDisplay)
                {
                    GameObject.Destroy(child.gameObject);
                }
                foreach (var item in watches)
                {

                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, watchDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();



                }
                break;
            case "cloths":

                foreach (Transform child in clothsToggles)
                {

                    if (child.GetComponent<Toggle>().isOn)
                    {
                        child.GetComponent<Toggle>().isOn = false;
                    }
                }


                foreach (Transform child in clothsDisplay)
                {
                    GameObject.Destroy(child.gameObject);
                }
                foreach (var item in cloths)
                {

                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, clothsDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }
                break;
            default:
                break;
        }
       
    }

    public void WatchesMenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in watchDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in watches)
            {
                if (item.user.ToString() == "men")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, watchDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }
    public void WatchesKidsFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in watchDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in watches)
            {
                if (item.user.ToString() == "kids")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, watchDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }
    public void WatchesWomenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (Transform child in watchDisplay)
            {
                GameObject.Destroy(child.gameObject);
            }


            foreach (var item in watches)
            {
                if (item.user.ToString() == "women")
                {
                    Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, watchDisplay) as Item;
                    i.gameObject.SetActive(true);
                    i.transform.SetAsFirstSibling();

                }

            }

        }

    }

    public void CategorizeItem( Item item)
    {

        switch (item.category.ToString())
        {
            case "cloths":
                cloths.Add(item);
                Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, clothsDisplay) as Item;
                break;
            case "watches":
                watches.Add(item);
                Item j = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, watchDisplay) as Item;
                break;
            case "jewellery":
                jewellery.Add(item);
                Item k = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, jewelleryDisplay) as Item;
                break;
            default:
                break;
        }

       


    }


}
