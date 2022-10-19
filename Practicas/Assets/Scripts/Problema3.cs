using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema3 : MonoBehaviour
{
      public int[] nums = new int[4] {11,7,2,15};


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Problema 3:");
        int result = sumaMayordeSubarray(nums);
        Debug.Log(string.Join(", ", result));
        
    }
    public int sumaMayordeSubarray(int[] nums)
    {
        int result=0;
        int i = 0,j = 0,cont = 0;

        for(i=0 ; i<nums.Length -1 ; i++)
		{
			 cont= nums[i];
			 if(cont > result)
				{
					result=cont;
				}
			 for(j=i+1 ; j<=nums.Length - 1 ; j++)
			 {
				cont +=nums[j];
				if(cont > result)
				{
					result=cont;
				}
			 }
			
		}
        return result;
    }

}
