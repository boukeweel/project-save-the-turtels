using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GrotenTrashcann[] GT;

    private List<int> Test = new List<int>();
    private void Start()
    {
        Test.Add(GT[0].afvalerin);
        Test.Add(GT[1].afvalerin);
        Test.Add(GT[2].afvalerin);
        Test.Add(GT[3].afvalerin);
    }
    public void Update()
    {
        
        
    }
    private void MeesteInTrashCan()
    {
       
    }


}
