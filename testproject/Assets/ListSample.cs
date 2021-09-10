using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSample : MonoBehaviour
{

    List<string> sampleList;
    public Dictionary<string, string> alumniDic;
    // Start is called before the first frame update
    void Start()
    {
        //sampleList = new List<string>();
        //sampleList.Add("silvio");
        //sampleList.Add("leonardo");
        //sampleList.Add("jesus");
        //sampleList.Add("daniel");
        //sampleList.Add("liann");
        //sampleList.Add("claudia");

        //if (sampleList.Contains("liann")) 
        //{
        //    int index = sampleList.BinarySearch("liann");
        //    Debug.Log(index);
        //}

        alumniDic = new Dictionary<string, string>();

        alumniDic.Add("rifle", "10f");
        alumniDic.Add("pistola", "10f");
        alumniDic.Add("cuchillo", "10f");
        alumniDic.Add("bazooka", "7f");
       

        Debug.Log(alumniDic["rifle"]);


        //int[] bArray = new int[4];
        //bArray[1] = 5;
        //bArray[3] = 5;
        //foreach (int i in bArray)
        //{
        //    Debug.Log(i);
        //}
        //System.Array.Resize<int>(ref bArray, 8);
        //Debug.Log("this is the resized array");
        //foreach (int b in bArray)
        //{
        //    Debug.Log(b);
        //}
        //System.Array.Reverse(bArray);
        //Debug.Log("this is the reversed array");
        //foreach (int b in bArray)
        //{
        //    Debug.Log(b);
        //}
        //int contador = 0;
        //string[,] s2D = new string[4, 4];
        //string[][] jaggedArr = new string[3][];
        //jaggedArr[0] = new string[5];
        //jaggedArr[1] = new string[3];
        //jaggedArr[2] = new string[8];

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        s2D[i, j] = "char " + contador;
        //        contador++;
        //    }
        //}


        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Debug.Log(s2D[i,j]);
        //    }
        //}
        //Debug.Log("==============================================================");
        //for (int j = 0; j < 4; j++)
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Debug.Log(s2D[i, j]);
        //    }
        //}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
