using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LognManager : MonoBehaviour
{
    public string contra;
    public InputField imputContra;
    // Start is called before the first frame update

    public void fuuncionPassword()
    {
        if (imputContra.text == contra)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }

}
