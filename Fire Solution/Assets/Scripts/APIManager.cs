using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class APIManager : MonoBehaviour
{
    public GameObject fireTemplate;
    // Start is called before the first frame update
    void Start()
    {
        JToken fighters = CallAPI("https://prod-12.australiasoutheast.logic.azure.com:443/workflows/954e7fbaeb3c4947819ba0823d5d5999/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=tjz08Xt2xdzVK61RysoFF7npUFxIFumx9VnNuQCik-o");
        string fighterString = "";
        foreach (var fighter in fighters)
        {
            fighterString += fighter["Name"].ToString() + ", ";
        }
        fighterString = fighterString.Substring(0, fighterString.Length - 2);
        GameObject fireObject = Instantiate(fireTemplate, new Vector3(0f, 4f, -8f), Quaternion.identity);
        FireManager fireManager = fireObject.GetComponent<FireManager>();

        fireManager.mrtkToolTip.ToolTipText = fighterString;
        //fireManager.CrteateHammer();
    }

    // Update is called once per frame
    public JToken CallAPI(string uri)
    {
        HttpWebRequest requestHandler = (HttpWebRequest)WebRequest.Create(uri);
        HttpWebResponse responseHandler = (HttpWebResponse)requestHandler.GetResponse();

        StreamReader reader = new StreamReader(responseHandler.GetResponseStream());
        string response = reader.ReadToEnd();

        Debug.Log(response);

        JToken jsonResponse = JToken.Parse(response);

        return jsonResponse;
    }
}
