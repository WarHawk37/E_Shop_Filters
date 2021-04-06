using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemManager : MonoBehaviour
{
    public Item[] items =new Item[50];
    public Transform clothsDisplay;
    public Transform watchDisplay;
    public Transform jewelleryDisplay;
    public List<Item> cloths;
    public List<Item> jewellery;
    public List<Item> watches;
    public Transform clothsToggles;
    public Transform jewelleryToggles;
    public Transform watchesToggles;
    public Item itemPrefab;




    // Start is called before the first frame update

    private void Awake()
    {

        for (int i = 0; i < items.Length; i++)
        {
            Item t = Instantiate(itemPrefab, this.gameObject.transform);
            items[i] = t ;

        }
    }

    void Start()
    {


        //items = Resources.FindObjectsOfTypeAll<Item>();
        foreach (var item in items)
        {
            CategorizeItem(item);
        }


    }


    
    public void clothswomenFilter( bool  isOn )
    {
        if (isOn)
        {


            foreach (var item in cloths)
            {
                if (item.user.ToString() == "women")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }
        

    }

    public  void ClothsKidsFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (var item in cloths)
            {
                if (item.user.ToString() == "kids")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }
    }


    public void ClothsMenFilter(bool isOn)
    {
        if (isOn)
        {

            foreach (var item in cloths)
            {
                if (item.user.ToString() == "men")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }

    }

    public void JewelleryMenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (var item in jewellery)
            {
                if (item.user.ToString() == "men")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }

    }
    public void JewelleryKidsFilter(bool isOn)
    {
        if (isOn)
        {

            foreach (var item in jewellery)
            {
                if (item.user.ToString() == "kids")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }

    }
    public void JewelleryWomenFilter(bool isOn)
    {
        if (isOn)
        {


            foreach (var item in jewellery)
            {
                if (item.user.ToString() == "women")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
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


                foreach (var item in jewellery)
                {
                   
                        if (!item.gameObject.activeSelf)
                        {
                            item.gameObject.SetActive(true);
                            item.transform.SetAsFirstSibling();
                        }
                        else
                        {
                            item.transform.SetAsFirstSibling();
                        }


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


                foreach (var item in watches)
                {

                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


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


                foreach (var item in cloths)
                {

                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


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


            //foreach (Transform child in watchDisplay)
            //{
            //    GameObject.Destroy(child.gameObject);
            //}


            foreach (var item in watches)
            {
                if (item.user.ToString() == "men")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }

                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }

    }
    public void WatchesKidsFilter(bool isOn)
    {
        if (isOn)
        {




            foreach (var item in watches)
            {
                if (item.user.ToString() == "kids")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }
                    

                }
                else
                {

                    item.gameObject.SetActive(false);
                }

            }

        }

    }
    public void WatchesWomenFilter(bool isOn)
    {
        if (isOn)
        {

            foreach (var item in watches)
            {
                if (item.user.ToString() == "women")
                {
                    if (!item.gameObject.activeSelf)
                    {
                        item.gameObject.SetActive(true);
                        item.transform.SetAsFirstSibling();
                    }
                    else
                    {
                        item.transform.SetAsFirstSibling();
                    }


                }
                else
                {

                    item.gameObject.SetActive(false);
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
                //Item i = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, clothsDisplay) as Item;
             
                item.transform.SetParent(clothsDisplay);
              
                item.transform.localScale = new Vector3(1, 1, 1);
                break;
            case "watches":
                watches.Add(item);
                //Item j = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, watchDisplay) as Item;
                item.transform.SetParent(watchDisplay);
               
                item.transform.localScale = new Vector3(1, 1, 1);
              
                break;
            case "jewellery":
                jewellery.Add(item);
                //Item k = Instantiate(item, new Vector3(0, 0, 0), Quaternion.identity, jewelleryDisplay) as Item;
                item.transform.SetParent(jewelleryDisplay);
               
                item.transform.localScale = new Vector3(1, 1, 1);


                break;
            default:
                break;
        }

       


    }


}
