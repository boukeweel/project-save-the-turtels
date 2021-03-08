using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GrotenTrashcann[] GT;

    private List<int> Test = new List<int>();
    private void Start()
    {
        Test.Add(GT[0].afvalErIn);
        Test.Add(GT[1].afvalErIn);
        Test.Add(GT[2].afvalErIn);
        Test.Add(GT[3].afvalErIn);
    }
    public void Update()
    {
        
        
    }
    private void MeesteInTrashCan()
    {
       
    }


}
